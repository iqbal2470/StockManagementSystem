namespace StockManagementSystem.Forms.Stock
{
    partial class FrmStock
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
            dgvStock = new DataGridView();
            label14 = new Label();
            txtSearch = new TextBox();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnLowStock = new FontAwesome.Sharp.IconButton();
            btnOutOfStock = new FontAwesome.Sharp.IconButton();
            lblLowStock = new Label();
            lblOutOfStock = new Label();
            lblTotalProducts = new Label();
            lblInStock = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Dock = DockStyle.Bottom;
            dgvStock.Location = new Point(0, 421);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(1223, 295);
            dgvStock.TabIndex = 116;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(33, 15);
            label14.Name = "label14";
            label14.Size = new Size(64, 25);
            label14.TabIndex = 115;
            label14.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(162, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Product...";
            txtSearch.Size = new Size(163, 31);
            txtSearch.TabIndex = 114;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(799, 309);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 34);
            btnClear.TabIndex = 113;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(609, 309);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 112;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(417, 309);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 111;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(229, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 110;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRefresh.IconColor = Color.Black;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(1064, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 120;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLowStock.IconColor = Color.Black;
            btnLowStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLowStock.Location = new Point(455, 15);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(112, 34);
            btnLowStock.TabIndex = 121;
            btnLowStock.Text = "LowStockh";
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnOutOfStock
            // 
            btnOutOfStock.IconChar = FontAwesome.Sharp.IconChar.None;
            btnOutOfStock.IconColor = Color.Black;
            btnOutOfStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOutOfStock.Location = new Point(737, 15);
            btnOutOfStock.Name = "btnOutOfStock";
            btnOutOfStock.Size = new Size(204, 34);
            btnOutOfStock.TabIndex = 122;
            btnOutOfStock.Text = "OutOfStock";
            btnOutOfStock.UseVisualStyleBackColor = true;
            btnOutOfStock.Click += btnOutOfStock_Click;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(455, 61);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(87, 25);
            lblLowStock.TabIndex = 123;
            lblLowStock.Text = "LowStock";
            // 
            // lblOutOfStock
            // 
            lblOutOfStock.AutoSize = true;
            lblOutOfStock.Location = new Point(737, 61);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new Size(105, 25);
            lblOutOfStock.TabIndex = 124;
            lblOutOfStock.Text = "OutOfStock";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Location = new Point(1064, 83);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(119, 25);
            lblTotalProducts.TabIndex = 125;
            lblTotalProducts.Text = "TotalProducts";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(456, 144);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(70, 25);
            lblInStock.TabIndex = 126;
            lblInStock.Text = "InStock";
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 716);
            Controls.Add(lblInStock);
            Controls.Add(lblTotalProducts);
            Controls.Add(lblOutOfStock);
            Controls.Add(lblLowStock);
            Controls.Add(btnOutOfStock);
            Controls.Add(btnLowStock);
            Controls.Add(btnRefresh);
            Controls.Add(dgvStock);
            Controls.Add(label14);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Name = "FrmStock";
            Text = "FrmStock";
            Load += FrmStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvStock;
        private Label label14;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnLowStock;
        private FontAwesome.Sharp.IconButton btnOutOfStock;
        private Label lblLowStock;
        private Label lblOutOfStock;
        private Label lblTotalProducts;
        private Label lblInStock;
    }
}