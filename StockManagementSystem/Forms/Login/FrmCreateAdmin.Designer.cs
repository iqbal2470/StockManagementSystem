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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnCreate = new Button();
            checkBox1 = new CheckBox();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 59);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 11;
            label1.Text = "Stock Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 106);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 12;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(346, 103);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(239, 31);
            txtUserName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 158);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 14;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(346, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 31);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(563, 162);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(22, 21);
            chkShowPassword.TabIndex = 16;
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(167, 291);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(418, 34);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(563, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 21;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(346, 208);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(211, 31);
            txtConfirmPassword.TabIndex = 20;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 211);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 19;
            label4.Text = "Confirm Password";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmCreateAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(btnCreate);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCreateAdmin";
            Text = "FrmCreateAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnCreate;
        private CheckBox checkBox1;
        private TextBox txtConfirmPassword;
        private Label label4;
    }
}