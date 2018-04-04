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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager sknmgr = MaterialSkin.MaterialSkinManager.Instance;
            sknmgr.AddFormToManage(this);

            sknmgr.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            sknmgr.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green400, MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Green400, MaterialSkin.TextShade.WHITE);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
        }
    }
}
