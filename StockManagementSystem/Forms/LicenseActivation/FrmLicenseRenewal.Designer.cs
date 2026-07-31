namespace StockManagementSystem.Forms.LicenseActivation
{
    partial class FrmLicenseRenewal
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            txtLicenseFile = new TextBox();
            label2 = new Label();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            btnRenew = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 368);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 82);
            panel5.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtLicenseFile);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnBrowse);
            panel4.Controls.Add(btnRenew);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 381);
            panel4.TabIndex = 15;
            // 
            // txtLicenseFile
            // 
            txtLicenseFile.Location = new Point(238, 65);
            txtLicenseFile.Name = "txtLicenseFile";
            txtLicenseFile.ReadOnly = true;
            txtLicenseFile.Size = new Size(239, 31);
            txtLicenseFile.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(120, 68);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 10;
            label2.Text = "License File";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBrowse.IconColor = Color.Black;
            btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowse.Location = new Point(497, 61);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(179, 38);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRenew
            // 
            btnRenew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRenew.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRenew.IconColor = Color.Black;
            btnRenew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRenew.Location = new Point(259, 178);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(249, 42);
            btnRenew.TabIndex = 13;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += btnRenew_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 69);
            panel3.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(293, 20);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 7;
            label1.Text = "Renew License";
            // 
            // FrmLicenseRenewal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmLicenseRenewal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin License Renewal ";
            Load += FrmLicenseRenewal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRenew;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private TextBox txtLicenseFile;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
    }
}