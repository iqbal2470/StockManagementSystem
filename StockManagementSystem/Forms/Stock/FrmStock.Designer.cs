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
            Id = new DataGridViewTextBoxColumn();
            colSrNo = new DataGridViewTextBoxColumn();
            colProductCode = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colCurrentStock = new DataGridViewTextBoxColumn();
            colMinimumStock = new DataGridViewTextBoxColumn();
            colPurchasePrice = new DataGridViewTextBoxColumn();
            colSalePrice = new DataGridViewTextBoxColumn();
            colStockStatus = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colUpdatedDate = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnLowStock = new FontAwesome.Sharp.IconButton();
            btnOutOfStock = new FontAwesome.Sharp.IconButton();
            lblLowStock = new Label();
            lblOutOfStock = new Label();
            lblTotalProducts = new Label();
            lblInStock = new Label();
            pnlMain = new Panel();
            panel6 = new Panel();
            panel11 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel12 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel10 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            label21 = new Label();
            pnlLowStock = new Panel();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            pnlCurrentStock = new Panel();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            pnlTotalProducts = new Panel();
            panel4 = new Panel();
            picProducts = new PictureBox();
            lblProductDesc = new Label();
            lblProductsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            pnlMain.SuspendLayout();
            panel6.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLowStock.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlCurrentStock.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlTotalProducts.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { Id, colSrNo, colProductCode, colProductName, colCategoryName, colCurrentStock, colMinimumStock, colPurchasePrice, colSalePrice, colStockStatus, colCreatedDate, colUpdatedDate });
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(0, 0);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 62;
            dgvStock.Size = new Size(1197, 417);
            dgvStock.TabIndex = 116;
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
            colSrNo.HeaderText = "S.No";
            colSrNo.MinimumWidth = 8;
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            colSrNo.Width = 150;
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
            // colCategoryName
            // 
            colCategoryName.DataPropertyName = "CategoryName";
            colCategoryName.HeaderText = "Category";
            colCategoryName.MinimumWidth = 8;
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            colCategoryName.Width = 150;
            // 
            // colCurrentStock
            // 
            colCurrentStock.DataPropertyName = "CurrentStock";
            colCurrentStock.HeaderText = "Current Stock";
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
            colSalePrice.DataPropertyName = " SalePrice";
            colSalePrice.HeaderText = "Sale Price";
            colSalePrice.MinimumWidth = 8;
            colSalePrice.Name = "colSalePrice";
            colSalePrice.ReadOnly = true;
            colSalePrice.Width = 150;
            // 
            // colStockStatus
            // 
            colStockStatus.DataPropertyName = "StockStatus";
            colStockStatus.HeaderText = "Status";
            colStockStatus.MinimumWidth = 8;
            colStockStatus.Name = "colStockStatus";
            colStockStatus.ReadOnly = true;
            colStockStatus.Width = 150;
            // 
            // colCreatedDate
            // 
            colCreatedDate.DataPropertyName = "CreatedDate";
            colCreatedDate.HeaderText = "CreatedDate";
            colCreatedDate.MinimumWidth = 8;
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.ReadOnly = true;
            colCreatedDate.Width = 150;
            // 
            // colUpdatedDate
            // 
            colUpdatedDate.DataPropertyName = "UpdatedDate";
            colUpdatedDate.HeaderText = "Updated Date";
            colUpdatedDate.MinimumWidth = 8;
            colUpdatedDate.Name = "colUpdatedDate";
            colUpdatedDate.ReadOnly = true;
            colUpdatedDate.Width = 150;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search Product...";
            txtSearch.Size = new Size(389, 31);
            txtSearch.TabIndex = 114;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(14, 165, 233);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRefresh.IconColor = Color.Black;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(1054, 29);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 120;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLowStock.BackColor = Color.Cornsilk;
            btnLowStock.FlatAppearance.BorderSize = 0;
            btnLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLowStock.ForeColor = Color.Peru;
            btnLowStock.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLowStock.IconColor = Color.Black;
            btnLowStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLowStock.Location = new Point(693, 29);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(138, 34);
            btnLowStock.TabIndex = 121;
            btnLowStock.Text = "LowStockh";
            btnLowStock.UseVisualStyleBackColor = false;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnOutOfStock
            // 
            btnOutOfStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnOutOfStock.BackColor = Color.LavenderBlush;
            btnOutOfStock.FlatAppearance.BorderSize = 0;
            btnOutOfStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOutOfStock.ForeColor = Color.Firebrick;
            btnOutOfStock.IconChar = FontAwesome.Sharp.IconChar.None;
            btnOutOfStock.IconColor = Color.Black;
            btnOutOfStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOutOfStock.Location = new Point(858, 29);
            btnOutOfStock.Name = "btnOutOfStock";
            btnOutOfStock.Size = new Size(165, 34);
            btnOutOfStock.TabIndex = 122;
            btnOutOfStock.Text = "OutOfStock";
            btnOutOfStock.UseVisualStyleBackColor = false;
            btnOutOfStock.Click += btnOutOfStock_Click;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.Black;
            lblLowStock.Location = new Point(90, 45);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(41, 48);
            lblLowStock.TabIndex = 123;
            lblLowStock.Text = "0";
            // 
            // lblOutOfStock
            // 
            lblOutOfStock.AutoSize = true;
            lblOutOfStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblOutOfStock.ForeColor = Color.Black;
            lblOutOfStock.Location = new Point(90, 45);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new Size(41, 48);
            lblOutOfStock.TabIndex = 124;
            lblOutOfStock.Text = "0";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.Black;
            lblTotalProducts.Location = new Point(90, 45);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(41, 48);
            lblTotalProducts.TabIndex = 125;
            lblTotalProducts.Text = "0";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInStock.ForeColor = Color.Black;
            lblInStock.Location = new Point(90, 45);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(41, 48);
            lblInStock.TabIndex = 126;
            lblInStock.Text = "0";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel6);
            pnlMain.Controls.Add(panel5);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1223, 716);
            pnlMain.TabIndex = 127;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(panel9);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 150);
            panel6.Name = "panel6";
            panel6.Size = new Size(1223, 532);
            panel6.TabIndex = 129;
            // 
            // panel11
            // 
            panel11.Controls.Add(tableLayoutPanel3);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 109);
            panel11.Name = "panel11";
            panel11.Size = new Size(1223, 423);
            panel11.TabIndex = 124;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel12, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(10, 0, 10, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1223, 423);
            tableLayoutPanel3.TabIndex = 117;
            // 
            // panel12
            // 
            panel12.Controls.Add(dgvStock);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(13, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(1197, 417);
            panel12.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(tableLayoutPanel2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1223, 109);
            panel9.TabIndex = 123;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel10, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1223, 109);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(btnOutOfStock);
            panel10.Controls.Add(btnLowStock);
            panel10.Controls.Add(btnRefresh);
            panel10.Controls.Add(txtSearch);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(13, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(1197, 93);
            panel10.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 682);
            panel5.Name = "panel5";
            panel5.Size = new Size(1223, 34);
            panel5.TabIndex = 128;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 150);
            panel1.TabIndex = 127;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel2, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlLowStock, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlCurrentStock, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlTotalProducts, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1223, 150);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(lblOutOfStock);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(925, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 130);
            panel2.TabIndex = 15;
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
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(panel8);
            pnlLowStock.Controls.Add(label17);
            pnlLowStock.Controls.Add(label18);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.ForeColor = Color.DimGray;
            pnlLowStock.Location = new Point(620, 10);
            pnlLowStock.Margin = new Padding(10);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(285, 130);
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
            pnlCurrentStock.BackColor = Color.White;
            pnlCurrentStock.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentStock.Controls.Add(panel7);
            pnlCurrentStock.Controls.Add(label15);
            pnlCurrentStock.Controls.Add(lblInStock);
            pnlCurrentStock.Controls.Add(label16);
            pnlCurrentStock.Dock = DockStyle.Fill;
            pnlCurrentStock.ForeColor = Color.DimGray;
            pnlCurrentStock.Location = new Point(315, 10);
            pnlCurrentStock.Margin = new Padding(10);
            pnlCurrentStock.Name = "pnlCurrentStock";
            pnlCurrentStock.Size = new Size(285, 130);
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label16.Location = new Point(90, 20);
            label16.Name = "label16";
            label16.Size = new Size(88, 28);
            label16.TabIndex = 1;
            label16.Text = "In Stock";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.AutoSize = true;
            pnlTotalProducts.BackColor = Color.White;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(panel4);
            pnlTotalProducts.Controls.Add(lblProductDesc);
            pnlTotalProducts.Controls.Add(lblProductsTitle);
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Dock = DockStyle.Fill;
            pnlTotalProducts.ForeColor = Color.DimGray;
            pnlTotalProducts.Location = new Point(10, 10);
            pnlTotalProducts.Margin = new Padding(10);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(285, 130);
            pnlTotalProducts.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(picProducts);
            panel4.Location = new Point(15, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 4;
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
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 716);
            Controls.Add(pnlMain);
            Name = "FrmStock";
            Text = "Master Stock";
            Load += FrmStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            pnlMain.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel11.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvStock;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnLowStock;
        private FontAwesome.Sharp.IconButton btnOutOfStock;
        private Label lblLowStock;
        private Label lblOutOfStock;
        private Label lblTotalProducts;
        private Label lblInStock;
        private Panel pnlMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label19;
        private Label label21;
        private Panel pnlLowStock;
        private Panel panel8;
        private PictureBox pictureBox6;
        private Label label17;
        private Label label18;
        private Panel pnlCurrentStock;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Label label15;
        private Label label16;
        private Panel pnlTotalProducts;
        private Panel panel4;
        private PictureBox picProducts;
        private Label lblProductDesc;
        private Label lblProductsTitle;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel10;
        private Panel panel11;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel12;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colProductCode;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colCurrentStock;
        private DataGridViewTextBoxColumn colMinimumStock;
        private DataGridViewTextBoxColumn colPurchasePrice;
        private DataGridViewTextBoxColumn colSalePrice;
        private DataGridViewTextBoxColumn colStockStatus;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colUpdatedDate;
        private DataGridViewTextBoxColumn Id;
    }
}