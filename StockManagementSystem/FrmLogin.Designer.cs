namespace StockManagementSystem
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Group_4;
            picLogo.Location = new Point(207, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(203, 115);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 149);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 1;
            label1.Text = "Stock Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 196);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(258, 193);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(239, 31);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(258, 245);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 248);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(475, 252);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(22, 21);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(114, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(385, 335);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(545, 416);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(32, 25);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "V. ";
            lblVersion.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(lblVersion);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picLogo);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblVersion;
    }
}
