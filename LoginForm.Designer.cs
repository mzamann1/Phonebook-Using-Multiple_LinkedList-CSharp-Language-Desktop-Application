namespace Phonebook
{
    partial class LoginForm
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
            this.LoginFormUID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginFormPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // LoginFormUID
            // 
            this.LoginFormUID.Depth = 0;
            this.LoginFormUID.Hint = "UserID";
            this.LoginFormUID.Location = new System.Drawing.Point(73, 141);
            this.LoginFormUID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginFormUID.Name = "LoginFormUID";
            this.LoginFormUID.PasswordChar = '\0';
            this.LoginFormUID.SelectedText = "";
            this.LoginFormUID.SelectionLength = 0;
            this.LoginFormUID.SelectionStart = 0;
            this.LoginFormUID.Size = new System.Drawing.Size(118, 23);
            this.LoginFormUID.TabIndex = 0;
            this.LoginFormUID.UseSystemPasswordChar = false;
            // 
            // LoginFormPass
            // 
            this.LoginFormPass.Depth = 0;
            this.LoginFormPass.Hint = "Password";
            this.LoginFormPass.Location = new System.Drawing.Point(73, 205);
            this.LoginFormPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginFormPass.Name = "LoginFormPass";
            this.LoginFormPass.PasswordChar = '\0';
            this.LoginFormPass.SelectedText = "";
            this.LoginFormPass.SelectionLength = 0;
            this.LoginFormPass.SelectionStart = 0;
            this.LoginFormPass.Size = new System.Drawing.Size(118, 23);
            this.LoginFormPass.TabIndex = 1;
            this.LoginFormPass.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(97, 282);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(52, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Login";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 397);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.LoginFormPass);
            this.Controls.Add(this.LoginFormUID);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField LoginFormUID;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginFormPass;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

