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
    public partial class DetailForm : Form
    {
        DataNode arr;
        public DetailForm(DataNode a)
        {
            InitializeComponent();
             arr = a;
            
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Text = arr.storeFname;
            materialSingleLineTextField2.Text = arr.storeLname;
            materialSingleLineTextField3.Text = arr.storeCnum;
            materialSingleLineTextField4.Text = arr.storeEmail;
            materialSingleLineTextField5.Text = arr.storeAddress;
            

           
           
            materialSingleLineTextField1.Enabled = false;
            materialSingleLineTextField2.Enabled = false;
            materialSingleLineTextField3.Enabled = false;
            materialSingleLineTextField4.Enabled = false;
            materialSingleLineTextField5.Enabled = false;
            
            materialRaisedButton1.Visible = false;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
           
            materialSingleLineTextField1.Enabled = true;
            materialSingleLineTextField2.Enabled = true;
            materialSingleLineTextField3.Enabled = true;
            materialSingleLineTextField4.Enabled = true;
            materialSingleLineTextField5.Enabled = true;
            materialRaisedButton1.Visible = true;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            MainClass mc = new MainClass();
           bool f= mc.DeleteFromYLinkedList(materialSingleLineTextField1.Text, materialSingleLineTextField2.Text);
            if (f==true)
            {
                this.Refresh();
                this.Dispose();   
            }
            else
            {
                MessageBox.Show("error", "error", MessageBoxButtons.OK);
            }
        }
    }
}
