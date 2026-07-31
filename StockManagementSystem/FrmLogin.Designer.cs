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
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            lblVersion = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            picShowPassword = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            pnlLogin = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.storemangeimg_1_removebg_preview;
            picLogo.Location = new Point(169, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(375, 141);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(174, 194);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 11F);
            txtUserName.Location = new Point(3, 7);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(308, 30);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(3, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 30);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(173, 289);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(182, 397);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.RoyalBlue;
            btnExit.Location = new Point(182, 454);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(350, 45);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 7F);
            lblVersion.ForeColor = Color.DimGray;
            lblVersion.Location = new Point(308, 510);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(54, 19);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Version";
            lblVersion.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUserName);
            panel1.Location = new Point(180, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 45);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_icon_member_login_isolated_vector_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(315, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(picShowPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(180, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 45);
            panel2.TabIndex = 11;
            // 
            // picShowPassword
            // 
            picShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            picShowPassword.Cursor = Cursors.Hand;
            picShowPassword.Image = Properties.Resources.eye_close;
            picShowPassword.Location = new Point(319, 9);
            picShowPassword.Name = "picShowPassword";
            picShowPassword.Size = new Size(26, 26);
            picShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            picShowPassword.TabIndex = 0;
            picShowPassword.TabStop = false;
            picShowPassword.Click += picShowPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(263, 142);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 12;
            label1.Text = "Welcome Back";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(272, 177);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 13;
            label4.Text = "Sign in to Continue";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.Transparent;
            pnlLogin.Controls.Add(label5);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(panel2);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(panel1);
            pnlLogin.Controls.Add(btnExit);
            pnlLogin.Controls.Add(lblVersion);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(723, 564);
            pnlLogin.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(356, 510);
            label5.Name = "label5";
            label5.Size = new Size(39, 19);
            label5.TabIndex = 14;
            label5.Text = "1.0.0";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.caraccessorybg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 564);
            Controls.Add(pnlLogin);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Master Login";
            Load += FrmLogin_Load;
            Shown += FrmLogin_Shown;
            Resize += FrmLogin_Resize;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLogo;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Button btnExit;
        private Label lblVersion;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox picShowPassword;
        private Label label1;
        private Label label4;
        private Panel pnlLogin;
        private Label label5;
    }
}
