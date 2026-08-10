namespace StockManagementSystem.Forms.Login
{
    partial class FrmCreateAdmin
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnCreate = new Button();
            txtConfirmPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlCreateAdmin = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            picShowConfirmPassword = new PictureBox();
            label7 = new Label();
            panel2 = new Panel();
            picShowPassword = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            picLogo = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCreateAdmin.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowConfirmPassword).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 11F);
            txtUserName.Location = new Point(3, 7);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(308, 30);
            txtUserName.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(3, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 30);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.RoyalBlue;
            btnCreate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(175, 494);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(350, 45);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(3, 7);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(308, 30);
            txtConfirmPassword.TabIndex = 20;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUserName);
            panel1.Location = new Point(175, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 45);
            panel1.TabIndex = 22;
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
            // pnlCreateAdmin
            // 
            pnlCreateAdmin.BackColor = Color.Transparent;
            pnlCreateAdmin.Controls.Add(label8);
            pnlCreateAdmin.Controls.Add(panel3);
            pnlCreateAdmin.Controls.Add(label7);
            pnlCreateAdmin.Controls.Add(panel2);
            pnlCreateAdmin.Controls.Add(label1);
            pnlCreateAdmin.Controls.Add(label5);
            pnlCreateAdmin.Controls.Add(picLogo);
            pnlCreateAdmin.Controls.Add(label6);
            pnlCreateAdmin.Controls.Add(panel1);
            pnlCreateAdmin.Controls.Add(btnCreate);
            pnlCreateAdmin.Dock = DockStyle.Fill;
            pnlCreateAdmin.Location = new Point(0, 0);
            pnlCreateAdmin.Name = "pnlCreateAdmin";
            pnlCreateAdmin.Size = new Size(726, 572);
            pnlCreateAdmin.TabIndex = 23;
            pnlCreateAdmin.Paint += pnlCreateAdmin_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(169, 401);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 30;
            label8.Text = "Confirm Password";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(picShowConfirmPassword);
            panel3.Controls.Add(txtConfirmPassword);
            panel3.Location = new Point(175, 429);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 45);
            panel3.TabIndex = 29;
            // 
            // picShowConfirmPassword
            // 
            picShowConfirmPassword.BackgroundImageLayout = ImageLayout.Stretch;
            picShowConfirmPassword.Cursor = Cursors.Hand;
            picShowConfirmPassword.Image = Properties.Resources.eye_close;
            picShowConfirmPassword.Location = new Point(319, 10);
            picShowConfirmPassword.Name = "picShowConfirmPassword";
            picShowConfirmPassword.Size = new Size(26, 26);
            picShowConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            picShowConfirmPassword.TabIndex = 31;
            picShowConfirmPassword.TabStop = false;
            picShowConfirmPassword.Click += picShowConfirmPassword_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(169, 318);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 28;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(picShowPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Location = new Point(175, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 45);
            panel2.TabIndex = 27;
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
            picShowPassword.TabIndex = 16;
            picShowPassword.TabStop = false;
            picShowPassword.Click += picShowPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(169, 229);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 26;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(270, 163);
            label5.Name = "label5";
            label5.Size = new Size(163, 30);
            label5.TabIndex = 24;
            label5.Text = "Welcome Back";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.bg_stockmh1;
            picLogo.Location = new Point(163, 29);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(375, 141);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 23;
            picLogo.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(279, 198);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 25;
            label6.Text = "Sign in to Continue";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmCreateAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.caraccessorybg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 572);
            Controls.Add(pnlCreateAdmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCreateAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master Create Admin Account ";
            Load += FrmCreateAdmin_Load;
            Resize += FrmCreateAdmin_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCreateAdmin.ResumeLayout(false);
            pnlCreateAdmin.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowConfirmPassword).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnCreate;
        private TextBox txtConfirmPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel pnlCreateAdmin;
        private Label label5;
        private PictureBox picLogo;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label1;
        private Label label8;
        private Panel panel3;
        private PictureBox picShowConfirmPassword;
        private PictureBox picShowPassword;
    }
}