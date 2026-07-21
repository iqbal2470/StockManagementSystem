namespace StockManagementSystem.Forms.Brands
{
    partial class FrmBrand
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
            lblSearch = new Label();
            dgvBrand = new DataGridView();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnNew = new Button();
            txtBrandName = new TextBox();
            Lable1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBrand).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(564, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 23;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(475, 26);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 22;
            lblSearch.Text = "Search";
            // 
            // dgvBrand
            // 
            dgvBrand.AllowUserToAddRows = false;
            dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrand.Location = new Point(-1, 200);
            dgvBrand.MultiSelect = false;
            dgvBrand.Name = "dgvBrand";
            dgvBrand.RowHeadersWidth = 62;
            dgvBrand.RowTemplate.ReadOnly = true;
            dgvBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrand.Size = new Size(803, 225);
            dgvBrand.TabIndex = 21;
            dgvBrand.CellClick += dgvBrand_CellClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(564, 144);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(288, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(161, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(34, 144);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(187, 26);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(150, 31);
            txtBrandName.TabIndex = 14;
            // 
            // Lable1
            // 
            Lable1.AccessibleName = "";
            Lable1.AutoSize = true;
            Lable1.Location = new Point(34, 26);
            Lable1.Name = "Lable1";
            Lable1.Size = new Size(118, 25);
            Lable1.TabIndex = 12;
            Lable1.Text = "Brands Name";
            // 
            // FrmBrand
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvBrand);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtBrandName);
            Controls.Add(Lable1);
            Name = "FrmBrand";
            Text = "Brands Management";
            ((System.ComponentModel.ISupportInitialize)dgvBrand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvBrand;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnNew;
        private TextBox txtDescription;
        private TextBox txtBrandName;
        private Label Lable2;
        private Label Lable1;
    }
}