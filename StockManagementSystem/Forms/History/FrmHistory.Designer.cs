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
            pnlFooter = new Panel();
            lblRecordCount = new Label();
            dgvHistory = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPrevious = new DataGridViewTextBoxColumn();
            colCurrent = new DataGridViewTextBoxColumn();
            colReference = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            pnlDate = new Panel();
            btnPdf = new FontAwesome.Sharp.IconButton();
            btnExport = new FontAwesome.Sharp.IconButton();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            lblFrom = new Label();
            pnlFilter = new Panel();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            cmbTransactionType = new ComboBox();
            lblType = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlHeader = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            pnlGrid.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlDate.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(pnlDate);
            pnlMain.Controls.Add(pnlFilter);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(15);
            pnlMain.Size = new Size(800, 642);
            pnlMain.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(pnlFooter);
            pnlGrid.Controls.Add(dgvHistory);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(15, 199);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(10);
            pnlGrid.Size = new Size(770, 428);
            pnlGrid.TabIndex = 3;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(lblRecordCount);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(10, 378);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(750, 40);
            pnlFooter.TabIndex = 1;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Location = new Point(300, 8);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(141, 25);
            lblRecordCount.TabIndex = 0;
            lblRecordCount.Text = "Total Records : 0";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colDate, colProduct, colType, colQty, colPrevious, colCurrent, colReference, colRemarks });
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(10, 10);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(750, 408);
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
            pnlDate.Location = new Point(15, 139);
            pnlDate.Name = "pnlDate";
            pnlDate.Padding = new Padding(10);
            pnlDate.Size = new Size(770, 60);
            pnlDate.TabIndex = 2;
            // 
            // btnPdf
            // 
            btnPdf.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPdf.IconColor = Color.Black;
            btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPdf.Location = new Point(636, 13);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(112, 34);
            btnPdf.TabIndex = 13;
            btnPdf.Text = "Export Pdf";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExport
            // 
            btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExport.IconColor = Color.Black;
            btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExport.Location = new Point(507, 13);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(123, 34);
            btnExport.TabIndex = 12;
            btnExport.Text = "Export Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(341, 14);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(160, 31);
            dtpTo.TabIndex = 11;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(65, 15);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(220, 31);
            dtpFrom.TabIndex = 10;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(309, 18);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(30, 25);
            lblTo.TabIndex = 8;
            lblTo.Text = "To";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(10, 18);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(54, 25);
            lblFrom.TabIndex = 6;
            lblFrom.Text = "From";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.Controls.Add(btnClear);
            pnlFilter.Controls.Add(btnSearch);
            pnlFilter.Controls.Add(cmbTransactionType);
            pnlFilter.Controls.Add(lblType);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(15, 70);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(10);
            pnlFilter.Size = new Size(770, 69);
            pnlFilter.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(661, 19);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.Location = new Point(562, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Location = new Point(379, 19);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(160, 33);
            cmbTransactionType.TabIndex = 3;
            cmbTransactionType.SelectedIndexChanged += cmbTransactionType_SelectedIndexChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(323, 23);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 25);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(15, 15);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(770, 55);
            pnlHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRefresh.IconColor = Color.Black;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(661, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(10, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "History";
            // 
            // FrmHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 642);
            Controls.Add(pnlMain);
            Name = "FrmHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master History";
            Load += FrmHistory_Load;
            pnlMain.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlHeader;
        private Panel pnlFilter;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSearch;
        private ComboBox cmbTransactionType;
        private Label lblType;
        private TextBox txtSearch;
        private Label lblSearch;
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
    }
}