namespace StockManagementSystem.Forms.Categories
{
    partial class FrmCategory
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
            Lable1 = new Label();
            txtCategoryName = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvCategory = new DataGridView();
            colSrNo = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colUpdatedDate = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            Lable2 = new Label();
            pnlMain = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            label8 = new Label();
            pnlEntryFields = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnHeroSection = new Panel();
            txtDescription = new RichTextBox();
            pnlCards = new Panel();
            tblDashboardCards = new TableLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblInActiveCategories = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblActiveCategories = new Label();
            label7 = new Label();
            pnlTotalProducts = new Panel();
            panel2 = new Panel();
            picProducts = new PictureBox();
            lblProductDesc = new Label();
            lblTotalCategory = new Label();
            lblProductsTitle = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblInActiveCategory = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox10 = new PictureBox();
            label2 = new Label();
            lblActiveCategory = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            pnlMain.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            pnlEntryFields.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnHeroSection.SuspendLayout();
            pnlCards.SuspendLayout();
            tblDashboardCards.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTotalProducts.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // Lable1
            // 
            Lable1.AccessibleName = "";
            Lable1.AutoSize = true;
            Lable1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lable1.Location = new Point(16, 6);
            Lable1.Name = "Lable1";
            Lable1.Size = new Size(145, 25);
            Lable1.TabIndex = 0;
            Lable1.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(17, 35);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = " Enter category name..";
            txtCategoryName.Size = new Size(355, 31);
            txtCategoryName.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.FromArgb(59, 130, 246);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(815, 63);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(34, 197, 94);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(933, 63);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(245, 158, 11);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1051, 63);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1169, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(933, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor = SystemColors.ButtonShadow;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { colSrNo, colCategoryName, colDescription, colStatus, colCreatedDate, colUpdatedDate, colEdit, colDelete });
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.GridColor = SystemColors.MenuBar;
            dgvCategory.Location = new Point(0, 0);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 62;
            dgvCategory.RowTemplate.ReadOnly = true;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(1307, 335);
            dgvCategory.TabIndex = 9;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // colSrNo
            // 
            colSrNo.HeaderText = "#";
            colSrNo.MinimumWidth = 8;
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            // 
            // colCategoryName
            // 
            colCategoryName.DataPropertyName = "CategoryName";
            colCategoryName.HeaderText = "Category Name";
            colCategoryName.MinimumWidth = 8;
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "CategoryDescription";
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 8;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "IsActive";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colCreatedDate
            // 
            colCreatedDate.DataPropertyName = "CreatedDate";
            colCreatedDate.HeaderText = "CreatedDate";
            colCreatedDate.MinimumWidth = 8;
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.ReadOnly = true;
            // 
            // colUpdatedDate
            // 
            colUpdatedDate.DataPropertyName = "UpdatedDate";
            colUpdatedDate.HeaderText = "UpdatedDate";
            colUpdatedDate.MinimumWidth = 8;
            colUpdatedDate.Name = "colUpdatedDate";
            colUpdatedDate.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(921, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search here....";
            txtSearch.Size = new Size(376, 31);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Lable2
            // 
            Lable2.AccessibleName = "";
            Lable2.AutoSize = true;
            Lable2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lable2.Location = new Point(372, 5);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(109, 25);
            Lable2.TabIndex = 1;
            Lable2.Text = "Description";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(236, 241, 252);
            pnlMain.Controls.Add(panel9);
            pnlMain.Controls.Add(panel8);
            pnlMain.Controls.Add(pnlEntryFields);
            pnlMain.Controls.Add(pnlCards);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(5, 5, 5, 20);
            pnlMain.Size = new Size(1317, 690);
            pnlMain.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.Controls.Add(dgvCategory);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(5, 335);
            panel9.Name = "panel9";
            panel9.Size = new Size(1307, 335);
            panel9.TabIndex = 15;
            // 
            // panel8
            // 
            panel8.BackColor = Color.AliceBlue;
            panel8.Controls.Add(label8);
            panel8.Controls.Add(txtSearch);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(5, 281);
            panel8.Name = "panel8";
            panel8.Size = new Size(1307, 54);
            panel8.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(10, 12);
            label8.Name = "label8";
            label8.Size = new Size(124, 30);
            label8.TabIndex = 12;
            label8.Text = "Categories";
            // 
            // pnlEntryFields
            // 
            pnlEntryFields.Controls.Add(tableLayoutPanel1);
            pnlEntryFields.Dock = DockStyle.Top;
            pnlEntryFields.Location = new Point(5, 156);
            pnlEntryFields.Name = "pnlEntryFields";
            pnlEntryFields.Size = new Size(1307, 125);
            pnlEntryFields.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006218F));
            tableLayoutPanel1.Controls.Add(pnHeroSection, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1307, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnHeroSection
            // 
            pnHeroSection.BackColor = Color.White;
            pnHeroSection.BorderStyle = BorderStyle.FixedSingle;
            pnHeroSection.Controls.Add(txtDescription);
            pnHeroSection.Controls.Add(txtCategoryName);
            pnHeroSection.Controls.Add(Lable1);
            pnHeroSection.Controls.Add(Lable2);
            pnHeroSection.Controls.Add(btnDelete);
            pnHeroSection.Controls.Add(btnClose);
            pnHeroSection.Controls.Add(btnSave);
            pnHeroSection.Controls.Add(btnUpdate);
            pnHeroSection.Controls.Add(btnNew);
            pnHeroSection.Dock = DockStyle.Fill;
            pnHeroSection.Location = new Point(8, 8);
            pnHeroSection.Name = "pnHeroSection";
            pnHeroSection.Padding = new Padding(5);
            pnHeroSection.Size = new Size(1291, 109);
            pnHeroSection.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(378, 35);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(409, 62);
            txtDescription.TabIndex = 9;
            txtDescription.Text = "";
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(tblDashboardCards);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(5, 5);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(1307, 151);
            pnlCards.TabIndex = 12;
            // 
            // tblDashboardCards
            // 
            tblDashboardCards.ColumnCount = 3;
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.Controls.Add(panel6, 2, 0);
            tblDashboardCards.Controls.Add(panel1, 1, 0);
            tblDashboardCards.Controls.Add(pnlTotalProducts, 0, 0);
            tblDashboardCards.Dock = DockStyle.Fill;
            tblDashboardCards.Location = new Point(0, 0);
            tblDashboardCards.Name = "tblDashboardCards";
            tblDashboardCards.RowCount = 1;
            tblDashboardCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboardCards.Size = new Size(1307, 151);
            tblDashboardCards.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(lblInActiveCategories);
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Fill;
            panel6.ForeColor = Color.DimGray;
            panel6.Location = new Point(880, 10);
            panel6.Margin = new Padding(10);
            panel6.Name = "panel6";
            panel6.Size = new Size(417, 131);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(15, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(55, 55);
            panel7.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LavenderBlush;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.cancel;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(10);
            pictureBox3.Size = new Size(55, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(90, 91);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 3;
            label5.Text = "InActive";
            // 
            // lblInActiveCategories
            // 
            lblInActiveCategories.AutoSize = true;
            lblInActiveCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInActiveCategories.ForeColor = Color.Black;
            lblInActiveCategories.Location = new Point(90, 45);
            lblInActiveCategories.Name = "lblInActiveCategories";
            lblInActiveCategories.Size = new Size(41, 48);
            lblInActiveCategories.TabIndex = 2;
            lblInActiveCategories.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(90, 20);
            label9.Name = "label9";
            label9.Size = new Size(196, 28);
            label9.TabIndex = 1;
            label9.Text = "InActive Categories";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblActiveCategories);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(445, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 131);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(15, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 55);
            panel5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Azure;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.verified;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(90, 91);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 3;
            label1.Text = "Active";
            // 
            // lblActiveCategories
            // 
            lblActiveCategories.AutoSize = true;
            lblActiveCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActiveCategories.ForeColor = Color.Black;
            lblActiveCategories.Location = new Point(90, 45);
            lblActiveCategories.Name = "lblActiveCategories";
            lblActiveCategories.Size = new Size(41, 48);
            lblActiveCategories.TabIndex = 2;
            lblActiveCategories.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(90, 20);
            label7.Name = "label7";
            label7.Size = new Size(178, 28);
            label7.TabIndex = 1;
            label7.Text = "Active Categories";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.AutoSize = true;
            pnlTotalProducts.BackColor = Color.White;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(panel2);
            pnlTotalProducts.Controls.Add(lblProductDesc);
            pnlTotalProducts.Controls.Add(lblTotalCategory);
            pnlTotalProducts.Controls.Add(lblProductsTitle);
            pnlTotalProducts.Dock = DockStyle.Fill;
            pnlTotalProducts.ForeColor = Color.DimGray;
            pnlTotalProducts.Location = new Point(10, 10);
            pnlTotalProducts.Margin = new Padding(10);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(415, 131);
            pnlTotalProducts.TabIndex = 0;
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
            picProducts.Image = Properties.Resources.list;
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
            lblProductDesc.Size = new Size(121, 25);
            lblProductDesc.TabIndex = 3;
            lblProductDesc.Text = "All Categories";
            // 
            // lblTotalCategory
            // 
            lblTotalCategory.AutoSize = true;
            lblTotalCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCategory.ForeColor = Color.Black;
            lblTotalCategory.Location = new Point(90, 45);
            lblTotalCategory.Name = "lblTotalCategory";
            lblTotalCategory.Size = new Size(41, 48);
            lblTotalCategory.TabIndex = 2;
            lblTotalCategory.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductsTitle.Location = new Point(90, 20);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(165, 28);
            lblProductsTitle.TabIndex = 1;
            lblProductsTitle.Text = "Total Categories";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(15, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lavender;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.pencil_and_ruler;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10);
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(90, 91);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 3;
            label3.Text = "Inactive";
            // 
            // lblInActiveCategory
            // 
            lblInActiveCategory.AutoSize = true;
            lblInActiveCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInActiveCategory.ForeColor = Color.Black;
            lblInActiveCategory.Location = new Point(90, 45);
            lblInActiveCategory.Name = "lblInActiveCategory";
            lblInActiveCategory.Size = new Size(41, 48);
            lblInActiveCategory.TabIndex = 2;
            lblInActiveCategory.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(90, 20);
            label6.Name = "label6";
            label6.Size = new Size(196, 28);
            label6.TabIndex = 1;
            label6.Text = "InActive Categories";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox10);
            panel3.Location = new Point(15, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 5;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Dock = DockStyle.Fill;
            pictureBox10.Image = Properties.Resources.list;
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Padding = new Padding(10);
            pictureBox10.Size = new Size(55, 55);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(90, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Active";
            // 
            // lblActiveCategory
            // 
            lblActiveCategory.AutoSize = true;
            lblActiveCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActiveCategory.ForeColor = Color.Black;
            lblActiveCategory.Location = new Point(90, 45);
            lblActiveCategory.Name = "lblActiveCategory";
            lblActiveCategory.Size = new Size(41, 48);
            lblActiveCategory.TabIndex = 2;
            lblActiveCategory.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(90, 20);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 1;
            label4.Text = "Active Categories";
            // 
            // FrmCategory
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 252);
            ClientSize = new Size(1317, 690);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FrmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Master";
            Load += FrmCategory_Load;
            Resize += FrmCategory_Resize;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            pnlMain.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pnlEntryFields.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnHeroSection.ResumeLayout(false);
            pnHeroSection.PerformLayout();
            pnlCards.ResumeLayout(false);
            tblDashboardCards.ResumeLayout(false);
            tblDashboardCards.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Lable1;
        private TextBox txtCategoryName;
        private Button btnNew;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvCategory;
        private TextBox txtSearch;
        private Label Lable2;
        private Panel pnlMain;
        private Panel pnlCards;
        private TableLayoutPanel tblDashboardCards;
       
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label lblTotalUnits;
        private Label label6;
        private Label lblInActiveCategory;
        private Label lblActiveCategory;
        private Panel panel3;
        private PictureBox pictureBox10;
        private Label label2;
        private Label lblTotalCategories;
        private Label label4;
        private Panel pnlTotalProducts;
        private Panel panel2;
        private PictureBox picProducts;
        private Label lblProductDesc;
        private Label lblTotalCategory;
        private Label lblProductsTitle;
        private Panel pnlTable;
        private Panel panel1;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblActiveCategories;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Label label5;
        private Label lblInActiveCategories;
        private Label label9;
        private Panel pnlEntryFields;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnHeroSection;
        private RichTextBox txtDescription;
        private Panel panel9;
        private Panel panel8;
        private Label label8;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colUpdatedDate;
        private DataGridViewTextBoxColumn colEdit;
        private DataGridViewTextBoxColumn colDelete;
    }
}