using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class AddContactForm : Form
    {
        string Num;
        public AddContactForm(string num)
        {
            InitializeComponent();
            Num = num;

        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            this.AddContactNum.Text = Num;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddContactFN.Text) || string.IsNullOrEmpty(AddContactLN.Text)|| string.IsNullOrEmpty(AddContactNum.Text) || string.IsNullOrEmpty(AddContactEmail.Text) || string.IsNullOrEmpty(AddContactAddress.Text)==true)

            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MainClass add = new MainClass();
                if (add.IsAvailableIndex(AddContactFN.Text[0]) || add.IsEmailAlreadyExists(AddContactEmail.Text) || add.IsNumAlreadyExists(AddContactNum.Text) == true)
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    add.AddToYLinkedList(AddContactFN.Text, AddContactLN.Text, AddContactEmail.Text,AddContactNum.Text, AddContactAddress.Text);
                    this.Close();
                }
            }
        }       
    }
}
