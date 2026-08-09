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
            txtTotalAmount = new TextBox();
            dtpSaleDate = new DateTimePicker();
            dgvSales = new DataGridView();
            colSrNo = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            colSaleNo = new DataGridViewTextBoxColumn();
            colSaleDate = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colSalePrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colUpdatedDate = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            rtxtRemarks = new RichTextBox();
            txtQuantity = new TextBox();
            txtSalePrice = new TextBox();
            cmbProduct = new ComboBox();
            txtSaleNo = new TextBox();
            pnlMain = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel6 = new Panel();
            label20 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label11 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            pnlMain.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(849, 247);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(336, 31);
            txtTotalAmount.TabIndex = 97;
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(849, 97);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(336, 31);
            dtpSaleDate.TabIndex = 96;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { colSrNo, Id, colSaleNo, colSaleDate, colProductName, colProductId, colSalePrice, colQuantity, colTotalAmount, colRemarks, colCreatedDate, colUpdatedDate });
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new Point(0, 0);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 62;
            dgvSales.Size = new Size(1225, 260);
            dgvSales.TabIndex = 95;
            dgvSales.CellClick += dgvSales_CellClick;
            // 
            // colSrNo
            // 
            colSrNo.HeaderText = "S.No";
            colSrNo.MinimumWidth = 8;
            colSrNo.Name = "colSrNo";
            colSrNo.ReadOnly = true;
            colSrNo.Width = 150;
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
            // colSaleNo
            // 
            colSaleNo.DataPropertyName = "SaleNo";
            colSaleNo.HeaderText = "Sale No";
            colSaleNo.MinimumWidth = 8;
            colSaleNo.Name = "colSaleNo";
            colSaleNo.ReadOnly = true;
            colSaleNo.Width = 150;
            // 
            // colSaleDate
            // 
            colSaleDate.DataPropertyName = "SaleDate";
            colSaleDate.HeaderText = "Date";
            colSaleDate.MinimumWidth = 8;
            colSaleDate.Name = "colSaleDate";
            colSaleDate.ReadOnly = true;
            colSaleDate.Width = 150;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 150;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.HeaderText = "ProductId";
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Width = 150;
            // 
            // colSalePrice
            // 
            colSalePrice.DataPropertyName = "SalePrice";
            colSalePrice.HeaderText = "Price";
            colSalePrice.MinimumWidth = 8;
            colSalePrice.Name = "colSalePrice";
            colSalePrice.ReadOnly = true;
            colSalePrice.Width = 150;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Qty";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 150;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            colTotalAmount.HeaderText = "Total";
            colTotalAmount.MinimumWidth = 8;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            colTotalAmount.Width = 150;
            // 
            // colRemarks
            // 
            colRemarks.DataPropertyName = "Remarks";
            colRemarks.HeaderText = "Remarks";
            colRemarks.MinimumWidth = 8;
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            colRemarks.Width = 150;
            // 
            // colCreatedDate
            // 
            colCreatedDate.DataPropertyName = "CreatedDate";
            colCreatedDate.HeaderText = "Created Date";
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
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(765, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search Product...";
            txtSearch.Size = new Size(440, 31);
            txtSearch.TabIndex = 93;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(245, 158, 11);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(605, 244);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 34);
            btnClear.TabIndex = 92;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(412, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 91;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 197, 94);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(222, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 90;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(59, 130, 246);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(30, 244);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 89;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtRemarks
            // 
            rtxtRemarks.Location = new Point(849, 178);
            rtxtRemarks.Name = "rtxtRemarks";
            rtxtRemarks.Size = new Size(336, 31);
            rtxtRemarks.TabIndex = 88;
            rtxtRemarks.Text = "";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(444, 178);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter product quantity..";
            txtQuantity.Size = new Size(336, 31);
            txtQuantity.TabIndex = 85;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(444, 97);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.PlaceholderText = "Enter sale price...";
            txtSalePrice.Size = new Size(336, 31);
            txtSalePrice.TabIndex = 83;
            txtSalePrice.TextChanged += txtSalePrice_TextChanged;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(35, 176);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(336, 33);
            cmbProduct.TabIndex = 81;
            // 
            // txtSaleNo
            // 
            txtSaleNo.Location = new Point(35, 97);
            txtSaleNo.Name = "txtSaleNo";
            txtSaleNo.PlaceholderText = "Wait for Code...";
            txtSaleNo.ReadOnly = true;
            txtSaleNo.Size = new Size(336, 31);
            txtSaleNo.TabIndex = 78;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel3);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1253, 699);
            pnlMain.TabIndex = 99;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 370);
            panel3.TabIndex = 100;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1253, 336);
            panel5.TabIndex = 97;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1253, 336);
            tableLayoutPanel2.TabIndex = 96;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(13, 13);
            panel7.Name = "panel7";
            panel7.Size = new Size(1227, 310);
            panel7.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(dgvSales);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 48);
            panel9.Name = "panel9";
            panel9.Size = new Size(1225, 260);
            panel9.TabIndex = 76;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Azure;
            panel8.Controls.Add(label1);
            panel8.Controls.Add(txtSearch);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1225, 48);
            panel8.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 73;
            label1.Text = "Purchase Lists";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(1253, 34);
            panel4.TabIndex = 96;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 329);
            panel1.TabIndex = 99;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1253, 329);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(txtSaleNo);
            panel2.Controls.Add(txtTotalAmount);
            panel2.Controls.Add(dtpSaleDate);
            panel2.Controls.Add(cmbProduct);
            panel2.Controls.Add(txtSalePrice);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rtxtRemarks);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(13, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 303);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label20);
            panel6.Controls.Add(pictureBox3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1225, 41);
            panel6.TabIndex = 78;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label20.Location = new Point(51, 7);
            label20.Name = "label20";
            label20.Size = new Size(216, 28);
            label20.TabIndex = 1;
            label20.Text = "Purchase Information";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.back_in_store;
            pictureBox3.Location = new Point(13, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(5);
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label7.Location = new Point(439, 72);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 53;
            label7.Text = "Sale Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.Location = new Point(845, 223);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 77;
            label2.Text = "Total Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.Location = new Point(30, 70);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 42;
            label5.Text = "Sale No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.Location = new Point(844, 73);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 45;
            label6.Text = "Sale Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label8.Location = new Point(30, 147);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 47;
            label8.Text = "Product";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label11.Location = new Point(844, 152);
            label11.Name = "label11";
            label11.Size = new Size(75, 21);
            label11.TabIndex = 62;
            label11.Text = "Remarks";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label13.Location = new Point(439, 148);
            label13.Name = "label13";
            label13.Size = new Size(77, 21);
            label13.TabIndex = 57;
            label13.Text = "Quantity";
            // 
            // FrmSale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 252);
            ClientSize = new Size(1253, 699);
            Controls.Add(pnlMain);
            Name = "FrmSale";
            Text = "Master Sale";
            Load += FrmSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            pnlMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTotalAmount;
        private DateTimePicker dtpSaleDate;
        private DataGridView dgvSales;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnSave;
        private RichTextBox rtxtRemarks;
        private TextBox txtQuantity;
        private TextBox txtSalePrice;
        private ComboBox cmbProduct;
        private TextBox txtSaleNo;
        private Panel pnlMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel6;
        private Label label20;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label11;
        private Label label13;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private Label label1;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colSaleNo;
        private DataGridViewTextBoxColumn colSaleDate;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colSalePrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colRemarks;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colUpdatedDate;
    }
}