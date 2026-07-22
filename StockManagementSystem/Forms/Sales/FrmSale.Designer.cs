namespace StockManagementSystem.Forms.Sales
{
    partial class FrmSale
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
            label10 = new Label();
            txtTotalAmount = new TextBox();
            dtpSaleDate = new DateTimePicker();
            dgvSales = new DataGridView();
            label14 = new Label();
            txtSearch = new TextBox();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            rtxtRemarks = new RichTextBox();
            label12 = new Label();
            label9 = new Label();
            txtQuantity = new TextBox();
            txtSalesPrice = new Label();
            txtSalePrice = new TextBox();
            label4 = new Label();
            cmbProduct = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            txtSaleNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(883, 229);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 98;
            label10.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(1012, 226);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(163, 31);
            txtTotalAmount.TabIndex = 97;
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(878, 72);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(296, 31);
            dtpSaleDate.TabIndex = 96;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Dock = DockStyle.Bottom;
            dgvSales.Location = new Point(0, 404);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 62;
            dgvSales.Size = new Size(1213, 295);
            dgvSales.TabIndex = 95;
            dgvSales.CellClick += dgvSales_CellClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(883, 28);
            label14.Name = "label14";
            label14.Size = new Size(64, 25);
            label14.TabIndex = 94;
            label14.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1012, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Product...";
            txtSearch.Size = new Size(163, 31);
            txtSearch.TabIndex = 93;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(799, 321);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 34);
            btnClear.TabIndex = 92;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(609, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 91;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(417, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 90;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(229, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 89;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtRemarks
            // 
            rtxtRemarks.Location = new Point(1012, 173);
            rtxtRemarks.Name = "rtxtRemarks";
            rtxtRemarks.Size = new Size(163, 31);
            rtxtRemarks.TabIndex = 88;
            rtxtRemarks.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(883, 176);
            label12.Name = "label12";
            label12.Size = new Size(79, 25);
            label12.TabIndex = 87;
            label12.Text = "Remarks";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 179);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 86;
            label9.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(162, 176);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(163, 31);
            txtQuantity.TabIndex = 85;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtSalesPrice
            // 
            txtSalesPrice.AutoSize = true;
            txtSalesPrice.Location = new Point(883, 123);
            txtSalesPrice.Name = "txtSalesPrice";
            txtSalesPrice.Size = new Size(86, 25);
            txtSalesPrice.TabIndex = 84;
            txtSalesPrice.Text = "Sale Price";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(1012, 120);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(163, 31);
            txtSalePrice.TabIndex = 83;
            txtSalePrice.TextChanged += txtSalePrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 119);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 82;
            label4.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(162, 116);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(163, 33);
            cmbProduct.TabIndex = 81;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 77);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 80;
            label3.Text = "Sale Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 61);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 79;
            label1.Text = "Purchage No";
            // 
            // txtSaleNo
            // 
            txtSaleNo.Location = new Point(162, 61);
            txtSaleNo.Name = "txtSaleNo";
            txtSaleNo.ReadOnly = true;
            txtSaleNo.Size = new Size(163, 31);
            txtSaleNo.TabIndex = 78;
            // 
            // FrmSale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 699);
            Controls.Add(label10);
            Controls.Add(txtTotalAmount);
            Controls.Add(dtpSaleDate);
            Controls.Add(dgvSales);
            Controls.Add(label14);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(rtxtRemarks);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(txtQuantity);
            Controls.Add(txtSalesPrice);
            Controls.Add(txtSalePrice);
            Controls.Add(label4);
            Controls.Add(cmbProduct);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSaleNo);
            Name = "FrmSale";
            Text = "FrmSale";
            Load += FrmSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox txtTotalAmount;
        private DateTimePicker dtpSaleDate;
        private DataGridView dgvSales;
        private Label label14;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSave;
        private RichTextBox rtxtRemarks;
        private Label label12;
        private Label label9;
        private TextBox txtQuantity;
        private Label txtSalesPrice;
        private TextBox txtSalePrice;
        private Label label4;
        private ComboBox cmbProduct;
        private Label label3;
        private Label label1;
        private TextBox txtSaleNo;
    }
}