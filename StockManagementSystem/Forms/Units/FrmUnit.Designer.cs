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
            lblSearch = new Label();
            dgvUnit = new DataGridView();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnNew = new Button();
            txtUnitName = new TextBox();
            Lable1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUnit).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(564, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 33;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(475, 26);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 32;
            lblSearch.Text = "Search";
            // 
            // dgvUnit
            // 
            dgvUnit.AllowUserToAddRows = false;
            dgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnit.Dock = DockStyle.Bottom;
            dgvUnit.Location = new Point(0, 196);
            dgvUnit.MultiSelect = false;
            dgvUnit.Name = "dgvUnit";
            dgvUnit.RowHeadersWidth = 62;
            dgvUnit.RowTemplate.ReadOnly = true;
            dgvUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnit.Size = new Size(800, 254);
            dgvUnit.TabIndex = 31;
            dgvUnit.CellContentClick += dgvUnit_CellClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(564, 144);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(288, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(161, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(34, 144);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 26;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtUnitName
            // 
            txtUnitName.Location = new Point(187, 26);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(150, 31);
            txtUnitName.TabIndex = 25;
            // 
            // Lable1
            // 
            Lable1.AccessibleName = "";
            Lable1.AutoSize = true;
            Lable1.Location = new Point(34, 26);
            Lable1.Name = "Lable1";
            Lable1.Size = new Size(96, 25);
            Lable1.TabIndex = 24;
            Lable1.Text = "Unit Name";
            // 
            // FrmUnit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvUnit);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtUnitName);
            Controls.Add(Lable1);
            Name = "FrmUnit";
            Text = "FrmUnit";
            Load += FrmUnit_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvUnit;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnNew;
        private TextBox txtUnitName;
        private Label Lable1;
    }
}