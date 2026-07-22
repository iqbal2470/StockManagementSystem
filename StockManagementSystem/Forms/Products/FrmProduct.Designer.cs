namespace StockManagementSystem.Forms.Products
{
    partial class FrmProduct
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
            txtProductCode = new TextBox();
            txtProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtVehicleModel = new TextBox();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbBrand = new ComboBox();
            label6 = new Label();
            cmbUnit = new ComboBox();
            label7 = new Label();
            txtPurchasePrice = new TextBox();
            label8 = new Label();
            txtSalePrice = new TextBox();
            label9 = new Label();
            txtCurrentStock = new TextBox();
            label10 = new Label();
            txtMinimumStock = new TextBox();
            label11 = new Label();
            txtBarcode = new TextBox();
            label12 = new Label();
            rtxtDescription = new RichTextBox();
            picProductImage = new PictureBox();
            label13 = new Label();
            btnBrowseImage = new FontAwesome.Sharp.IconButton();
            btnRemoveImage = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            label14 = new Label();
            dgvProducts = new DataGridView();
            chkAutoBarcode = new CheckBox();
            picBarcode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBarcode).BeginInit();
            SuspendLayout();
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(167, 53);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(163, 31);
            txtProductCode.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(167, 107);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(163, 31);
            txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 53);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 2;
            label1.Text = "Product Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 110);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 62);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 5;
            label3.Text = "Vehicle Model";
            // 
            // txtVehicleModel
            // 
            txtVehicleModel.Location = new Point(571, 59);
            txtVehicleModel.Name = "txtVehicleModel";
            txtVehicleModel.Size = new Size(163, 31);
            txtVehicleModel.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(167, 161);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(163, 33);
            cmbCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 164);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 7;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 219);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 9;
            label5.Text = "Brand";
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(167, 216);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(163, 33);
            cmbBrand.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 276);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 11;
            label6.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(167, 273);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(163, 33);
            cmbUnit.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 110);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 13;
            label7.Text = "Purchase Price";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(571, 107);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(163, 31);
            txtPurchasePrice.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 164);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 15;
            label8.Text = "Sale Price";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(571, 161);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(163, 31);
            txtSalePrice.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 219);
            label9.Name = "label9";
            label9.Size = new Size(118, 25);
            label9.TabIndex = 17;
            label9.Text = "Current Stock";
            // 
            // txtCurrentStock
            // 
            txtCurrentStock.Location = new Point(571, 216);
            txtCurrentStock.Name = "txtCurrentStock";
            txtCurrentStock.Size = new Size(163, 31);
            txtCurrentStock.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(442, 276);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 19;
            label10.Text = "Minimum Stock";
            // 
            // txtMinimumStock
            // 
            txtMinimumStock.Location = new Point(571, 273);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.Size = new Size(163, 31);
            txtMinimumStock.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 395);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 21;
            label11.Text = "Barcode ";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(167, 392);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.ReadOnly = true;
            txtBarcode.Size = new Size(163, 31);
            txtBarcode.TabIndex = 20;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(442, 334);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 23;
            label12.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(571, 331);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(163, 31);
            rtxtDescription.TabIndex = 24;
            rtxtDescription.Text = "";
            // 
            // picProductImage
            // 
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(38, 489);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(121, 97);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 25;
            picProductImage.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(182, 489);
            label13.Name = "label13";
            label13.Size = new Size(46, 25);
            label13.TabIndex = 26;
            label13.Text = "Path";
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBrowseImage.IconColor = Color.Black;
            btnBrowseImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowseImage.Location = new Point(182, 552);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(234, 34);
            btnBrowseImage.TabIndex = 27;
            btnBrowseImage.Text = "BrowseImage";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRemoveImage.IconColor = Color.Black;
            btnRemoveImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemoveImage.Location = new Point(500, 552);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(234, 34);
            btnRemoveImage.TabIndex = 28;
            btnRemoveImage.Text = "RemoveImage";
            btnRemoveImage.UseVisualStyleBackColor = true;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // btnSave
            // 
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(38, 613);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(226, 613);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(418, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(608, 613);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 34);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(571, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Product...";
            txtSearch.Size = new Size(163, 31);
            txtSearch.TabIndex = 33;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(442, 15);
            label14.Name = "label14";
            label14.Size = new Size(64, 25);
            label14.TabIndex = 34;
            label14.Text = "Search";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Bottom;
            dgvProducts.Location = new Point(0, 724);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(800, 286);
            dgvProducts.TabIndex = 35;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // chkAutoBarcode
            // 
            chkAutoBarcode.AutoSize = true;
            chkAutoBarcode.Checked = true;
            chkAutoBarcode.CheckState = CheckState.Checked;
            chkAutoBarcode.Location = new Point(44, 436);
            chkAutoBarcode.Name = "chkAutoBarcode";
            chkAutoBarcode.Size = new Size(221, 29);
            chkAutoBarcode.TabIndex = 38;
            chkAutoBarcode.Text = "Auto Generate Barcode";
            chkAutoBarcode.UseVisualStyleBackColor = true;
            chkAutoBarcode.CheckedChanged += chkAutoBarcode_CheckedChanged;
            // 
            // picBarcode
            // 
            picBarcode.Location = new Point(442, 392);
            picBarcode.Name = "picBarcode";
            picBarcode.Size = new Size(292, 75);
            picBarcode.SizeMode = PictureBoxSizeMode.Zoom;
            picBarcode.TabIndex = 39;
            picBarcode.TabStop = false;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1010);
            Controls.Add(picBarcode);
            Controls.Add(chkAutoBarcode);
            Controls.Add(dgvProducts);
            Controls.Add(label14);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnRemoveImage);
            Controls.Add(btnBrowseImage);
            Controls.Add(label13);
            Controls.Add(picProductImage);
            Controls.Add(rtxtDescription);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtBarcode);
            Controls.Add(label10);
            Controls.Add(txtMinimumStock);
            Controls.Add(label9);
            Controls.Add(txtCurrentStock);
            Controls.Add(label8);
            Controls.Add(txtSalePrice);
            Controls.Add(label7);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label6);
            Controls.Add(cmbUnit);
            Controls.Add(label5);
            Controls.Add(cmbBrand);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(txtVehicleModel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductName);
            Controls.Add(txtProductCode);
            Name = "FrmProduct";
            Text = "Master Product Management";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBarcode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductCode;
        private TextBox txtProductName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVehicleModel;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label5;
        private ComboBox cmbBrand;
        private Label label6;
        private ComboBox cmbUnit;
        private Label label7;
        private TextBox txtPurchasePrice;
        private Label label8;
        private TextBox txtSalePrice;
        private Label label9;
        private TextBox txtCurrentStock;
        private Label label10;
        private TextBox txtMinimumStock;
        private Label label11;
        private TextBox txtBarcode;
        private Label label12;
        private RichTextBox rtxtDescription;
        private PictureBox picProductImage;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnBrowseImage;
        private FontAwesome.Sharp.IconButton btnRemoveImage;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnClear;
        private TextBox txtSearch;
        private Label label14;
        private DataGridView dgvProducts;
        private Label label15;
        private TextBox textBox1;
        private CheckBox chkAutoBarcode;
        private PictureBox picBarcode;
    }
}