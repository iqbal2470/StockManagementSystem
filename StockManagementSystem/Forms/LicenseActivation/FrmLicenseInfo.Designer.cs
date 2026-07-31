namespace StockManagementSystem.Forms.LicenseActivation
{
    partial class FrmLicenseInfo
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
            pnlMain = new Panel();
            panel3 = new Panel();
            btnClose = new Button();
            panel2 = new Panel();
            lblLicenseNumber = new Label();
            label11 = new Label();
            lblCompanyName = new Label();
            label9 = new Label();
            lblStatus = new Label();
            lblLicenseType = new Label();
            lblIssueDate = new Label();
            lblExpiryDate = new Label();
            lblMachineId = new Label();
            lblCustomerName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pnlMain.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel3);
            pnlMain.Controls.Add(panel2);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 536);
            pnlMain.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 465);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 71);
            panel3.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(331, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblLicenseNumber);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblCompanyName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblLicenseType);
            panel2.Controls.Add(lblIssueDate);
            panel2.Controls.Add(lblExpiryDate);
            panel2.Controls.Add(lblMachineId);
            panel2.Controls.Add(lblCustomerName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 461);
            panel2.TabIndex = 1;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLicenseNumber.Location = new Point(458, 45);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(158, 25);
            lblLicenseNumber.TabIndex = 16;
            lblLicenseNumber.Text = "Customer Name :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(194, 45);
            label11.Name = "label11";
            label11.Size = new Size(147, 25);
            label11.TabIndex = 15;
            label11.Text = "License Number :";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCompanyName.Location = new Point(458, 77);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(158, 25);
            lblCompanyName.TabIndex = 14;
            lblCompanyName.Text = "Customer Name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(194, 77);
            label9.Name = "label9";
            label9.Size = new Size(150, 25);
            label9.TabIndex = 13;
            label9.Text = "Company Name :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(458, 346);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 25);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status :";
            // 
            // lblLicenseType
            // 
            lblLicenseType.AutoSize = true;
            lblLicenseType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLicenseType.Location = new Point(458, 156);
            lblLicenseType.Name = "lblLicenseType";
            lblLicenseType.Size = new Size(130, 25);
            lblLicenseType.TabIndex = 11;
            lblLicenseType.Text = "License Type :";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIssueDate.Location = new Point(458, 202);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(110, 25);
            lblIssueDate.TabIndex = 10;
            lblIssueDate.Text = "Issue Date :";
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExpiryDate.Location = new Point(458, 258);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(121, 25);
            lblExpiryDate.TabIndex = 9;
            lblExpiryDate.Text = "Expiry Date :";
            // 
            // lblMachineId
            // 
            lblMachineId.AutoSize = true;
            lblMachineId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMachineId.Location = new Point(458, 312);
            lblMachineId.Name = "lblMachineId";
            lblMachineId.Size = new Size(119, 25);
            lblMachineId.TabIndex = 8;
            lblMachineId.Text = "Machine ID :";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerName.Location = new Point(458, 115);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(158, 25);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "Customer Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 346);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 6;
            label8.Text = "Status :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 156);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 5;
            label7.Text = "License Type :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 202);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 4;
            label6.Text = "Issue Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 258);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 3;
            label5.Text = "Expiry Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 312);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 2;
            label4.Text = "Machine ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 115);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 1;
            label3.Text = "Customer Name :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(265, 22);
            label1.Name = "label1";
            label1.Size = new Size(249, 32);
            label1.TabIndex = 0;
            label1.Text = " License Information";
            // 
            // FrmLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(pnlMain);
            Name = "FrmLicenseInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin License Informations";
            Load += FrmLicenseInfo_Load;
            pnlMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btnClose;
        private Label lblStatus;
        private Label lblLicenseType;
        private Label lblIssueDate;
        private Label lblExpiryDate;
        private Label lblMachineId;
        private Label lblCustomerName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblLicenseNumber;
        private Label label11;
        private Label lblCompanyName;
        private Label label9;
    }
}