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
    public partial class FormSearchElement : Form
    {
        FormElements formMainSearch;
        public FormSearchElement(FormElements formMain)
        {
            InitializeComponent();
            formMainSearch = formMain;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchNum.Text, out int res2))
            {
                if (res2 <= formMainSearch.elements.Count)
                {
                    int rowIndex = -1;
                    string num = txtSearchNum.Text;
                    foreach (DataGridViewRow row in formMainSearch.Dgv.Rows)
                    {
                        if ((row.Cells["AtomicNum"].Value != null) && (row.Cells["AtomicNum"].Value.ToString().Equals(num)))
                        {
                            MessageBox.Show($"{(row.Cells[1].Value.ToString() == "" ? "No element":row.Cells[1].Value)} at {row.Cells[0].Value}", $"Result");
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    formMainSearch.Dgv.Rows[rowIndex].Selected = true;
                    formMainSearch.Dgv.FirstDisplayedScrollingRowIndex = formMainSearch.Dgv.SelectedRows[0].Index;
                }
                else
                {
                    MessageBox.Show("Atomic number not in the elements list", "Error");
                }
            }
            else
            {
                MessageBox.Show($"Please provide an integer!", "Error!");
            }
            
        }        
    }
}
