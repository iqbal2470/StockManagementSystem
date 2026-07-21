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
            lblSearch = new Label();
            txtSearch = new TextBox();
            Lable2 = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // Lable1
            // 
            Lable1.AccessibleName = "";
            Lable1.AutoSize = true;
            Lable1.Location = new Point(35, 55);
            Lable1.Name = "Lable1";
            Lable1.Size = new Size(136, 25);
            Lable1.TabIndex = 0;
            Lable1.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(188, 55);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(150, 31);
            txtCategoryName.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(35, 173);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 4;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(162, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(289, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(423, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(565, 173);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(0, 229);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 62;
            dgvCategory.RowTemplate.ReadOnly = true;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(803, 225);
            dgvCategory.TabIndex = 9;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(476, 55);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(565, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Lable2
            // 
            Lable2.AccessibleName = "";
            Lable2.AutoSize = true;
            Lable2.Location = new Point(51, 101);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(102, 25);
            Lable2.TabIndex = 1;
            Lable2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(188, 101);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 3;
            // 
            // FrmCategory
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvCategory);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(Lable2);
            Controls.Add(Lable1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FrmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Master";
            Load += FrmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblSearch;
        private TextBox txtSearch;
        private Label Lable2;
        private TextBox txtDescription;
    }
}