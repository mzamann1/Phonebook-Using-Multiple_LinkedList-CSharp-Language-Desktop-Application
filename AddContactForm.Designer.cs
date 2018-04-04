namespace Phonebook
{
    partial class AddContactForm
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
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.AddContactAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AddContactEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddContactNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.AddContactFN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddContactLN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(40, 234);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 19);
            this.materialLabel5.TabIndex = 39;
            this.materialLabel5.Text = "Address :";
            // 
            // AddContactAddress
            // 
            this.AddContactAddress.Depth = 0;
            this.AddContactAddress.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContactAddress.Hint = "";
            this.AddContactAddress.Location = new System.Drawing.Point(159, 234);
            this.AddContactAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddContactAddress.Name = "AddContactAddress";
            this.AddContactAddress.PasswordChar = '\0';
            this.AddContactAddress.SelectedText = "";
            this.AddContactAddress.SelectionLength = 0;
            this.AddContactAddress.SelectionStart = 0;
            this.AddContactAddress.Size = new System.Drawing.Size(581, 23);
            this.AddContactAddress.TabIndex = 38;
            this.AddContactAddress.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(300, 337);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(122, 42);
            this.materialRaisedButton1.TabIndex = 35;
            this.materialRaisedButton1.Text = "Save";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(40, 163);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 34;
            this.materialLabel3.Text = "Email :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(440, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Contact # :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "First Name :";
            // 
            // AddContactEmail
            // 
            this.AddContactEmail.Depth = 0;
            this.AddContactEmail.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContactEmail.Hint = "";
            this.AddContactEmail.Location = new System.Drawing.Point(159, 159);
            this.AddContactEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddContactEmail.Name = "AddContactEmail";
            this.AddContactEmail.PasswordChar = '\0';
            this.AddContactEmail.SelectedText = "";
            this.AddContactEmail.SelectionLength = 0;
            this.AddContactEmail.SelectionStart = 0;
            this.AddContactEmail.Size = new System.Drawing.Size(246, 23);
            this.AddContactEmail.TabIndex = 30;
            this.AddContactEmail.UseSystemPasswordChar = false;
            // 
            // AddContactNum
            // 
            this.AddContactNum.Depth = 0;
            this.AddContactNum.Enabled = false;
            this.AddContactNum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContactNum.Hint = "";
            this.AddContactNum.Location = new System.Drawing.Point(560, 162);
            this.AddContactNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddContactNum.Name = "AddContactNum";
            this.AddContactNum.PasswordChar = '\0';
            this.AddContactNum.SelectedText = "";
            this.AddContactNum.SelectionLength = 0;
            this.AddContactNum.SelectionStart = 0;
            this.AddContactNum.Size = new System.Drawing.Size(180, 23);
            this.AddContactNum.TabIndex = 3;
            this.AddContactNum.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(440, 67);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(94, 19);
            this.materialLabel4.TabIndex = 40;
            this.materialLabel4.Text = "Last  Name :";
            // 
            // AddContactFN
            // 
            this.AddContactFN.Depth = 0;
            this.AddContactFN.Hint = "";
            this.AddContactFN.Location = new System.Drawing.Point(159, 58);
            this.AddContactFN.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddContactFN.Name = "AddContactFN";
            this.AddContactFN.PasswordChar = '\0';
            this.AddContactFN.SelectedText = "";
            this.AddContactFN.SelectionLength = 0;
            this.AddContactFN.SelectionStart = 0;
            this.AddContactFN.Size = new System.Drawing.Size(163, 23);
            this.AddContactFN.TabIndex = 41;
            this.AddContactFN.UseSystemPasswordChar = false;
            // 
            // AddContactLN
            // 
            this.AddContactLN.Depth = 0;
            this.AddContactLN.Hint = "";
            this.AddContactLN.Location = new System.Drawing.Point(560, 58);
            this.AddContactLN.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddContactLN.Name = "AddContactLN";
            this.AddContactLN.PasswordChar = '\0';
            this.AddContactLN.SelectedText = "";
            this.AddContactLN.SelectionLength = 0;
            this.AddContactLN.SelectionStart = 0;
            this.AddContactLN.Size = new System.Drawing.Size(180, 23);
            this.AddContactLN.TabIndex = 42;
            this.AddContactLN.UseSystemPasswordChar = false;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 442);
            this.Controls.Add(this.AddContactLN);
            this.Controls.Add(this.AddContactFN);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.AddContactAddress);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.AddContactEmail);
            this.Controls.Add(this.AddContactNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddContactAddress;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddContactEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddContactNum;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddContactFN;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddContactLN;
    }
}