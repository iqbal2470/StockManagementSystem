namespace StockManagementSystem.Forms.Reports
{
    partial class RrmReports
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
            dgvReport = new DataGridView();
            cmbReportType = new ComboBox();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            label2 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            btnLoad = new FontAwesome.Sharp.IconButton();
            btnExportPdf = new FontAwesome.Sharp.IconButton();
            btnExportExcel = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Bottom;
            dgvReport.Location = new Point(0, 225);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 62;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(1005, 225);
            dgvReport.TabIndex = 0;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(141, 59);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(182, 33);
            cmbReportType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 2;
            label1.Text = "ReportType";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(544, 62);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(167, 31);
            dtpFrom.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 63);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "From";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(753, 62);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(167, 31);
            dtpTo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(717, 61);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 6;
            label3.Text = "To";
            // 
            // btnLoad
            // 
            btnLoad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLoad.IconColor = Color.Black;
            btnLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoad.Location = new Point(405, 168);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportPdf.IconColor = Color.Black;
            btnExportPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportPdf.Location = new Point(599, 168);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(112, 34);
            btnExportPdf.TabIndex = 8;
            btnExportPdf.Text = "Export Pdf";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportExcel.IconColor = Color.Black;
            btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportExcel.Location = new Point(808, 168);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(112, 34);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(481, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here....";
            txtSearch.Size = new Size(439, 31);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // RrmReports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportPdf);
            Controls.Add(btnLoad);
            Controls.Add(label3);
            Controls.Add(dtpTo);
            Controls.Add(label2);
            Controls.Add(dtpFrom);
            Controls.Add(label1);
            Controls.Add(cmbReportType);
            Controls.Add(dgvReport);
            Name = "RrmReports";
            Text = "Master Reports";
            Load += RrmReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReport;
        private ComboBox cmbReportType;
        private Label label1;
        private DateTimePicker dtpFrom;
        private Label label2;
        private DateTimePicker dtpTo;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnLoad;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private TextBox txtSearch;
    }
}