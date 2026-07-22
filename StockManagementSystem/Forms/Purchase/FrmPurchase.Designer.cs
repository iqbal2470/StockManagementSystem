namespace StockManagementSystem.Forms.Purchase
{
    partial class FrmPurchase
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
            dgvPurchases = new DataGridView();
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
            label7 = new Label();
            label4 = new Label();
            cmbProduct = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            txtPurchaseNo = new TextBox();
            dtpPurchaseDate = new DateTimePicker();
            txtPurchasePrice = new TextBox();
            label10 = new Label();
            txtTotalAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).BeginInit();
            SuspendLayout();
            // 
            // dgvPurchases
            // 
            dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchases.Dock = DockStyle.Bottom;
            dgvPurchases.Location = new Point(0, 506);
            dgvPurchases.Name = "dgvPurchases";
            dgvPurchases.RowHeadersWidth = 62;
            dgvPurchases.Size = new Size(1253, 295);
            dgvPurchases.TabIndex = 74;
            dgvPurchases.CellClick += dgvPurchases_CellClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(897, 24);
            label14.Name = "label14";
            label14.Size = new Size(64, 25);
            label14.TabIndex = 73;
            label14.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1026, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Product...";
            txtSearch.Size = new Size(163, 31);
            txtSearch.TabIndex = 72;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(813, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 34);
            btnClear.TabIndex = 71;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(623, 317);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 70;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(431, 317);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 69;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(243, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 68;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtRemarks
            // 
            rtxtRemarks.Location = new Point(1026, 169);
            rtxtRemarks.Name = "rtxtRemarks";
            rtxtRemarks.Size = new Size(163, 31);
            rtxtRemarks.TabIndex = 63;
            rtxtRemarks.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(897, 172);
            label12.Name = "label12";
            label12.Size = new Size(79, 25);
            label12.TabIndex = 62;
            label12.Text = "Remarks";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 175);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 57;
            label9.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(176, 172);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(163, 31);
            txtQuantity.TabIndex = 56;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(897, 119);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 53;
            label7.Text = "Purchase Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 115);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 47;
            label4.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(176, 112);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(163, 33);
            cmbProduct.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(724, 73);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 45;
            label3.Text = "Purchase Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 57);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 42;
            label1.Text = "Purchage No";
            // 
            // txtPurchaseNo
            // 
            txtPurchaseNo.Location = new Point(176, 57);
            txtPurchaseNo.Name = "txtPurchaseNo";
            txtPurchaseNo.ReadOnly = true;
            txtPurchaseNo.Size = new Size(163, 31);
            txtPurchaseNo.TabIndex = 40;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(892, 68);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(296, 31);
            dtpPurchaseDate.TabIndex = 75;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(1026, 116);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(163, 31);
            txtPurchasePrice.TabIndex = 52;
            txtPurchasePrice.TextChanged += txtPurchasePrice_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(897, 225);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 77;
            label10.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(1026, 222);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(163, 31);
            txtTotalAmount.TabIndex = 76;
            // 
            // FrmPurchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 801);
            Controls.Add(label10);
            Controls.Add(txtTotalAmount);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(dgvPurchases);
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
            Controls.Add(label7);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label4);
            Controls.Add(cmbProduct);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPurchaseNo);
            Name = "FrmPurchase";
            Text = "FrmPurchase";
            Load += FrmPurchase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPurchases;
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
        private Label label7;
        private Label label4;
        private ComboBox cmbProduct;
        private Label label3;
        private Label label1;
        private TextBox txtPurchaseNo;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtPurchasePrice;
        private Label label10;
        private TextBox txtTotalAmount;
    }
}