namespace Phonebook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.Tab = new System.Windows.Forms.TabControl();
            this.ViewSearchTab = new System.Windows.Forms.TabPage();
            this.ContactTabDetailPanel = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ContactTabNamePanel = new System.Windows.Forms.Panel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.ContactTabIndexPanel = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MainFormAllContactRadio = new MetroFramework.Controls.MetroRadioButton();
            this.RadioZ = new MetroFramework.Controls.MetroRadioButton();
            this.RadioY = new MetroFramework.Controls.MetroRadioButton();
            this.RadioX = new MetroFramework.Controls.MetroRadioButton();
            this.RadioW = new MetroFramework.Controls.MetroRadioButton();
            this.RadioV = new MetroFramework.Controls.MetroRadioButton();
            this.RadioU = new MetroFramework.Controls.MetroRadioButton();
            this.RadioT = new MetroFramework.Controls.MetroRadioButton();
            this.RadioS = new MetroFramework.Controls.MetroRadioButton();
            this.RadioR = new MetroFramework.Controls.MetroRadioButton();
            this.RadioQ = new MetroFramework.Controls.MetroRadioButton();
            this.RadioP = new MetroFramework.Controls.MetroRadioButton();
            this.RadioO = new MetroFramework.Controls.MetroRadioButton();
            this.RadioN = new MetroFramework.Controls.MetroRadioButton();
            this.RadioM = new MetroFramework.Controls.MetroRadioButton();
            this.RadioL = new MetroFramework.Controls.MetroRadioButton();
            this.RadioK = new MetroFramework.Controls.MetroRadioButton();
            this.RadioJ = new MetroFramework.Controls.MetroRadioButton();
            this.RadioI = new MetroFramework.Controls.MetroRadioButton();
            this.RadioH = new MetroFramework.Controls.MetroRadioButton();
            this.RadioG = new MetroFramework.Controls.MetroRadioButton();
            this.RadioF = new MetroFramework.Controls.MetroRadioButton();
            this.RadioE = new MetroFramework.Controls.MetroRadioButton();
            this.RadioD = new MetroFramework.Controls.MetroRadioButton();
            this.RadioC = new MetroFramework.Controls.MetroRadioButton();
            this.RadioB = new MetroFramework.Controls.MetroRadioButton();
            this.RadioA = new MetroFramework.Controls.MetroRadioButton();
            this.AddContactFormPanel = new System.Windows.Forms.TabPage();
            this.AddContactMain = new System.Windows.Forms.Panel();
            this.AddContactNumCheckPanel = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.ViewSearchTab.SuspendLayout();
            this.ContactTabDetailPanel.SuspendLayout();
            this.ContactTabNamePanel.SuspendLayout();
            this.ContactTabIndexPanel.SuspendLayout();
            this.AddContactFormPanel.SuspendLayout();
            this.AddContactNumCheckPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 90);
            this.panel1.TabIndex = 1;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.Black;
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(4, 96);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(770, 2);
            this.materialDivider3.TabIndex = 8;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.ViewSearchTab);
            this.Tab.Controls.Add(this.AddContactFormPanel);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 90);
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(960, 653);
            this.Tab.TabIndex = 10;
            this.Tab.TabStop = false;
            // 
            // ViewSearchTab
            // 
            this.ViewSearchTab.Controls.Add(this.ContactTabDetailPanel);
            this.ViewSearchTab.Controls.Add(this.ContactTabNamePanel);
            this.ViewSearchTab.Controls.Add(this.ContactTabIndexPanel);
            this.ViewSearchTab.Location = new System.Drawing.Point(4, 22);
            this.ViewSearchTab.Name = "ViewSearchTab";
            this.ViewSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewSearchTab.Size = new System.Drawing.Size(952, 627);
            this.ViewSearchTab.TabIndex = 0;
            this.ViewSearchTab.Text = "Contacts";
            this.ViewSearchTab.UseVisualStyleBackColor = true;
            // 
            // ContactTabDetailPanel
            // 
            this.ContactTabDetailPanel.BackColor = System.Drawing.Color.White;
            this.ContactTabDetailPanel.Controls.Add(this.materialDivider2);
            this.ContactTabDetailPanel.Controls.Add(this.materialDivider1);
            this.ContactTabDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactTabDetailPanel.Location = new System.Drawing.Point(259, 68);
            this.ContactTabDetailPanel.Name = "ContactTabDetailPanel";
            this.ContactTabDetailPanel.Size = new System.Drawing.Size(690, 556);
            this.ContactTabDetailPanel.TabIndex = 2;
            this.ContactTabDetailPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContactTabDetailPanel_Paint);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.Black;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-200, 0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(774, 1);
            this.materialDivider2.TabIndex = 1;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Black;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 560);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ContactTabNamePanel
            // 
            this.ContactTabNamePanel.AutoScroll = true;
            this.ContactTabNamePanel.BackColor = System.Drawing.Color.White;
            this.ContactTabNamePanel.Controls.Add(this.materialDivider4);
            this.ContactTabNamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContactTabNamePanel.Location = new System.Drawing.Point(3, 68);
            this.ContactTabNamePanel.Name = "ContactTabNamePanel";
            this.ContactTabNamePanel.Size = new System.Drawing.Size(256, 556);
            this.ContactTabNamePanel.TabIndex = 1;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.Black;
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(3, 0);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(248, 1);
            this.materialDivider4.TabIndex = 1;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // ContactTabIndexPanel
            // 
            this.ContactTabIndexPanel.BackColor = System.Drawing.Color.White;
            this.ContactTabIndexPanel.Controls.Add(this.materialRaisedButton1);
            this.ContactTabIndexPanel.Controls.Add(this.materialDivider5);
            this.ContactTabIndexPanel.Controls.Add(this.materialSingleLineTextField1);
            this.ContactTabIndexPanel.Controls.Add(this.MainFormAllContactRadio);
            this.ContactTabIndexPanel.Controls.Add(this.RadioZ);
            this.ContactTabIndexPanel.Controls.Add(this.RadioY);
            this.ContactTabIndexPanel.Controls.Add(this.RadioX);
            this.ContactTabIndexPanel.Controls.Add(this.RadioW);
            this.ContactTabIndexPanel.Controls.Add(this.RadioV);
            this.ContactTabIndexPanel.Controls.Add(this.RadioU);
            this.ContactTabIndexPanel.Controls.Add(this.RadioT);
            this.ContactTabIndexPanel.Controls.Add(this.RadioS);
            this.ContactTabIndexPanel.Controls.Add(this.RadioR);
            this.ContactTabIndexPanel.Controls.Add(this.RadioQ);
            this.ContactTabIndexPanel.Controls.Add(this.RadioP);
            this.ContactTabIndexPanel.Controls.Add(this.RadioO);
            this.ContactTabIndexPanel.Controls.Add(this.RadioN);
            this.ContactTabIndexPanel.Controls.Add(this.RadioM);
            this.ContactTabIndexPanel.Controls.Add(this.RadioL);
            this.ContactTabIndexPanel.Controls.Add(this.RadioK);
            this.ContactTabIndexPanel.Controls.Add(this.RadioJ);
            this.ContactTabIndexPanel.Controls.Add(this.RadioI);
            this.ContactTabIndexPanel.Controls.Add(this.RadioH);
            this.ContactTabIndexPanel.Controls.Add(this.RadioG);
            this.ContactTabIndexPanel.Controls.Add(this.RadioF);
            this.ContactTabIndexPanel.Controls.Add(this.RadioE);
            this.ContactTabIndexPanel.Controls.Add(this.RadioD);
            this.ContactTabIndexPanel.Controls.Add(this.RadioC);
            this.ContactTabIndexPanel.Controls.Add(this.RadioB);
            this.ContactTabIndexPanel.Controls.Add(this.RadioA);
            this.ContactTabIndexPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactTabIndexPanel.Location = new System.Drawing.Point(3, 3);
            this.ContactTabIndexPanel.Name = "ContactTabIndexPanel";
            this.ContactTabIndexPanel.Size = new System.Drawing.Size(946, 65);
            this.ContactTabIndexPanel.TabIndex = 0;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(806, 39);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 29;
            this.materialRaisedButton1.Text = "Search";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.Black;
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(749, 10);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(1, 30);
            this.materialDivider5.TabIndex = 28;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Search Contact";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(756, 10);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(185, 23);
            this.materialSingleLineTextField1.TabIndex = 27;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // MainFormAllContactRadio
            // 
            this.MainFormAllContactRadio.AutoSize = true;
            this.MainFormAllContactRadio.Location = new System.Drawing.Point(660, 18);
            this.MainFormAllContactRadio.Name = "MainFormAllContactRadio";
            this.MainFormAllContactRadio.Size = new System.Drawing.Size(87, 15);
            this.MainFormAllContactRadio.TabIndex = 26;
            this.MainFormAllContactRadio.Text = "All Contacts";
            this.MainFormAllContactRadio.UseSelectable = true;
            // 
            // RadioZ
            // 
            this.RadioZ.AutoSize = true;
            this.RadioZ.Location = new System.Drawing.Point(596, 29);
            this.RadioZ.Name = "RadioZ";
            this.RadioZ.Size = new System.Drawing.Size(30, 15);
            this.RadioZ.TabIndex = 25;
            this.RadioZ.Text = "Z";
            this.RadioZ.UseSelectable = true;
            this.RadioZ.CheckedChanged += new System.EventHandler(this.RadioZ_CheckedChanged);
            // 
            // RadioY
            // 
            this.RadioY.AutoSize = true;
            this.RadioY.Location = new System.Drawing.Point(555, 32);
            this.RadioY.Name = "RadioY";
            this.RadioY.Size = new System.Drawing.Size(30, 15);
            this.RadioY.TabIndex = 24;
            this.RadioY.Text = "Y";
            this.RadioY.UseSelectable = true;
            // 
            // RadioX
            // 
            this.RadioX.AutoSize = true;
            this.RadioX.Location = new System.Drawing.Point(505, 32);
            this.RadioX.Name = "RadioX";
            this.RadioX.Size = new System.Drawing.Size(30, 15);
            this.RadioX.TabIndex = 23;
            this.RadioX.Text = "X";
            this.RadioX.UseSelectable = true;
            // 
            // RadioW
            // 
            this.RadioW.AutoSize = true;
            this.RadioW.Location = new System.Drawing.Point(454, 32);
            this.RadioW.Name = "RadioW";
            this.RadioW.Size = new System.Drawing.Size(34, 15);
            this.RadioW.TabIndex = 22;
            this.RadioW.Text = "W";
            this.RadioW.UseSelectable = true;
            // 
            // RadioV
            // 
            this.RadioV.AutoSize = true;
            this.RadioV.Location = new System.Drawing.Point(406, 32);
            this.RadioV.Name = "RadioV";
            this.RadioV.Size = new System.Drawing.Size(30, 15);
            this.RadioV.TabIndex = 21;
            this.RadioV.Text = "V";
            this.RadioV.UseSelectable = true;
            // 
            // RadioU
            // 
            this.RadioU.AutoSize = true;
            this.RadioU.Location = new System.Drawing.Point(354, 32);
            this.RadioU.Name = "RadioU";
            this.RadioU.Size = new System.Drawing.Size(31, 15);
            this.RadioU.TabIndex = 20;
            this.RadioU.Text = "U";
            this.RadioU.UseSelectable = true;
            // 
            // RadioT
            // 
            this.RadioT.AutoSize = true;
            this.RadioT.Location = new System.Drawing.Point(304, 32);
            this.RadioT.Name = "RadioT";
            this.RadioT.Size = new System.Drawing.Size(30, 15);
            this.RadioT.TabIndex = 19;
            this.RadioT.Text = "T";
            this.RadioT.UseSelectable = true;
            // 
            // RadioS
            // 
            this.RadioS.AutoSize = true;
            this.RadioS.Location = new System.Drawing.Point(253, 32);
            this.RadioS.Name = "RadioS";
            this.RadioS.Size = new System.Drawing.Size(29, 15);
            this.RadioS.TabIndex = 18;
            this.RadioS.Text = "S";
            this.RadioS.UseSelectable = true;
            // 
            // RadioR
            // 
            this.RadioR.AutoSize = true;
            this.RadioR.Location = new System.Drawing.Point(203, 32);
            this.RadioR.Name = "RadioR";
            this.RadioR.Size = new System.Drawing.Size(30, 15);
            this.RadioR.TabIndex = 17;
            this.RadioR.Text = "R";
            this.RadioR.UseSelectable = true;
            // 
            // RadioQ
            // 
            this.RadioQ.AutoSize = true;
            this.RadioQ.Location = new System.Drawing.Point(156, 32);
            this.RadioQ.Name = "RadioQ";
            this.RadioQ.Size = new System.Drawing.Size(32, 15);
            this.RadioQ.TabIndex = 16;
            this.RadioQ.Text = "Q";
            this.RadioQ.UseSelectable = true;
            // 
            // RadioP
            // 
            this.RadioP.AutoSize = true;
            this.RadioP.Location = new System.Drawing.Point(104, 32);
            this.RadioP.Name = "RadioP";
            this.RadioP.Size = new System.Drawing.Size(30, 15);
            this.RadioP.TabIndex = 15;
            this.RadioP.Text = "P";
            this.RadioP.UseSelectable = true;
            // 
            // RadioO
            // 
            this.RadioO.AutoSize = true;
            this.RadioO.Location = new System.Drawing.Point(54, 32);
            this.RadioO.Name = "RadioO";
            this.RadioO.Size = new System.Drawing.Size(32, 15);
            this.RadioO.TabIndex = 14;
            this.RadioO.Text = "O";
            this.RadioO.UseSelectable = true;
            // 
            // RadioN
            // 
            this.RadioN.AutoSize = true;
            this.RadioN.Location = new System.Drawing.Point(5, 32);
            this.RadioN.Name = "RadioN";
            this.RadioN.Size = new System.Drawing.Size(32, 15);
            this.RadioN.TabIndex = 13;
            this.RadioN.Text = "N";
            this.RadioN.UseSelectable = true;
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Location = new System.Drawing.Point(596, 3);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(34, 15);
            this.RadioM.TabIndex = 12;
            this.RadioM.Text = "M";
            this.RadioM.UseSelectable = true;
            this.RadioM.CheckedChanged += new System.EventHandler(this.RadioM_CheckedChanged);
            // 
            // RadioL
            // 
            this.RadioL.AutoSize = true;
            this.RadioL.Location = new System.Drawing.Point(555, 3);
            this.RadioL.Name = "RadioL";
            this.RadioL.Size = new System.Drawing.Size(29, 15);
            this.RadioL.TabIndex = 11;
            this.RadioL.Text = "L";
            this.RadioL.UseSelectable = true;
            // 
            // RadioK
            // 
            this.RadioK.AutoSize = true;
            this.RadioK.Location = new System.Drawing.Point(505, 3);
            this.RadioK.Name = "RadioK";
            this.RadioK.Size = new System.Drawing.Size(30, 15);
            this.RadioK.TabIndex = 10;
            this.RadioK.Text = "K";
            this.RadioK.UseSelectable = true;
            // 
            // RadioJ
            // 
            this.RadioJ.AutoSize = true;
            this.RadioJ.Location = new System.Drawing.Point(454, 3);
            this.RadioJ.Name = "RadioJ";
            this.RadioJ.Size = new System.Drawing.Size(27, 15);
            this.RadioJ.TabIndex = 9;
            this.RadioJ.Text = "J";
            this.RadioJ.UseSelectable = true;
            // 
            // RadioI
            // 
            this.RadioI.AutoSize = true;
            this.RadioI.Location = new System.Drawing.Point(406, 3);
            this.RadioI.Name = "RadioI";
            this.RadioI.Size = new System.Drawing.Size(26, 15);
            this.RadioI.TabIndex = 8;
            this.RadioI.Text = "I";
            this.RadioI.UseSelectable = true;
            // 
            // RadioH
            // 
            this.RadioH.AutoSize = true;
            this.RadioH.Location = new System.Drawing.Point(354, 3);
            this.RadioH.Name = "RadioH";
            this.RadioH.Size = new System.Drawing.Size(32, 15);
            this.RadioH.TabIndex = 7;
            this.RadioH.Text = "H";
            this.RadioH.UseSelectable = true;
            this.RadioH.CheckedChanged += new System.EventHandler(this.metroRadioButton8_CheckedChanged);
            // 
            // RadioG
            // 
            this.RadioG.AutoSize = true;
            this.RadioG.Location = new System.Drawing.Point(304, 3);
            this.RadioG.Name = "RadioG";
            this.RadioG.Size = new System.Drawing.Size(31, 15);
            this.RadioG.TabIndex = 6;
            this.RadioG.Text = "G";
            this.RadioG.UseSelectable = true;
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Location = new System.Drawing.Point(253, 3);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(29, 15);
            this.RadioF.TabIndex = 5;
            this.RadioF.Text = "F";
            this.RadioF.UseSelectable = true;
            this.RadioF.CheckedChanged += new System.EventHandler(this.RadioF_CheckedChanged);
            // 
            // RadioE
            // 
            this.RadioE.AutoSize = true;
            this.RadioE.Location = new System.Drawing.Point(203, 3);
            this.RadioE.Name = "RadioE";
            this.RadioE.Size = new System.Drawing.Size(29, 15);
            this.RadioE.TabIndex = 4;
            this.RadioE.Text = "E";
            this.RadioE.UseSelectable = true;
            // 
            // RadioD
            // 
            this.RadioD.AutoSize = true;
            this.RadioD.Location = new System.Drawing.Point(156, 3);
            this.RadioD.Name = "RadioD";
            this.RadioD.Size = new System.Drawing.Size(31, 15);
            this.RadioD.TabIndex = 3;
            this.RadioD.Text = "D";
            this.RadioD.UseSelectable = true;
            // 
            // RadioC
            // 
            this.RadioC.AutoSize = true;
            this.RadioC.Location = new System.Drawing.Point(104, 3);
            this.RadioC.Name = "RadioC";
            this.RadioC.Size = new System.Drawing.Size(31, 15);
            this.RadioC.TabIndex = 2;
            this.RadioC.Text = "C";
            this.RadioC.UseSelectable = true;
            // 
            // RadioB
            // 
            this.RadioB.AutoSize = true;
            this.RadioB.Location = new System.Drawing.Point(54, 3);
            this.RadioB.Name = "RadioB";
            this.RadioB.Size = new System.Drawing.Size(30, 15);
            this.RadioB.TabIndex = 1;
            this.RadioB.Text = "B";
            this.RadioB.UseSelectable = true;
            this.RadioB.CheckedChanged += new System.EventHandler(this.RadioB_CheckedChanged);
            // 
            // RadioA
            // 
            this.RadioA.AutoSize = true;
            this.RadioA.Location = new System.Drawing.Point(5, 3);
            this.RadioA.Name = "RadioA";
            this.RadioA.Size = new System.Drawing.Size(31, 15);
            this.RadioA.TabIndex = 0;
            this.RadioA.Text = "A";
            this.RadioA.UseSelectable = true;
            this.RadioA.CheckedChanged += new System.EventHandler(this.RadioA_CheckedChanged);
            // 
            // AddContactFormPanel
            // 
            this.AddContactFormPanel.BackColor = System.Drawing.Color.White;
            this.AddContactFormPanel.Controls.Add(this.AddContactMain);
            this.AddContactFormPanel.Controls.Add(this.AddContactNumCheckPanel);
            this.AddContactFormPanel.Location = new System.Drawing.Point(4, 22);
            this.AddContactFormPanel.Name = "AddContactFormPanel";
            this.AddContactFormPanel.Size = new System.Drawing.Size(952, 627);
            this.AddContactFormPanel.TabIndex = 2;
            this.AddContactFormPanel.Text = "Add Contact";
            this.AddContactFormPanel.Click += new System.EventHandler(this.AddContactFormPanel_Click);
            // 
            // AddContactMain
            // 
            this.AddContactMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactMain.Location = new System.Drawing.Point(281, 0);
            this.AddContactMain.Name = "AddContactMain";
            this.AddContactMain.Size = new System.Drawing.Size(671, 627);
            this.AddContactMain.TabIndex = 1;
            // 
            // AddContactNumCheckPanel
            // 
            this.AddContactNumCheckPanel.Controls.Add(this.materialFlatButton1);
            this.AddContactNumCheckPanel.Controls.Add(this.metroTextBox2);
            this.AddContactNumCheckPanel.Controls.Add(this.metroTextBox1);
            this.AddContactNumCheckPanel.Controls.Add(this.label2);
            this.AddContactNumCheckPanel.Controls.Add(this.label1);
            this.AddContactNumCheckPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddContactNumCheckPanel.Location = new System.Drawing.Point(0, 0);
            this.AddContactNumCheckPanel.Name = "AddContactNumCheckPanel";
            this.AddContactNumCheckPanel.Size = new System.Drawing.Size(281, 627);
            this.AddContactNumCheckPanel.TabIndex = 0;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(72, 238);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(138, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Check Validation";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(105, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(72, 147);
            this.metroTextBox2.MaxLength = 7;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(123, 20);
            this.metroTextBox2.TabIndex = 5;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(65, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(95, 69);
            this.metroTextBox1.MaxLength = 4;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "030";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(83, 20);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "030";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "xxxxxxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ex : 03xx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(388, 63);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 743);
            this.ControlBox = false;
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.ViewSearchTab.ResumeLayout(false);
            this.ContactTabDetailPanel.ResumeLayout(false);
            this.ContactTabNamePanel.ResumeLayout(false);
            this.ContactTabIndexPanel.ResumeLayout(false);
            this.ContactTabIndexPanel.PerformLayout();
            this.AddContactFormPanel.ResumeLayout(false);
            this.AddContactNumCheckPanel.ResumeLayout(false);
            this.AddContactNumCheckPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage ViewSearchTab;
        private System.Windows.Forms.Panel ContactTabIndexPanel;
        private System.Windows.Forms.Panel ContactTabDetailPanel;
        private System.Windows.Forms.Panel ContactTabNamePanel;
        private MetroFramework.Controls.MetroRadioButton RadioA;
        private MetroFramework.Controls.MetroRadioButton RadioY;
        private MetroFramework.Controls.MetroRadioButton RadioX;
        private MetroFramework.Controls.MetroRadioButton RadioW;
        private MetroFramework.Controls.MetroRadioButton RadioV;
        private MetroFramework.Controls.MetroRadioButton RadioU;
        private MetroFramework.Controls.MetroRadioButton RadioT;
        private MetroFramework.Controls.MetroRadioButton RadioS;
        private MetroFramework.Controls.MetroRadioButton RadioR;
        private MetroFramework.Controls.MetroRadioButton RadioQ;
        private MetroFramework.Controls.MetroRadioButton RadioP;
        private MetroFramework.Controls.MetroRadioButton RadioO;
        private MetroFramework.Controls.MetroRadioButton RadioN;
        private MetroFramework.Controls.MetroRadioButton RadioM;
        private MetroFramework.Controls.MetroRadioButton RadioL;
        private MetroFramework.Controls.MetroRadioButton RadioK;
        private MetroFramework.Controls.MetroRadioButton RadioJ;
        private MetroFramework.Controls.MetroRadioButton RadioI;
        private MetroFramework.Controls.MetroRadioButton RadioH;
        private MetroFramework.Controls.MetroRadioButton RadioG;
        private MetroFramework.Controls.MetroRadioButton RadioF;
        private MetroFramework.Controls.MetroRadioButton RadioE;
        private MetroFramework.Controls.MetroRadioButton RadioD;
        private MetroFramework.Controls.MetroRadioButton RadioC;
        private MetroFramework.Controls.MetroRadioButton RadioB;
        private MetroFramework.Controls.MetroRadioButton RadioZ;
        private System.Windows.Forms.TabPage AddContactFormPanel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MetroFramework.Controls.MetroRadioButton MainFormAllContactRadio;
        private System.Windows.Forms.Panel AddContactMain;
        private System.Windows.Forms.Panel AddContactNumCheckPanel;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}