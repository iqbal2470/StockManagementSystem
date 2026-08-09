namespace LicenseGeneratorTool
{
    partial class FrmLicenseKeyGenerater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicenseKeyGenerater));
            label1 = new Label();
            txtMachineId = new TextBox();
            label2 = new Label();
            cmbLicenseType = new ComboBox();
            cmbDuration = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnGenerateKeys = new Button();
            btnGenerateLicense = new Button();
            btnSave = new Button();
            txtLicense = new RichTextBox();
            txtLicenseNumber = new TextBox();
            label5 = new Label();
            txtCompanyName = new TextBox();
            label6 = new Label();
            txtCustomerName = new TextBox();
            custormerName = new Label();
            panel4 = new Panel();
            label7 = new Label();
            picLogo = new PictureBox();
            label8 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(69, 305);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Machine ID";
            // 
            // txtMachineId
            // 
            txtMachineId.Location = new Point(273, 305);
            txtMachineId.Name = "txtMachineId";
            txtMachineId.Size = new Size(390, 31);
            txtMachineId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(69, 349);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "License Type";
            // 
            // cmbLicenseType
            // 
            cmbLicenseType.FormattingEnabled = true;
            cmbLicenseType.Location = new Point(273, 349);
            cmbLicenseType.Name = "cmbLicenseType";
            cmbLicenseType.Size = new Size(390, 33);
            cmbLicenseType.TabIndex = 3;
            cmbLicenseType.SelectedIndexChanged += cmbLicenseType_SelectedIndexChanged;
            // 
            // cmbDuration
            // 
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Location = new Point(273, 393);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(390, 33);
            cmbDuration.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(69, 393);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(69, 439);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 6;
            label4.Text = "Generated License";
            // 
            // btnGenerateKeys
            // 
            btnGenerateKeys.BackColor = Color.FromArgb(39, 102, 243);
            btnGenerateKeys.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerateKeys.ForeColor = Color.White;
            btnGenerateKeys.Location = new Point(69, 543);
            btnGenerateKeys.Name = "btnGenerateKeys";
            btnGenerateKeys.Size = new Size(187, 34);
            btnGenerateKeys.TabIndex = 8;
            btnGenerateKeys.Text = "GenerateKeys";
            btnGenerateKeys.UseVisualStyleBackColor = false;
            btnGenerateKeys.Click += btnGenerateKeys_Click;
            // 
            // btnGenerateLicense
            // 
            btnGenerateLicense.FlatAppearance.BorderColor = Color.FromArgb(39, 102, 243);
            btnGenerateLicense.FlatAppearance.BorderSize = 2;
            btnGenerateLicense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerateLicense.ForeColor = Color.FromArgb(39, 102, 243);
            btnGenerateLicense.Location = new Point(273, 543);
            btnGenerateLicense.Name = "btnGenerateLicense";
            btnGenerateLicense.Size = new Size(214, 34);
            btnGenerateLicense.TabIndex = 9;
            btnGenerateLicense.Text = "GenerateLicense";
            btnGenerateLicense.UseVisualStyleBackColor = true;
            btnGenerateLicense.Click += btnGenerateLicense_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(506, 543);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(273, 439);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(390, 87);
            txtLicense.TabIndex = 12;
            txtLicense.Text = "";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(273, 263);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(390, 31);
            txtLicenseNumber.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(69, 263);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 13;
            label5.Text = "License Number";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(273, 223);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(390, 31);
            txtCompanyName.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(69, 223);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 15;
            label6.Text = "Company Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(273, 182);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(390, 31);
            txtCustomerName.TabIndex = 18;
            // 
            // custormerName
            // 
            custormerName.AutoSize = true;
            custormerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            custormerName.ForeColor = Color.CornflowerBlue;
            custormerName.Location = new Point(69, 182);
            custormerName.Name = "custormerName";
            custormerName.Size = new Size(161, 25);
            custormerName.TabIndex = 17;
            custormerName.Text = "Customer Name *";
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtCustomerName);
            panel4.Controls.Add(picLogo);
            panel4.Controls.Add(custormerName);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtCompanyName);
            panel4.Controls.Add(txtLicense);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtLicenseNumber);
            panel4.Controls.Add(txtMachineId);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cmbLicenseType);
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cmbDuration);
            panel4.Controls.Add(btnGenerateLicense);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnGenerateKeys);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 630);
            panel4.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(273, 120);
            label7.Name = "label7";
            label7.Size = new Size(163, 30);
            label7.TabIndex = 14;
            label7.Text = "Welcome Back";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(179, -10);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(375, 141);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 13;
            picLogo.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(213, 150);
            label8.Name = "label8";
            label8.Size = new Size(265, 21);
            label8.TabIndex = 1;
            label8.Text = "Admin Master License Key Generater";
            // 
            // FrmLicenseKeyGenerater
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 252);
            ClientSize = new Size(740, 630);
            Controls.Add(panel4);
            Name = "FrmLicenseKeyGenerater";
            Text = "Licence Key Generater";
            Load += FrmLicenseKeyGenerater_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMachineId;
        private Label label2;
        private ComboBox cmbLicenseType;
        private ComboBox cmbDuration;
        private Label label3;
        private Label label4;
        private Button btnGenerateKeys;
        private Button btnGenerateLicense;
        private Button btnSave;
        private RichTextBox txtLicense;
        private TextBox txtLicenseNumber;
        private Label label5;
        private TextBox txtCompanyName;
        private Label label6;
        private TextBox txtCustomerName;
        private Label custormerName;
        private Panel panel4;
        private Label label7;
        private PictureBox picLogo;
        private Label label8;
    }
}
