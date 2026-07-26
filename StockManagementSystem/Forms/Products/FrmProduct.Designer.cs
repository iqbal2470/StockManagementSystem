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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dgvProducts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colSrNo = new DataGridViewTextBoxColumn();
            colImage = new DataGridViewImageColumn();
            colProductCode = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colBrand = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colPurchasePrice = new DataGridViewTextBoxColumn();
            colSalePrice = new DataGridViewTextBoxColumn();
            colCurrentStock = new DataGridViewTextBoxColumn();
            colMinimumStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colUpdatedDate = new DataGridViewTextBoxColumn();
            chkAutoBarcode = new CheckBox();
            picBarcode = new PictureBox();
            pnlMain = new Panel();
            panel20 = new Panel();
            panel24 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel21 = new Panel();
            panel23 = new Panel();
            panel22 = new Panel();
            label11 = new Label();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            panel17 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel19 = new Panel();
            panel18 = new Panel();
            panel14 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel16 = new Panel();
            groupBox1 = new GroupBox();
            panel15 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel13 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel6 = new Panel();
            label20 = new Label();
            pictureBox3 = new PictureBox();
            pnlDashboard = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            lblOutofStock = new Label();
            label21 = new Label();
            pnlLowStock = new Panel();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label17 = new Label();
            lblLowStock = new Label();
            label18 = new Label();
            pnlCurrentStock = new Panel();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label15 = new Label();
            lblCurrentStock = new Label();
            label16 = new Label();
            pnlTotalProducts = new Panel();
            panel2 = new Panel();
            picProducts = new PictureBox();
            lblProductDesc = new Label();
            lblTotalProducts = new Label();
            lblProductsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBarcode).BeginInit();
            pnlMain.SuspendLayout();
            panel20.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel21.SuspendLayout();
            panel23.SuspendLayout();
            panel22.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel17.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel18.SuspendLayout();
            panel14.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel16.SuspendLayout();
            groupBox1.SuspendLayout();
            panel15.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlDashboard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLowStock.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlCurrentStock.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlTotalProducts.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            SuspendLayout();
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(18, 49);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(306, 29);
            txtProductCode.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(18, 112);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Enter product name...";
            txtProductName.Size = new Size(306, 29);
            txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Product Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(15, 28);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 5;
            label3.Text = "Vehicle Model";
            // 
            // txtVehicleModel
            // 
            txtVehicleModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtVehicleModel.Location = new Point(19, 51);
            txtVehicleModel.Name = "txtVehicleModel";
            txtVehicleModel.PlaceholderText = "Enter Vehicle model name";
            txtVehicleModel.Size = new Size(306, 29);
            txtVehicleModel.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(18, 25);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(306, 29);
            cmbCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 7;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(14, 88);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 9;
            label5.Text = "Brand";
            // 
            // cmbBrand
            // 
            cmbBrand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(19, 112);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(306, 29);
            cmbBrand.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(374, 1);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 11;
            label6.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.Anchor = AnchorStyles.Right;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(374, 25);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(306, 29);
            cmbUnit.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(24, 26);
            label7.Name = "label7";
            label7.Size = new Size(121, 21);
            label7.TabIndex = 13;
            label7.Text = "Purchase Price";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtPurchasePrice.Location = new Point(28, 50);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.PlaceholderText = "Enter purchase price...";
            txtPurchasePrice.Size = new Size(306, 29);
            txtPurchasePrice.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(23, 89);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 15;
            label8.Text = "Sale Price";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSalePrice.Location = new Point(28, 113);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.PlaceholderText = "Enter sale price...";
            txtSalePrice.Size = new Size(306, 29);
            txtSalePrice.TabIndex = 14;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(19, 27);
            label9.Name = "label9";
            label9.Size = new Size(113, 21);
            label9.TabIndex = 17;
            label9.Text = "Current Stock";
            // 
            // txtCurrentStock
            // 
            txtCurrentStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtCurrentStock.Location = new Point(24, 51);
            txtCurrentStock.Name = "txtCurrentStock";
            txtCurrentStock.PlaceholderText = "Enter stock...";
            txtCurrentStock.Size = new Size(306, 29);
            txtCurrentStock.TabIndex = 16;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(19, 89);
            label10.Name = "label10";
            label10.Size = new Size(131, 21);
            label10.TabIndex = 19;
            label10.Text = "Minimum Stock";
            // 
            // txtMinimumStock
            // 
            txtMinimumStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtMinimumStock.Location = new Point(24, 113);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.Size = new Size(306, 29);
            txtMinimumStock.TabIndex = 18;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(12, 25);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.ReadOnly = true;
            txtBarcode.Size = new Size(247, 29);
            txtBarcode.TabIndex = 20;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(23, 1);
            label12.Name = "label12";
            label12.Size = new Size(98, 21);
            label12.TabIndex = 23;
            label12.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rtxtDescription.Location = new Point(122, 13);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(566, 42);
            rtxtDescription.TabIndex = 24;
            rtxtDescription.Text = "";
            // 
            // picProductImage
            // 
            picProductImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picProductImage.BackColor = Color.AliceBlue;
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(18, 66);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(126, 102);
            picProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picProductImage.TabIndex = 25;
            picProductImage.TabStop = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(159, 66);
            label13.Name = "label13";
            label13.Size = new Size(45, 21);
            label13.TabIndex = 26;
            label13.Text = "Path";
            label13.Visible = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnBrowseImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBrowseImage.IconColor = Color.Black;
            btnBrowseImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowseImage.Location = new Point(159, 126);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(220, 42);
            btnBrowseImage.TabIndex = 27;
            btnBrowseImage.Text = "BrowseImage";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Anchor = AnchorStyles.Right;
            btnRemoveImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRemoveImage.IconColor = Color.Black;
            btnRemoveImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemoveImage.Location = new Point(446, 126);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(234, 42);
            btnRemoveImage.TabIndex = 28;
            btnRemoveImage.Text = "RemoveImage";
            btnRemoveImage.UseVisualStyleBackColor = true;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(59, 130, 246);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(18, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.BackColor = Color.FromArgb(34, 197, 94);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(162, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.FromArgb(245, 158, 11);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(307, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.FromArgb(239, 68, 68);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.ForeColor = Color.White;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(453, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 34);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(967, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search Product...";
            txtSearch.Size = new Size(444, 31);
            txtSearch.TabIndex = 33;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Id, colSrNo, colImage, colProductCode, colProductName, colCategory, colBrand, colUnit, colPurchasePrice, colSalePrice, colCurrentStock, colMinimumStock, colStatus, colCreatedDate, colUpdatedDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1422, 335);
            dgvProducts.TabIndex = 35;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // colSrNo
            // 
            colSrNo.HeaderText = "#";
            colSrNo.MinimumWidth = 8;
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            colSrNo.Width = 150;
            // 
            // colImage
            // 
            colImage.HeaderText = "Image";
            colImage.MinimumWidth = 8;
            colImage.Name = "colImage";
            colImage.ReadOnly = true;
            colImage.Resizable = DataGridViewTriState.True;
            colImage.SortMode = DataGridViewColumnSortMode.Automatic;
            colImage.Width = 150;
            // 
            // colProductCode
            // 
            colProductCode.DataPropertyName = "ProductCode";
            colProductCode.HeaderText = "Product Code";
            colProductCode.MinimumWidth = 8;
            colProductCode.Name = "colProductCode";
            colProductCode.ReadOnly = true;
            colProductCode.Width = 150;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 150;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "CategoryName";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 8;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 150;
            // 
            // colBrand
            // 
            colBrand.DataPropertyName = "BrandName";
            colBrand.HeaderText = "Brand";
            colBrand.MinimumWidth = 8;
            colBrand.Name = "colBrand";
            colBrand.ReadOnly = true;
            colBrand.Width = 150;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "UnitName";
            colUnit.HeaderText = "Unit";
            colUnit.MinimumWidth = 8;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            colUnit.Width = 150;
            // 
            // colPurchasePrice
            // 
            colPurchasePrice.DataPropertyName = "PurchasePrice";
            colPurchasePrice.HeaderText = "Purchase Price";
            colPurchasePrice.MinimumWidth = 8;
            colPurchasePrice.Name = "colPurchasePrice";
            colPurchasePrice.ReadOnly = true;
            colPurchasePrice.Width = 150;
            // 
            // colSalePrice
            // 
            colSalePrice.DataPropertyName = "SalePrice";
            colSalePrice.HeaderText = "Sale Price";
            colSalePrice.MinimumWidth = 8;
            colSalePrice.Name = "colSalePrice";
            colSalePrice.ReadOnly = true;
            colSalePrice.Width = 150;
            // 
            // colCurrentStock
            // 
            colCurrentStock.DataPropertyName = "CurrentStock";
            colCurrentStock.HeaderText = "Stock";
            colCurrentStock.MinimumWidth = 8;
            colCurrentStock.Name = "colCurrentStock";
            colCurrentStock.ReadOnly = true;
            colCurrentStock.Width = 150;
            // 
            // colMinimumStock
            // 
            colMinimumStock.DataPropertyName = "MinimumStock";
            colMinimumStock.HeaderText = "Min Stock";
            colMinimumStock.MinimumWidth = 8;
            colMinimumStock.Name = "colMinimumStock";
            colMinimumStock.ReadOnly = true;
            colMinimumStock.Width = 150;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "IsActive";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 150;
            // 
            // colCreatedDate
            // 
            colCreatedDate.DataPropertyName = "CreatedDate";
            colCreatedDate.HeaderText = "Created";
            colCreatedDate.MinimumWidth = 8;
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.ReadOnly = true;
            colCreatedDate.Width = 150;
            // 
            // colUpdatedDate
            // 
            colUpdatedDate.DataPropertyName = "UpdatedDate";
            colUpdatedDate.HeaderText = "Updated";
            colUpdatedDate.MinimumWidth = 8;
            colUpdatedDate.Name = "colUpdatedDate";
            colUpdatedDate.ReadOnly = true;
            colUpdatedDate.Width = 150;
            // 
            // chkAutoBarcode
            // 
            chkAutoBarcode.AutoSize = true;
            chkAutoBarcode.Checked = true;
            chkAutoBarcode.CheckState = CheckState.Checked;
            chkAutoBarcode.Location = new Point(9, 72);
            chkAutoBarcode.Name = "chkAutoBarcode";
            chkAutoBarcode.Size = new Size(212, 25);
            chkAutoBarcode.TabIndex = 38;
            chkAutoBarcode.Text = "Auto Generate Barcode";
            chkAutoBarcode.UseVisualStyleBackColor = true;
            chkAutoBarcode.CheckedChanged += chkAutoBarcode_CheckedChanged;
            // 
            // picBarcode
            // 
            picBarcode.Location = new Point(285, 25);
            picBarcode.Name = "picBarcode";
            picBarcode.Size = new Size(350, 75);
            picBarcode.SizeMode = PictureBoxSizeMode.Zoom;
            picBarcode.TabIndex = 39;
            picBarcode.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(panel20);
            pnlMain.Controls.Add(panel4);
            pnlMain.Controls.Add(pnlDashboard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1450, 1050);
            pnlMain.TabIndex = 40;
            // 
            // panel20
            // 
            panel20.Controls.Add(panel24);
            panel20.Controls.Add(tableLayoutPanel6);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(0, 635);
            panel20.Name = "panel20";
            panel20.Size = new Size(1450, 415);
            panel20.TabIndex = 42;
            // 
            // panel24
            // 
            panel24.Dock = DockStyle.Bottom;
            panel24.Location = new Point(0, 358);
            panel24.Name = "panel24";
            panel24.Size = new Size(1450, 57);
            panel24.TabIndex = 37;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(panel21, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(10);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1450, 415);
            tableLayoutPanel6.TabIndex = 36;
            // 
            // panel21
            // 
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(panel23);
            panel21.Controls.Add(panel22);
            panel21.Dock = DockStyle.Fill;
            panel21.Location = new Point(13, 13);
            panel21.Name = "panel21";
            panel21.Size = new Size(1424, 389);
            panel21.TabIndex = 0;
            panel21.Paint += panel21_Paint;
            // 
            // panel23
            // 
            panel23.Controls.Add(dgvProducts);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(0, 52);
            panel23.Name = "panel23";
            panel23.Size = new Size(1422, 335);
            panel23.TabIndex = 37;
            // 
            // panel22
            // 
            panel22.BackColor = Color.Lavender;
            panel22.Controls.Add(label11);
            panel22.Controls.Add(txtSearch);
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(1422, 52);
            panel22.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(13, 12);
            label11.Name = "label11";
            label11.Size = new Size(134, 28);
            label11.TabIndex = 34;
            label11.Text = "Products List";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 150);
            panel4.Margin = new Padding(10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1450, 485);
            panel4.TabIndex = 41;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1450, 485);
            tableLayoutPanel2.TabIndex = 35;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel17);
            panel5.Controls.Add(panel14);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            panel5.Location = new Point(13, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(1424, 459);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // panel17
            // 
            panel17.Controls.Add(tableLayoutPanel5);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(0, 393);
            panel17.Name = "panel17";
            panel17.Size = new Size(1422, 64);
            panel17.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel19, 1, 0);
            tableLayoutPanel5.Controls.Add(panel18, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1422, 64);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel19
            // 
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(714, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(705, 58);
            panel19.TabIndex = 1;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnDelete);
            panel18.Controls.Add(btnSave);
            panel18.Controls.Add(btnUpdate);
            panel18.Controls.Add(btnClear);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(3, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(705, 58);
            panel18.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.Controls.Add(tableLayoutPanel4);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 199);
            panel14.Name = "panel14";
            panel14.Size = new Size(1422, 194);
            panel14.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel16, 1, 0);
            tableLayoutPanel4.Controls.Add(panel15, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1422, 194);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.Controls.Add(groupBox1);
            panel16.Controls.Add(rtxtDescription);
            panel16.Controls.Add(label12);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(714, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(705, 188);
            panel16.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(chkAutoBarcode);
            groupBox1.Controls.Add(picBarcode);
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(23, 62);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(665, 111);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barcode";
            // 
            // panel15
            // 
            panel15.Controls.Add(cmbUnit);
            panel15.Controls.Add(picProductImage);
            panel15.Controls.Add(label4);
            panel15.Controls.Add(label13);
            panel15.Controls.Add(btnBrowseImage);
            panel15.Controls.Add(label6);
            panel15.Controls.Add(cmbCategory);
            panel15.Controls.Add(btnRemoveImage);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(3, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(705, 188);
            panel15.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(tableLayoutPanel3);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 41);
            panel9.Name = "panel9";
            panel9.Size = new Size(1422, 158);
            panel9.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(panel13, 3, 0);
            tableLayoutPanel3.Controls.Add(panel12, 2, 0);
            tableLayoutPanel3.Controls.Add(panel11, 1, 0);
            tableLayoutPanel3.Controls.Add(panel10, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1422, 158);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.Controls.Add(txtPurchasePrice);
            panel13.Controls.Add(label8);
            panel13.Controls.Add(label7);
            panel13.Controls.Add(txtSalePrice);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(1068, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(351, 152);
            panel13.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtCurrentStock);
            panel12.Controls.Add(txtMinimumStock);
            panel12.Controls.Add(label10);
            panel12.Controls.Add(label9);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(713, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(349, 152);
            panel12.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtVehicleModel);
            panel11.Controls.Add(cmbBrand);
            panel11.Controls.Add(label5);
            panel11.Controls.Add(label3);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(358, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(349, 152);
            panel11.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtProductCode);
            panel10.Controls.Add(txtProductName);
            panel10.Controls.Add(label1);
            panel10.Controls.Add(label2);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(349, 152);
            panel10.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label20);
            panel6.Controls.Add(pictureBox3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1422, 41);
            panel6.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label20.Location = new Point(51, 7);
            label20.Name = "label20";
            label20.Size = new Size(205, 28);
            label20.TabIndex = 1;
            label20.Text = "Product Information";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.google_docs;
            pictureBox3.Location = new Point(13, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(5);
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(tableLayoutPanel1);
            pnlDashboard.Dock = DockStyle.Top;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1450, 150);
            pnlDashboard.TabIndex = 40;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlLowStock, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlCurrentStock, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlTotalProducts, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1450, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(lblOutofStock);
            panel1.Controls.Add(label21);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(1096, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 130);
            panel1.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(15, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.cancel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(90, 91);
            label19.Name = "label19";
            label19.Size = new Size(120, 25);
            label19.TabIndex = 3;
            label19.Text = "Out of Stocks";
            // 
            // lblOutofStock
            // 
            lblOutofStock.AutoSize = true;
            lblOutofStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblOutofStock.ForeColor = Color.Black;
            lblOutofStock.Location = new Point(90, 45);
            lblOutofStock.Name = "lblOutofStock";
            lblOutofStock.Size = new Size(41, 48);
            lblOutofStock.TabIndex = 2;
            lblOutofStock.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label21.Location = new Point(90, 20);
            label21.Name = "label21";
            label21.Size = new Size(131, 28);
            label21.TabIndex = 1;
            label21.Text = "Out of Stock";
            // 
            // pnlLowStock
            // 
            pnlLowStock.AutoSize = true;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(panel8);
            pnlLowStock.Controls.Add(label17);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(label18);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.ForeColor = Color.DimGray;
            pnlLowStock.Location = new Point(734, 10);
            pnlLowStock.Margin = new Padding(10);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(342, 130);
            pnlLowStock.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox6);
            panel8.Location = new Point(15, 18);
            panel8.Name = "panel8";
            panel8.Size = new Size(55, 55);
            panel8.TabIndex = 7;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Cornsilk;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.warning;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Padding = new Padding(10);
            pictureBox6.Size = new Size(55, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.ForeColor = Color.Gray;
            label17.Location = new Point(90, 91);
            label17.Name = "label17";
            label17.Size = new Size(133, 25);
            label17.TabIndex = 3;
            label17.Text = "Need Attention";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.Black;
            lblLowStock.Location = new Point(90, 45);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(41, 48);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label18.Location = new Point(90, 20);
            label18.Name = "label18";
            label18.Size = new Size(108, 28);
            label18.TabIndex = 1;
            label18.Text = "Low Stock";
            // 
            // pnlCurrentStock
            // 
            pnlCurrentStock.AutoSize = true;
            pnlCurrentStock.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentStock.Controls.Add(panel7);
            pnlCurrentStock.Controls.Add(label15);
            pnlCurrentStock.Controls.Add(lblCurrentStock);
            pnlCurrentStock.Controls.Add(label16);
            pnlCurrentStock.Dock = DockStyle.Fill;
            pnlCurrentStock.ForeColor = Color.DimGray;
            pnlCurrentStock.Location = new Point(372, 10);
            pnlCurrentStock.Margin = new Padding(10);
            pnlCurrentStock.Name = "pnlCurrentStock";
            pnlCurrentStock.Size = new Size(342, 130);
            pnlCurrentStock.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(15, 18);
            panel7.Name = "panel7";
            panel7.Size = new Size(55, 55);
            panel7.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LavenderBlush;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.box;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Padding = new Padding(10);
            pictureBox5.Size = new Size(55, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(90, 91);
            label15.Name = "label15";
            label15.Size = new Size(131, 25);
            label15.TabIndex = 3;
            label15.Text = "Available Stock";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCurrentStock.ForeColor = Color.Black;
            lblCurrentStock.Location = new Point(90, 45);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(41, 48);
            lblCurrentStock.TabIndex = 2;
            lblCurrentStock.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label16.Location = new Point(90, 20);
            label16.Name = "label16";
            label16.Size = new Size(141, 28);
            label16.TabIndex = 1;
            label16.Text = "Current Stock";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.AutoSize = true;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(panel2);
            pnlTotalProducts.Controls.Add(lblProductDesc);
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Controls.Add(lblProductsTitle);
            pnlTotalProducts.Dock = DockStyle.Fill;
            pnlTotalProducts.ForeColor = Color.DimGray;
            pnlTotalProducts.Location = new Point(10, 10);
            pnlTotalProducts.Margin = new Padding(10);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(342, 130);
            pnlTotalProducts.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(picProducts);
            panel2.Location = new Point(15, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 55);
            panel2.TabIndex = 4;
            // 
            // picProducts
            // 
            picProducts.BackColor = Color.AliceBlue;
            picProducts.BackgroundImageLayout = ImageLayout.Stretch;
            picProducts.Dock = DockStyle.Fill;
            picProducts.Image = Properties.Resources.parcel;
            picProducts.Location = new Point(0, 0);
            picProducts.Name = "picProducts";
            picProducts.Padding = new Padding(10);
            picProducts.Size = new Size(55, 55);
            picProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducts.TabIndex = 0;
            picProducts.TabStop = false;
            // 
            // lblProductDesc
            // 
            lblProductDesc.AutoSize = true;
            lblProductDesc.Font = new Font("Segoe UI", 9F);
            lblProductDesc.ForeColor = Color.Gray;
            lblProductDesc.Location = new Point(90, 91);
            lblProductDesc.Name = "lblProductDesc";
            lblProductDesc.Size = new Size(107, 25);
            lblProductDesc.TabIndex = 3;
            lblProductDesc.Text = "All Products";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.Black;
            lblTotalProducts.Location = new Point(90, 45);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(41, 48);
            lblTotalProducts.TabIndex = 2;
            lblTotalProducts.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductsTitle.Location = new Point(90, 20);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(148, 28);
            lblProductsTitle.TabIndex = 1;
            lblProductsTitle.Text = "Total Products";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1450, 1050);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 9F);
            Name = "FrmProduct";
            Text = "Master Product Management";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBarcode).EndInit();
            pnlMain.ResumeLayout(false);
            panel20.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel17.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel14.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel9.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlDashboard.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlCurrentStock.ResumeLayout(false);
            pnlCurrentStock.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ResumeLayout(false);
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
        private DataGridView dgvProducts;
        private Label label15;
        private TextBox textBox1;
        private CheckBox chkAutoBarcode;
        private PictureBox picBarcode;
        private Panel pnlMain;
        private Panel pnlDashboard;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlTotalProducts;
        private Panel panel2;
        private PictureBox picProducts;
        private Label lblProductDesc;
        private Label lblTotalProducts;
        private Label lblProductsTitle;
        private Panel pnlCurrentStock;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Label lblCurrentStock;
        private Label label16;
        private Panel pnlLowStock;
        private Panel panel8;
        private PictureBox pictureBox6;
        private Label label17;
        private Label lblLowStock;
        private Label label18;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label19;
        private Label lblOutofStock;
        private Label label21;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label20;
        private GroupBox groupBox1;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel6;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel16;
        private Panel panel15;
        private Panel panel17;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel19;
        private Panel panel18;
        private Panel panel20;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Label label11;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewImageColumn colImage;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colBrand;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colPurchasePrice;
        private DataGridViewTextBoxColumn colSalePrice;
        private DataGridViewTextBoxColumn CurrentStock;
        private DataGridViewTextBoxColumn colMinimumStock;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colUpdatedDate;
        private Panel panel24;
        private DataGridViewTextBoxColumn colCurrentStock;
    }
}