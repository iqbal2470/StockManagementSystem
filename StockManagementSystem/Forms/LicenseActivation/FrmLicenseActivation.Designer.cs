namespace StockManagementSystem.Forms.LicenseActivation
{
    partial class FrmLicenseActivation
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
            txtMachineId = new TextBox();
            btnCopyMachineId = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtLicenseFile = new TextBox();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            btnActivate = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            picLogo = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(42, 211);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Machine ID";
            // 
            // txtMachineId
            // 
            txtMachineId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMachineId.Location = new Point(161, 211);
            txtMachineId.Name = "txtMachineId";
            txtMachineId.ReadOnly = true;
            txtMachineId.Size = new Size(329, 31);
            txtMachineId.TabIndex = 1;
            // 
            // btnCopyMachineId
            // 
            btnCopyMachineId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCopyMachineId.BackColor = Color.RoyalBlue;
            btnCopyMachineId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopyMachineId.ForeColor = Color.White;
            btnCopyMachineId.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCopyMachineId.IconColor = Color.Black;
            btnCopyMachineId.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCopyMachineId.Location = new Point(496, 207);
            btnCopyMachineId.Name = "btnCopyMachineId";
            btnCopyMachineId.Size = new Size(179, 38);
            btnCopyMachineId.TabIndex = 2;
            btnCopyMachineId.Text = "Copy Machine ID";
            btnCopyMachineId.UseVisualStyleBackColor = false;
            btnCopyMachineId.Click += btnCopyMachineId_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(42, 277);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 3;
            label2.Text = "License File";
            // 
            // txtLicenseFile
            // 
            txtLicenseFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLicenseFile.Location = new Point(160, 274);
            txtLicenseFile.Name = "txtLicenseFile";
            txtLicenseFile.ReadOnly = true;
            txtLicenseFile.Size = new Size(330, 31);
            txtLicenseFile.TabIndex = 4;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.RoyalBlue;
            btnBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBrowse.IconColor = Color.Black;
            btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowse.Location = new Point(496, 270);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(179, 38);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnActivate
            // 
            btnActivate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnActivate.BackColor = Color.RoyalBlue;
            btnActivate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnActivate.ForeColor = Color.White;
            btnActivate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnActivate.IconColor = Color.Black;
            btnActivate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivate.Location = new Point(223, 358);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(267, 38);
            btnActivate.TabIndex = 6;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 477);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(232, 163);
            label3.Name = "label3";
            label3.Size = new Size(236, 21);
            label3.TabIndex = 1;
            label3.Text = "Admin Master License Activation";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(picLogo);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtMachineId);
            panel4.Controls.Add(btnBrowse);
            panel4.Controls.Add(txtLicenseFile);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnCopyMachineId);
            panel4.Controls.Add(btnActivate);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(719, 477);
            panel4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(269, 133);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 14;
            label4.Text = "Welcome Back";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.storemangeimg_1_removebg_preview;
            picLogo.Location = new Point(175, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(375, 141);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 13;
            picLogo.TabStop = false;
            // 
            // FrmLicenseActivation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.caraccessorybg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 477);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmLicenseActivation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master License Activation  ";
            Load += FrmLicenseActivation_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMachineId;
        private FontAwesome.Sharp.IconButton btnCopyMachineId;
        private Label label2;
        private TextBox txtLicenseFile;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private FontAwesome.Sharp.IconButton btnActivate;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private PictureBox picLogo;
    }
}