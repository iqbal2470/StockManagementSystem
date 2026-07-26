namespace StockManagementSystem.Forms.History
{
    partial class FrmHistory
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
            pnlGrid = new Panel();
            panel2 = new Panel();
            dgvHistory = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPrevious = new DataGridViewTextBoxColumn();
            colCurrent = new DataGridViewTextBoxColumn();
            colReference = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            pnlFooter = new Panel();
            lblRecordCount = new Label();
            pnlDate = new Panel();
            btnPdf = new FontAwesome.Sharp.IconButton();
            btnExport = new FontAwesome.Sharp.IconButton();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            lblFrom = new Label();
            pnlHeader = new Panel();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            cmbTransactionType = new ComboBox();
            lblType = new Label();
            pnlMain.SuspendLayout();
            pnlGrid.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel1.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlDate.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(pnlDate);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(10);
            pnlMain.Size = new Size(1037, 632);
            pnlMain.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.BorderStyle = BorderStyle.FixedSingle;
            pnlGrid.Controls.Add(panel2);
            pnlGrid.Controls.Add(panel1);
            pnlGrid.Controls.Add(pnlFooter);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(10, 125);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(1017, 497);
            pnlGrid.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHistory);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1015, 408);
            panel2.TabIndex = 3;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.DarkGray;
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colDate, colProduct, colType, colQty, colPrevious, colCurrent, colReference, colRemarks });
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(0, 0);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1015, 408);
            dgvHistory.TabIndex = 0;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 8;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colProduct
            // 
            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 8;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 8;
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "Quantity";
            colQty.MinimumWidth = 8;
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colPrevious
            // 
            colPrevious.HeaderText = "Previous Stock";
            colPrevious.MinimumWidth = 8;
            colPrevious.Name = "colPrevious";
            colPrevious.ReadOnly = true;
            // 
            // colCurrent
            // 
            colCurrent.HeaderText = "Current Stock";
            colCurrent.MinimumWidth = 8;
            colCurrent.Name = "colCurrent";
            colCurrent.ReadOnly = true;
            // 
            // colReference
            // 
            colReference.HeaderText = "Reference No";
            colReference.MinimumWidth = 8;
            colReference.Name = "colReference";
            colReference.ReadOnly = true;
            // 
            // colRemarks
            // 
            colRemarks.HeaderText = "Remarks";
            colRemarks.MinimumWidth = 8;
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 47);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 7;
            label1.Text = "Search Activity";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(lblRecordCount);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 455);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1015, 40);
            pnlFooter.TabIndex = 1;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecordCount.Location = new Point(5, 10);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(152, 25);
            lblRecordCount.TabIndex = 0;
            lblRecordCount.Text = "Total Records : 0";
            // 
            // pnlDate
            // 
            pnlDate.BackColor = Color.White;
            pnlDate.Controls.Add(btnPdf);
            pnlDate.Controls.Add(btnExport);
            pnlDate.Controls.Add(dtpTo);
            pnlDate.Controls.Add(dtpFrom);
            pnlDate.Controls.Add(lblTo);
            pnlDate.Controls.Add(lblFrom);
            pnlDate.Dock = DockStyle.Top;
            pnlDate.Location = new Point(10, 65);
            pnlDate.Name = "pnlDate";
            pnlDate.Padding = new Padding(10);
            pnlDate.Size = new Size(1017, 60);
            pnlDate.TabIndex = 2;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.IndianRed;
            btnPdf.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnPdf.ForeColor = Color.White;
            btnPdf.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPdf.IconColor = Color.Black;
            btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPdf.Location = new Point(865, 13);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(138, 34);
            btnPdf.TabIndex = 13;
            btnPdf.Text = "📄 Export Pdf";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnExport.BackColor = Color.ForestGreen;
            btnExport.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExport.IconColor = Color.Black;
            btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExport.Location = new Point(699, 13);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(160, 34);
            btnExport.TabIndex = 12;
            btnExport.Text = "𓊂  Export Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(397, 14);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(247, 31);
            dtpTo.TabIndex = 11;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(65, 15);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(247, 31);
            dtpFrom.TabIndex = 10;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTo.Location = new Point(363, 19);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 21);
            lblTo.TabIndex = 8;
            lblTo.Text = "To";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFrom.Location = new Point(10, 20);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(49, 21);
            lblFrom.TabIndex = 6;
            lblFrom.Text = "From";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnClear);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(cmbTransactionType);
            pnlHeader.Controls.Add(lblType);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(10, 10);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1017, 55);
            pnlHeader.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(676, 11);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Lavender;
            btnRefresh.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.RoyalBlue;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRefresh.IconColor = Color.Black;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(893, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "🗘Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(10, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search ...";
            txtSearch.Size = new Size(302, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Location = new Point(409, 11);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(235, 33);
            cmbTransactionType.TabIndex = 3;
            cmbTransactionType.SelectedIndexChanged += cmbTransactionType_SelectedIndexChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblType.Location = new Point(353, 15);
            lblType.Name = "lblType";
            lblType.Size = new Size(46, 21);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            // 
            // FrmHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1037, 632);
            Controls.Add(pnlMain);
            Name = "FrmHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master History";
            Load += FrmHistory_Load;
            pnlMain.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private ComboBox cmbTransactionType;
        private Label lblType;
        private TextBox txtSearch;
        private Panel pnlDate;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private Label lblFrom;
        private FontAwesome.Sharp.IconButton btnClear;
        private Panel pnlGrid;
        private DataGridView dgvHistory;
        private FontAwesome.Sharp.IconButton btnExport;
        private DateTimePicker dtpTo;
        private Panel pnlFooter;
        private Label lblRecordCount;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colPrevious;
        private DataGridViewTextBoxColumn colCurrent;
        private DataGridViewTextBoxColumn colReference;
        private DataGridViewTextBoxColumn colRemarks;
        private FontAwesome.Sharp.IconButton btnPdf;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
    }
}