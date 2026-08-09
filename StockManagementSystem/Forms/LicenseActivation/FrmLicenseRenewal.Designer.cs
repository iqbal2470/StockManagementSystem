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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlRenewLicense1 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            txtLicenseFile = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            btnRenew = new FontAwesome.Sharp.IconButton();
            picProducts = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlRenewLicense1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
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
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 450);
            panel4.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlRenewLicense1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // pnlRenewLicense1
            // 
            pnlRenewLicense1.BackColor = Color.White;
            pnlRenewLicense1.Controls.Add(label1);
            pnlRenewLicense1.Controls.Add(panel6);
            pnlRenewLicense1.Controls.Add(picProducts);
            pnlRenewLicense1.Controls.Add(label2);
            pnlRenewLicense1.Controls.Add(btnRenew);
            pnlRenewLicense1.Controls.Add(label3);
            pnlRenewLicense1.Controls.Add(btnBrowse);
            pnlRenewLicense1.Dock = DockStyle.Fill;
            pnlRenewLicense1.Location = new Point(25, 25);
            pnlRenewLicense1.Margin = new Padding(10);
            pnlRenewLicense1.Name = "pnlRenewLicense1";
            pnlRenewLicense1.Padding = new Padding(20);
            pnlRenewLicense1.Size = new Size(750, 400);
            pnlRenewLicense1.TabIndex = 0;
            pnlRenewLicense1.Resize += pnlRenewLicense1_Resize;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(245, 70);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 27;
            label1.Text = "Renew License";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txtLicenseFile);
            panel6.Location = new Point(226, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(257, 32);
            panel6.TabIndex = 29;
            // 
            // txtLicenseFile
            // 
            txtLicenseFile.BackColor = Color.White;
            txtLicenseFile.BorderStyle = BorderStyle.None;
            txtLicenseFile.Location = new Point(7, 2);
            txtLicenseFile.Name = "txtLicenseFile";
            txtLicenseFile.PlaceholderText = "  No file selected";
            txtLicenseFile.ReadOnly = true;
            txtLicenseFile.Size = new Size(239, 24);
            txtLicenseFile.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(112, 178);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 10;
            label2.Text = "License File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(245, 107);
            label3.Name = "label3";
            label3.Size = new Size(395, 21);
            label3.TabIndex = 28;
            label3.Text = "Upload your license file to renew your  software license.";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(39, 102, 243);
            btnBrowse.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.IconChar = FontAwesome.Sharp.IconChar.File;
            btnBrowse.IconColor = Color.White;
            btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowse.IconSize = 23;
            btnBrowse.Location = new Point(489, 171);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Padding = new Padding(5);
            btnBrowse.Size = new Size(179, 40);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Browse...";
            btnBrowse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = Color.FromArgb(39, 102, 243);
            btnRenew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRenew.ForeColor = Color.White;
            btnRenew.IconChar = FontAwesome.Sharp.IconChar.RotateRight;
            btnRenew.IconColor = Color.White;
            btnRenew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRenew.IconSize = 25;
            btnRenew.Location = new Point(272, 249);
            btnRenew.Margin = new Padding(5);
            btnRenew.Name = "btnRenew";
            btnRenew.Padding = new Padding(5);
            btnRenew.Size = new Size(221, 43);
            btnRenew.TabIndex = 13;
            btnRenew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // picProducts
            // 
            picProducts.BackColor = Color.FromArgb(39, 102, 243);
            picProducts.BackgroundImageLayout = ImageLayout.Stretch;
            picProducts.Image = Properties.Resources.key;
            picProducts.Location = new Point(112, 49);
            picProducts.Name = "picProducts";
            picProducts.Padding = new Padding(35);
            picProducts.Size = new Size(95, 95);
            picProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducts.TabIndex = 26;
            picProducts.TabStop = false;
            picProducts.Click += picProducts_Click;
            // 
            // FrmLicenseRenewal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 252);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmLicenseRenewal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin License Renewal ";
            Load += FrmLicenseRenewal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlRenewLicense1.ResumeLayout(false);
            pnlRenewLicense1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRenew;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private TextBox txtLicenseFile;
        private Label label2;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlRenewLicense1;
        private PictureBox picProducts;
        private Label label3;
        private Label label1;
        private Panel panel6;
        private Panel pnlRenewLicense;
    }
}