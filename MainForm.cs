using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Phonebook
{
    public partial class MainForm : Form
    {
        MainClass m = new MainClass();
        int counter=0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
          m.CreateXLinkedList();
          m.ReadAllContacts();
            DataNode[] dn = m.GetAllContacts();
            int j = 0;
            Point newLoc = new Point(5, 5);
            while (dn[j] != null)
            {
                MaterialRaisedButton b = new MaterialRaisedButton();
                b.Visible = true;
                b.Text = dn[j].storeFname+" " + dn[j].storeLname;
                b.BackColor = Color.White;
                b.Size = new Size(200, 50);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 5);
                this.ContactTabNamePanel.Controls.Add(b);    
                 b.Click += new EventHandler(b_Click);
            
               
                j++;
                counter ++;
            }
        
            materialLabel1.Text = Convert.ToString(counter) + " " + "Contacts Found";
        }

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


     

        private void ContactTabDetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            DataNode[] s = m.SearchContact(materialSingleLineTextField1.Text);
           
            Point newLoc = new Point(5, 5);
            int l = 0;
            this.ContactTabNamePanel.Controls.Clear();
            while (s[l] != null)
            {
                MaterialRaisedButton b = new MaterialRaisedButton();
                b.Visible = true;
                b.Text = s[l].storeFname + " " + s[l].storeLname;
                b.BackColor = Color.White;
                b.Size = new Size(200, 50);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 5);
                this.ContactTabNamePanel.Controls.Add(b);
                b.Click += new EventHandler(b_Click);
                l++;

            }
        }

        private void RadioA_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioA.Checked == true)
            {
                
                DataNode[] dn = new DataNode[10];
                RadioA.Text = RadioA.Text.ToUpper();
                dn = m.GetContactByIndex('A');

                Point newLoc = new Point(5, 5);
                int i = 0;
                this.ContactTabNamePanel.Controls.Clear();
                this.ContactTabDetailPanel.Controls.Clear();
                if (dn==null)
                {
                    MessageBox.Show("Error", "No Contacts Found", MessageBoxButtons.OK);
                }
                // Set whatever you want for initial location
                
                while (dn[i]!=null)
                
                {
                    MaterialRaisedButton b = new MaterialRaisedButton();
                    
                    b.Visible = true;
                    b.Text = dn[i].storeFname +" " +dn[i].storeLname;
                    b.BackColor = Color.White;
                    b.Size = new Size(200, 50);
                    b.Location = newLoc;
                    newLoc.Offset(0, b.Height + 5);
                    this.ContactTabNamePanel.Controls.Add(b);
                    b.Click += new EventHandler(b_Click);
                    b.Show();
                    i++;
                }



            }
        }

        private void RadioB_CheckedChanged(object sender, EventArgs e)
        {

            DataNode[] dn = new DataNode[10];
            RadioA.Text = RadioA.Text.ToUpper();
            dn = m.GetContactByIndex('B');

            Point newLoc = new Point(5, 5);
            int i = 0;
            this.ContactTabNamePanel.Controls.Clear();
            this.ContactTabDetailPanel.Controls.Clear();
            if (dn == null)
            {
                MessageBox.Show("Error", "No Contacts Found", MessageBoxButtons.OK);
            }
            // Set whatever you want for initial location

            while (dn[i] != null)

            {
                MaterialRaisedButton b = new MaterialRaisedButton();

                b.Visible = true;
                b.Text = dn[i].storeFname + dn[i].storeLname;
                b.BackColor = Color.White;
                b.Size = new Size(200, 50);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 5);
                this.ContactTabNamePanel.Controls.Add(b);
                b.Click += new EventHandler(b_Click);
                b.Show();
                i++;
            }



        
    }

        private void RadioZ_CheckedChanged(object sender, EventArgs e)
        {
            DataNode[] dn = new DataNode[100];
            RadioA.Text = RadioA.Text.ToUpper();
            dn = m.GetContactByIndex('Z');
            int j = 0;
            Point newLoc = new Point(5, 5);
            while (dn[j] != null)
            {
                MaterialRaisedButton b = new MaterialRaisedButton();
                b.Visible = true;
                b.Text = dn[j].storeFname + dn[j].storeLname;
                b.BackColor = Color.White;
                b.Size = new Size(200, 50);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 5);
                this.ContactTabNamePanel.Controls.Add(b);
                Console.WriteLine(dn[j].storeFname + dn[j].storeLname);
                j++;
            }

            // Set whatever you want for initial location
            for (int i = 0; i < dn.Length; i++)
            {

            }
        }

        private void RadioM_CheckedChanged(object sender, EventArgs e)
        {

            DataNode[] dn = new DataNode[10];
            RadioA.Text = RadioA.Text.ToUpper();
            dn = m.GetContactByIndex('M');

            Point newLoc = new Point(5, 5);
            int i = 0;
            this.ContactTabNamePanel.Controls.Clear();
            this.ContactTabDetailPanel.Controls.Clear();
            if (dn == null)
            {
                MessageBox.Show("Error", "No Contacts Found", MessageBoxButtons.OK);
            }
            // Set whatever you want for initial location

            while (dn[i] != null)

            {
                MaterialRaisedButton b = new MaterialRaisedButton();

                b.Visible = true;
                b.Text = dn[i].storeFname +" "+ dn[i].storeLname;
                b.BackColor = Color.White;
                b.Size = new Size(200, 50);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 5);
                this.ContactTabNamePanel.Controls.Add(b);
                b.Click += new EventHandler(b_Click);
                b.Show();
                i++;
            }



        
    }

        private void AddContactFormPanel_Click(object sender, EventArgs e)
        {
        }
        private void b_Click(object sender, EventArgs e)
        {
            string send = Convert.ToString(sender);
            send = send.Remove(0,50);
            //int l = send.Length;
            DataNode[] o =m.SearchContact(send);
            
            
            DetailForm dt=new DetailForm(o[0]);
             dt.TopLevel = false;
            this.ContactTabDetailPanel.Controls.Clear();
            this.ContactTabDetailPanel.Controls.Add(dt);
            dt.Show();
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           bool flag = m.IsNumAlreadyExists(metroTextBox1.Text+"-"+metroTextBox2.Text);
            if (flag==false)
            {
                AddContactForm add = new AddContactForm(metroTextBox1.Text +"-"+ metroTextBox2.Text);
                add.TopLevel = false;
                add.AutoScroll = true;
                this.AddContactMain.Controls.Add(add);
                add.Show();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.SaveAllContacts();
            this.Hide();
            this.Dispose();
        }

        private void RadioF_CheckedChanged(object sender, EventArgs e)
        {
            DataNode[] dn = new DataNode[10];
            RadioA.Text = RadioA.Text.ToUpper();
            dn = m.GetContactByIndex('F');

            Point newLoc = new Point(5, 5);
            int i = 0;
            this.ContactTabNamePanel.Controls.Clear();
            this.ContactTabDetailPanel.Controls.Clear();
            if (dn == null)
            {
                MessageBox.Show("Error", "No Contacts Found", MessageBoxButtons.OK);
            }
            // Set whatever you want for initial location

            while (dn[i] != null)

            {
                MaterialRaisedButton b = new MaterialRaisedButton();

                b.Visible = true;
                b.Text = dn[i].storeFname +" "+ dn[i].storeLname;
                b.BackColor = Color.White;
                b.Size = new Size(200, 50);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 5);
                this.ContactTabNamePanel.Controls.Add(b);
                b.Click += new EventHandler(b_Click);
                b.Show();
                i++;
            }



        
    }
    }
}

