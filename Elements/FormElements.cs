using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements
{
    public partial class FormElements : Form
    {
        ElementsManager eleManager;
        public BindingList<Elements> elements;
        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }
        public FormElements()
        {
            InitializeComponent();
            elements = new BindingList<Elements>();
            eleManager = new ElementsManager();
        }
        private void btnLoadClubs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse For Elements.Txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    eleManager.Load(openFileDialog1.FileName, "|");
                    elements = eleManager.ListElements;
                    Dgv.DataSource = elements;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save Elements as Json";
            if (elements.Count == 0)
            {
                MessageBox.Show("Please Load elements before saving!", "Error!");
            }
            else
            {
                saveFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    eleManager.Save(saveFileDialog1.FileName, elements);
                    MessageBox.Show($"Saved to {saveFileDialog1.FileName}", "Success!");
                }
            }            
        }

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            FormAddElement formAdd = new FormAddElement(this);
            formAdd.ShowDialog(this);
        }

        private void btnSearchElement_Click(object sender, EventArgs e)
        {
            FormSearchElement formSearch = new FormSearchElement(this);
            formSearch.ShowDialog(this);
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    //dgv.Rows.Remove(row);
                    int key = row.Index;
                    elements.RemoveAt(key);
                    //elements[key].Name = "";
                    //elements[key].Symbol = "";
                    //elements[key].Description = "";
                }
                MessageBox.Show("Deletion Successful!", "Success!");
            }                    
            else if (dgv.SelectedRows.Count == 0 && dgv.Rows.Count > 0)
            {
                MessageBox.Show("No Row/Rows Selected");
            }
            else if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No Elements to Delete");
            }
        }
    }
}
