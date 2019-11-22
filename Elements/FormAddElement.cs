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
    public partial class FormAddElement : Form
    {
        FormElements formMainAdd;

        public FormAddElement(FormElements formMain)
        {
            InitializeComponent();
            formMainAdd = formMain;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int.TryParse(txtNum.Text, out int res) && (res != 0)))
                {
                    if (res <= formMainAdd.elements.Count)
                    {
                        DialogResult result = MessageBox.Show($"{(formMainAdd.elements[res-1].Name == "" ? "No element" : formMainAdd.elements[res - 1].Name)} for Atomic Number {res}. Do you want to update" +
                                $" information?", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            formMainAdd.elements[res-1].AtomicNum = res;
                            formMainAdd.elements[res-1].Symbol = txtSymbol.Text;
                            formMainAdd.elements[res-1].Name = txtName.Text;
                            formMainAdd.elements[res-1].Description = txtDesc.Text;
                        }
                    }
                    else
                    {
                        Elements anElement = new Elements(int.Parse(txtNum.Text), txtSymbol.Text, txtName.Text, txtDesc.Text);
                        formMainAdd.elements.Add(anElement);
                        MessageBox.Show($"Added {txtName.Text} at {txtNum.Text} successfully!", "Success!");
                    }                  
                }
                else 
                {
                    MessageBox.Show("Provide a Valid Atomic Number\n\nRemember: Atomic Number must be greater than 0", "Error!");
                }                
            }
            catch { }            
        }
    }
}
