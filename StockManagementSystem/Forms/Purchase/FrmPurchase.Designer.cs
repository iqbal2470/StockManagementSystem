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
            pnlMain = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel6 = new Panel();
            label20 = new Label();
            pictureBox3 = new PictureBox();
            Id = new DataGridViewTextBoxColumn();
            colSrNo = new DataGridViewTextBoxColumn();
            colPurchaseNo = new DataGridViewTextBoxColumn();
            colPurchaseDate = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPurchasePrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colCreatedDate = new DataGridViewTextBoxColumn();
            colUpdatedDate = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).BeginInit();
            pnlMain.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvPurchases
            // 
            dgvPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchases.Columns.AddRange(new DataGridViewColumn[] { Id, colSrNo, colPurchaseNo, colPurchaseDate, colProductId, colProductName, colPurchasePrice, colQuantity, colTotalAmount, colCreatedDate, colUpdatedDate, colRemarks });
            dgvPurchases.Dock = DockStyle.Fill;
            dgvPurchases.Location = new Point(0, 0);
            dgvPurchases.Name = "dgvPurchases";
            dgvPurchases.RowHeadersWidth = 62;
            dgvPurchases.Size = new Size(1225, 342);
            dgvPurchases.TabIndex = 74;
            dgvPurchases.CellClick += dgvPurchases_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(813, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search Product...";
            txtSearch.Size = new Size(397, 31);
            txtSearch.TabIndex = 72;
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
            btnClear.TabIndex = 71;
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
            btnDelete.Location = new Point(415, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 34);
            btnDelete.TabIndex = 70;
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
            btnUpdate.Location = new Point(223, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 34);
            btnUpdate.TabIndex = 69;
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
            btnSave.Location = new Point(35, 244);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 34);
            btnSave.TabIndex = 68;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // rtxtRemarks
            // 
            rtxtRemarks.Location = new Point(849, 176);
            rtxtRemarks.Name = "rtxtRemarks";
            rtxtRemarks.Size = new Size(336, 31);
            rtxtRemarks.TabIndex = 63;
            rtxtRemarks.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label12.Location = new Point(844, 152);
            label12.Name = "label12";
            label12.Size = new Size(75, 21);
            label12.TabIndex = 62;
            label12.Text = "Remarks";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label9.Location = new Point(439, 148);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 57;
            label9.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(444, 174);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter quantity...";
            txtQuantity.Size = new Size(336, 31);
            txtQuantity.TabIndex = 56;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label7.Location = new Point(439, 72);
            label7.Name = "label7";
            label7.Size = new Size(121, 21);
            label7.TabIndex = 53;
            label7.Text = "Purchase Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.Location = new Point(30, 147);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 47;
            label4.Text = "Product";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(35, 173);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(336, 33);
            cmbProduct.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.Location = new Point(845, 85);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 45;
            label3.Text = "Purchase Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 42;
            label1.Text = "Purchage No";
            // 
            // txtPurchaseNo
            // 
            txtPurchaseNo.Location = new Point(35, 97);
            txtPurchaseNo.Name = "txtPurchaseNo";
            txtPurchaseNo.PlaceholderText = "Wait for Code...";
            txtPurchaseNo.ReadOnly = true;
            txtPurchaseNo.Size = new Size(336, 31);
            txtPurchaseNo.TabIndex = 40;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(849, 110);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(336, 31);
            dtpPurchaseDate.TabIndex = 75;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(444, 97);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.PlaceholderText = "Enter purchase price...";
            txtPurchasePrice.Size = new Size(336, 31);
            txtPurchasePrice.TabIndex = 52;
            txtPurchasePrice.TextChanged += txtPurchasePrice_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label10.Location = new Point(845, 223);
            label10.Name = "label10";
            label10.Size = new Size(114, 21);
            label10.TabIndex = 77;
            label10.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(849, 247);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(336, 31);
            txtTotalAmount.TabIndex = 76;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel3);
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1253, 801);
            pnlMain.TabIndex = 78;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 452);
            panel3.TabIndex = 79;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel2);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1253, 418);
            panel7.TabIndex = 77;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1253, 418);
            tableLayoutPanel2.TabIndex = 75;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(13, 13);
            panel5.Name = "panel5";
            panel5.Size = new Size(1227, 392);
            panel5.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(dgvPurchases);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 48);
            panel9.Name = "panel9";
            panel9.Size = new Size(1225, 342);
            panel9.TabIndex = 76;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Azure;
            panel8.Controls.Add(label2);
            panel8.Controls.Add(txtSearch);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1225, 48);
            panel8.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(13, 7);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 73;
            label2.Text = "Purchase Lists";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(1253, 34);
            panel4.TabIndex = 76;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 349);
            panel1.TabIndex = 78;
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
            tableLayoutPanel1.Size = new Size(1253, 349);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(txtPurchasePrice);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(txtPurchaseNo);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTotalAmount);
            panel2.Controls.Add(cmbProduct);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rtxtRemarks);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dtpPurchaseDate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(13, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 323);
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
            // colPurchaseNo
            // 
            colPurchaseNo.DataPropertyName = "PurchaseNo";
            colPurchaseNo.HeaderText = "Purchase No";
            colPurchaseNo.MinimumWidth = 8;
            colPurchaseNo.Name = "colPurchaseNo";
            colPurchaseNo.ReadOnly = true;
            colPurchaseNo.Width = 150;
            // 
            // colPurchaseDate
            // 
            colPurchaseDate.DataPropertyName = "PurchaseDate";
            colPurchaseDate.HeaderText = "Date";
            colPurchaseDate.MinimumWidth = 8;
            colPurchaseDate.Name = "colPurchaseDate";
            colPurchaseDate.ReadOnly = true;
            colPurchaseDate.Width = 150;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.HeaderText = "Product Id";
            colProductId.MinimumWidth = 8;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Width = 150;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 8;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 150;
            // 
            // colPurchasePrice
            // 
            colPurchasePrice.DataPropertyName = "PurchasePrice";
            colPurchasePrice.HeaderText = "Price";
            colPurchasePrice.MinimumWidth = 8;
            colPurchasePrice.Name = "colPurchasePrice";
            colPurchasePrice.ReadOnly = true;
            colPurchasePrice.Width = 150;
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
            // colRemarks
            // 
            colRemarks.DataPropertyName = "Remarks";
            colRemarks.HeaderText = "Remarks";
            colRemarks.MinimumWidth = 8;
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            colRemarks.Width = 150;
            // 
            // FrmPurchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 801);
            Controls.Add(pnlMain);
            Name = "FrmPurchase";
            Text = "Purchase Master";
            Load += FrmPurchase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPurchases).EndInit();
            pnlMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
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

        private DataGridView dgvPurchases;
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
        private Panel pnlMain;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel6;
        private Label label20;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Panel panel5;
        private Panel panel8;
        private Label label2;
        private Panel panel9;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colSrNo;
        private DataGridViewTextBoxColumn colPurchaseNo;
        private DataGridViewTextBoxColumn colPurchaseDate;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPurchasePrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colCreatedDate;
        private DataGridViewTextBoxColumn colUpdatedDate;
        private DataGridViewTextBoxColumn colRemarks;
    }
}