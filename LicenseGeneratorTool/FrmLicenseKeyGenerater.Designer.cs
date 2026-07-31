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
            label1 = new Label();
            txtMachineId = new TextBox();
            label2 = new Label();
            cmbLicenseType = new ComboBox();
            cmbDuration = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnGenerateKeys = new Button();
            btnGenerateLicense = new Button();
            btnCopy = new Button();
            btnSave = new Button();
            txtLicense = new RichTextBox();
            txtLicenseNumber = new TextBox();
            label5 = new Label();
            txtCompanyName = new TextBox();
            label6 = new Label();
            txtCustomerName = new TextBox();
            custormerName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 163);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Machine ID";
            // 
            // txtMachineId
            // 
            txtMachineId.Location = new Point(334, 163);
            txtMachineId.Name = "txtMachineId";
            txtMachineId.Size = new Size(299, 31);
            txtMachineId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 210);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 2;
            label2.Text = "License Type";
            // 
            // cmbLicenseType
            // 
            cmbLicenseType.FormattingEnabled = true;
            cmbLicenseType.Location = new Point(334, 207);
            cmbLicenseType.Name = "cmbLicenseType";
            cmbLicenseType.Size = new Size(299, 33);
            cmbLicenseType.TabIndex = 3;
            cmbLicenseType.SelectedIndexChanged += cmbLicenseType_SelectedIndexChanged;
            // 
            // cmbDuration
            // 
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Location = new Point(334, 251);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(299, 33);
            cmbDuration.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 254);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 318);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 6;
            label4.Text = "Generated License";
            // 
            // btnGenerateKeys
            // 
            btnGenerateKeys.Location = new Point(84, 389);
            btnGenerateKeys.Name = "btnGenerateKeys";
            btnGenerateKeys.Size = new Size(138, 34);
            btnGenerateKeys.TabIndex = 8;
            btnGenerateKeys.Text = "GenerateKeys";
            btnGenerateKeys.UseVisualStyleBackColor = true;
            btnGenerateKeys.Click += btnGenerateKeys_Click;
            // 
            // btnGenerateLicense
            // 
            btnGenerateLicense.Location = new Point(228, 389);
            btnGenerateLicense.Name = "btnGenerateLicense";
            btnGenerateLicense.Size = new Size(162, 34);
            btnGenerateLicense.TabIndex = 9;
            btnGenerateLicense.Text = "GenerateLicense";
            btnGenerateLicense.UseVisualStyleBackColor = true;
            btnGenerateLicense.Click += btnGenerateLicense_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(396, 389);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(138, 34);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(540, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(334, 290);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(299, 87);
            txtLicense.TabIndex = 12;
            txtLicense.Text = "";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(334, 121);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(299, 31);
            txtLicenseNumber.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 121);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 13;
            label5.Text = "License Number";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(334, 81);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(299, 31);
            txtCompanyName.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 81);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 15;
            label6.Text = "Company Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(334, 40);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(299, 31);
            txtCustomerName.TabIndex = 18;
            // 
            // custormerName
            // 
            custormerName.AutoSize = true;
            custormerName.Location = new Point(146, 40);
            custormerName.Name = "custormerName";
            custormerName.Size = new Size(154, 25);
            custormerName.TabIndex = 17;
            custormerName.Text = "Customer Name *";
            // 
            // FrmLicenseKeyGenerater
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCustomerName);
            Controls.Add(custormerName);
            Controls.Add(txtCompanyName);
            Controls.Add(label6);
            Controls.Add(txtLicenseNumber);
            Controls.Add(label5);
            Controls.Add(txtLicense);
            Controls.Add(btnSave);
            Controls.Add(btnCopy);
            Controls.Add(btnGenerateLicense);
            Controls.Add(btnGenerateKeys);
            Controls.Add(label4);
            Controls.Add(cmbDuration);
            Controls.Add(label3);
            Controls.Add(cmbLicenseType);
            Controls.Add(label2);
            Controls.Add(txtMachineId);
            Controls.Add(label1);
            Name = "FrmLicenseKeyGenerater";
            Text = "Licence Key Generater";
            Load += FrmLicenseKeyGenerater_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnCopy;
        private Button btnSave;
        private RichTextBox txtLicense;
        private TextBox txtLicenseNumber;
        private Label label5;
        private TextBox txtCompanyName;
        private Label label6;
        private TextBox txtCustomerName;
        private Label custormerName;
    }
}
