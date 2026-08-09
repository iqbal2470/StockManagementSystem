namespace StockManagementSystem.Forms.Units
{
    partial class FrmUnit
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
            txtSearch = new TextBox();
            dgvUnit = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colSrNo = new DataGridViewTextBoxColumn();
            colUnitName = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colUpdatedDate = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnNew = new Button();
            txtUnitName = new TextBox();
            pnlMain = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            tlpDesktop = new TableLayoutPanel();
            pnlInActiveBrands = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            lblInActive = new Label();
            label6 = new Label();
            pnlActiveBrand = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblActive = new Label();
            label3 = new Label();
            pnlTotalBrands = new Panel();
            panel2 = new Panel();
            picProducts = new PictureBox();
            lblProductDesc = new Label();
            lblTotalUnit = new Label();
            lblProductsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUnit).BeginInit();
            pnlMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            tlpDesktop.SuspendLayout();
            pnlInActiveBrands.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlActiveBrand.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTotalBrands.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(582, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here.....";
            txtSearch.Size = new Size(406, 31);
            txtSearch.TabIndex = 33;
            // 
            // dgvUnit
            // 
            dgvUnit.AllowUserToAddRows = false;
            dgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnit.Columns.AddRange(new DataGridViewColumn[] { Id, colSrNo, colUnitName, colStatus, colCreatedDate, colUpdatedDate });
            dgvUnit.Dock = DockStyle.Fill;
            dgvUnit.Location = new Point(0, 0);
            dgvUnit.MultiSelect = false;
            dgvUnit.Name = "dgvUnit";
            dgvUnit.ReadOnly = true;
            dgvUnit.RowHeadersWidth = 62;
            dgvUnit.RowTemplate.ReadOnly = true;
            dgvUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnit.Size = new Size(1003, 306);
            dgvUnit.TabIndex = 31;
            dgvUnit.CellClick += dgvUnit_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // colSrNo
            // 
            colSrNo.HeaderText = "#";
            colSrNo.MinimumWidth = 8;
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            // 
            // colUnitName
            // 
            colUnitName.DataPropertyName = "UnitName";
            colUnitName.HeaderText = "Unit Name";
            colUnitName.MinimumWidth = 8;
            colUnitName.Name = "colUnitName";
            colUnitName.ReadOnly = true;
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
            // btnClose
            // 
            btnClose.Location = new Point(208, 82);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(405, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(245, 158, 11);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(282, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(34, 197, 94);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(157, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.FromArgb(59, 130, 246);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(33, 10);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 26;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // txtUnitName
            // 
            txtUnitName.BorderStyle = BorderStyle.FixedSingle;
            txtUnitName.Location = new Point(138, 10);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.PlaceholderText = "Enter unit name..";
            txtUnitName.Size = new Size(311, 31);
            txtUnitName.TabIndex = 25;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(tableLayoutPanel2);
            pnlMain.Controls.Add(panel4);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1031, 626);
            pnlMain.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel9, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 234);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1031, 392);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(13, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(1005, 376);
            panel9.TabIndex = 36;
            // 
            // panel11
            // 
            panel11.Controls.Add(dgvUnit);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 68);
            panel11.Name = "panel11";
            panel11.Size = new Size(1003, 306);
            panel11.TabIndex = 35;
            // 
            // panel10
            // 
            panel10.BackColor = Color.AliceBlue;
            panel10.Controls.Add(label5);
            panel10.Controls.Add(txtSearch);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1003, 68);
            panel10.TabIndex = 34;
            // 
            // label5
            // 
            label5.AccessibleName = "";
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(24, 21);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 25;
            label5.Text = "Master Brands List";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 150);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(1031, 84);
            panel4.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1021, 74);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(10, 10);
            panel6.Margin = new Padding(10);
            panel6.Name = "panel6";
            panel6.Size = new Size(1001, 54);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnNew);
            panel7.Controls.Add(btnSave);
            panel7.Controls.Add(btnUpdate);
            panel7.Controls.Add(btnDelete);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(469, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(530, 52);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Controls.Add(txtUnitName);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(469, 52);
            panel8.TabIndex = 0;
            // 
            // label2
            // 
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(22, 12);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 12;
            label2.Text = "Unit Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(tlpDesktop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 150);
            panel1.TabIndex = 34;
            // 
            // tlpDesktop
            // 
            tlpDesktop.ColumnCount = 3;
            tlpDesktop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpDesktop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpDesktop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpDesktop.Controls.Add(pnlInActiveBrands, 2, 0);
            tlpDesktop.Controls.Add(pnlActiveBrand, 1, 0);
            tlpDesktop.Controls.Add(pnlTotalBrands, 0, 0);
            tlpDesktop.Dock = DockStyle.Fill;
            tlpDesktop.Location = new Point(0, 0);
            tlpDesktop.Name = "tlpDesktop";
            tlpDesktop.RowCount = 1;
            tlpDesktop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDesktop.Size = new Size(1031, 150);
            tlpDesktop.TabIndex = 1;
            // 
            // pnlInActiveBrands
            // 
            pnlInActiveBrands.AutoSize = true;
            pnlInActiveBrands.BackColor = Color.White;
            pnlInActiveBrands.BorderStyle = BorderStyle.FixedSingle;
            pnlInActiveBrands.Controls.Add(panel5);
            pnlInActiveBrands.Controls.Add(label4);
            pnlInActiveBrands.Controls.Add(lblInActive);
            pnlInActiveBrands.Controls.Add(label6);
            pnlInActiveBrands.Controls.Add(btnClose);
            pnlInActiveBrands.Dock = DockStyle.Fill;
            pnlInActiveBrands.ForeColor = Color.DimGray;
            pnlInActiveBrands.Location = new Point(696, 10);
            pnlInActiveBrands.Margin = new Padding(10);
            pnlInActiveBrands.Name = "pnlInActiveBrands";
            pnlInActiveBrands.Size = new Size(325, 130);
            pnlInActiveBrands.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(15, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 55);
            panel5.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LavenderBlush;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.cancel;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10);
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(90, 91);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 3;
            label4.Text = "InActive";
            // 
            // lblInActive
            // 
            lblInActive.AutoSize = true;
            lblInActive.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInActive.ForeColor = Color.Black;
            lblInActive.Location = new Point(90, 45);
            lblInActive.Name = "lblInActive";
            lblInActive.Size = new Size(41, 48);
            lblInActive.TabIndex = 2;
            lblInActive.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(90, 20);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 1;
            label6.Text = "InActive Unit";
            // 
            // pnlActiveBrand
            // 
            pnlActiveBrand.AutoSize = true;
            pnlActiveBrand.BackColor = Color.White;
            pnlActiveBrand.BorderStyle = BorderStyle.FixedSingle;
            pnlActiveBrand.Controls.Add(panel3);
            pnlActiveBrand.Controls.Add(label1);
            pnlActiveBrand.Controls.Add(lblActive);
            pnlActiveBrand.Controls.Add(label3);
            pnlActiveBrand.Dock = DockStyle.Fill;
            pnlActiveBrand.ForeColor = Color.DimGray;
            pnlActiveBrand.Location = new Point(353, 10);
            pnlActiveBrand.Margin = new Padding(10);
            pnlActiveBrand.Name = "pnlActiveBrand";
            pnlActiveBrand.Size = new Size(323, 130);
            pnlActiveBrand.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(15, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Honeydew;
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
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActive.ForeColor = Color.Black;
            lblActive.Location = new Point(90, 45);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(41, 48);
            lblActive.TabIndex = 2;
            lblActive.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(90, 20);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 1;
            label3.Text = "Active Unit";
            // 
            // pnlTotalBrands
            // 
            pnlTotalBrands.AutoSize = true;
            pnlTotalBrands.BackColor = Color.White;
            pnlTotalBrands.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalBrands.Controls.Add(panel2);
            pnlTotalBrands.Controls.Add(lblProductDesc);
            pnlTotalBrands.Controls.Add(lblTotalUnit);
            pnlTotalBrands.Controls.Add(lblProductsTitle);
            pnlTotalBrands.Dock = DockStyle.Fill;
            pnlTotalBrands.ForeColor = Color.DimGray;
            pnlTotalBrands.Location = new Point(10, 10);
            pnlTotalBrands.Margin = new Padding(10);
            pnlTotalBrands.Name = "pnlTotalBrands";
            pnlTotalBrands.Size = new Size(323, 130);
            pnlTotalBrands.TabIndex = 1;
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
            picProducts.Image = Properties.Resources.brand;
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
            lblProductDesc.Size = new Size(77, 25);
            lblProductDesc.TabIndex = 3;
            lblProductDesc.Text = "All Units";
            // 
            // lblTotalUnit
            // 
            lblTotalUnit.AutoSize = true;
            lblTotalUnit.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalUnit.ForeColor = Color.Black;
            lblTotalUnit.Location = new Point(90, 45);
            lblTotalUnit.Name = "lblTotalUnit";
            lblTotalUnit.Size = new Size(41, 48);
            lblTotalUnit.TabIndex = 2;
            lblTotalUnit.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductsTitle.Location = new Point(90, 20);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(114, 28);
            lblProductsTitle.TabIndex = 1;
            lblProductsTitle.Text = "Total Units";
            // 
            // FrmUnit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 252);
            ClientSize = new Size(1031, 626);
            Controls.Add(pnlMain);
            Name = "FrmUnit";
            Text = "Master Unit";
            Load += FrmUnit_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnit).EndInit();
            pnlMain.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            tlpDesktop.ResumeLayout(false);
            tlpDesktop.PerformLayout();
            pnlInActiveBrands.ResumeLayout(false);
            pnlInActiveBrands.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlActiveBrand.ResumeLayout(false);
            pnlActiveBrand.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTotalBrands.ResumeLayout(false);
            pnlTotalBrands.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvUnit;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnNew;
        private TextBox txtUnitName;
        private Panel pnlMain;
        private Panel panel1;
        private TableLayoutPanel tlpDesktop;
        private Panel pnlInActiveBrands;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label4;
        private Label lblInActive;
        private Label label6;
        private Panel pnlActiveBrand;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblActive;
        private Label label3;
        private Panel pnlTotalBrands;
        private Panel panel2;
        private PictureBox picProducts;
        private Label lblProductDesc;
        private Label lblTotalUnit;
        private Label lblProductsTitle;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colUnitName;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colUpdatedDate;
    }
}