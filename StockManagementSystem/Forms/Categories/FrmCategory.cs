using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.CategoryServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StockManagementSystem.Forms.Categories
{
    public partial class FrmCategory : BaseForm
    {
        private readonly ICategoryService _categoryService;
        private int _selectedCategoryId = 0;
        public FrmCategory(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            txtCategoryName.KeyDown += Control_KeyDown;
            txtDescription.KeyDown += Control_KeyDown;
            txtSearch.KeyDown += Control_KeyDown;

            dgvCategory.RowPostPaint += dgvCategory_RowPostPaint;
            dgvCategory.CellFormatting += dgvCategory_CellFormatting;
        }
        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCategory.Columns[e.ColumnIndex].Name == "colStatus")
            {
                if (e.Value != null)
                {
                    bool status = Convert.ToBoolean(e.Value);
                    e.Value = status ? "Active" : "Inactive";
                    e.FormattingApplied = true;
                }
            }

            if (dgvCategory.Columns[e.ColumnIndex].Name == "colCreatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy");
                    e.FormattingApplied = true;
                }
            }

            if (dgvCategory.Columns[e.ColumnIndex].Name == "colUpdatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy");
                    e.FormattingApplied = true;
                }
            }
        }
        private void dgvCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCategory.Rows[e.RowIndex].Cells["colSrNo"].Value = (e.RowIndex + 1).ToString();
        }
        private async void FrmCategory_Load(object sender, EventArgs e)
        {
            await LoadCategories();

            await LoadDashboardCards();

            SetAddMode();


            //        dgvCategory.EnableHeadersVisualStyles = false;

            //        dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            //        dgvCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            //        dgvCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            //        dgvCategory.ColumnHeadersHeight = 50;
            //        dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            //        dgvCategory.DefaultCellStyle.Font =
            //new Font("Segoe UI", 10);

            //        dgvCategory.DefaultCellStyle.ForeColor =
            //            Color.FromArgb(40, 40, 40);

            //        dgvCategory.DefaultCellStyle.BackColor =
            //            Color.White;

            //        dgvCategory.DefaultCellStyle.SelectionBackColor =
            //            Color.FromArgb(235, 243, 255);

            //        dgvCategory.DefaultCellStyle.SelectionForeColor =
            //            Color.Black;

            //        dgvCategory.RowTemplate.Height = 65;

            //        dgvCategory.GridColor =
            //            Color.Gainsboro;

            //        dgvCategory.CellBorderStyle =
            //            DataGridViewCellBorderStyle.SingleHorizontal;
        }
        private async Task LoadCategories()
        {
            dgvCategory.DataSource = await _categoryService.GetAllAsync();
            dgvCategory.AutoGenerateColumns = false;
            FormatGrid();
        }

        private async Task LoadDashboardCards()
        {
            var categories = await _categoryService.GetAllAsync();

            // Total Categories
            lblTotalCategory.Text = categories.Count.ToString();

            // Active Categories
            lblActiveCategories.Text = categories.Count(x => x.IsActive).ToString();

            // Inactive Categories
            lblInActiveCategories.Text = categories.Count(x => !x.IsActive).ToString();
        }

        //private void FormatGrid()
        //{
        //    dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvCategory.MultiSelect = false;
        //    dgvCategory.ReadOnly = true;
        //    dgvCategory.AllowUserToAddRows = false;
        //    dgvCategory.AllowUserToDeleteRows = false;
        //    dgvCategory.RowHeadersVisible = false;

        //    dgvCategory.Columns["Id"].Visible = false;
        //    dgvCategory.Columns["CreatedDate"].Visible = false;
        //    dgvCategory.Columns["UpdatedDate"].Visible = false;
        //    dgvCategory.Columns["IsDeleted"].Visible = false;

        //    dgvCategory.Columns["CategoryName"].HeaderText = "Category";
        //    dgvCategory.Columns["CategoryDescription"].HeaderText = "Description";
        //    dgvCategory.Columns["IsActive"].HeaderText = "Active";
        //}
        private void FormatGrid()
        {
            dgvCategory.AutoGenerateColumns = false;

            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.MultiSelect = false;
            dgvCategory.ReadOnly = true;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeRows = false;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hide Id
            //dgvCategory.Columns["colId"].Visible = false; 
            dgvCategory.Columns["Id"].Visible = false;
            // Header Text
            dgvCategory.Columns["colSrNo"].HeaderText = "#";
            dgvCategory.Columns["colCategoryName"].HeaderText = "Category Name";
            dgvCategory.Columns["colDescription"].HeaderText = "Description";
            dgvCategory.Columns["colStatus"].HeaderText = "Status";
            dgvCategory.Columns["colCreatedDate"].HeaderText = "Created Date";
            dgvCategory.Columns["colUpdatedDate"].HeaderText = "Updated Date";
            dgvCategory.Columns["colEdit"].Visible=false;
            dgvCategory.Columns["colDelete"].Visible=false;

            // Width
            dgvCategory.Columns["colSrNo"].FillWeight = 40;
            dgvCategory.Columns["colCategoryName"].FillWeight = 180;
            dgvCategory.Columns["colDescription"].FillWeight = 250;
            dgvCategory.Columns["colStatus"].FillWeight = 90;
            dgvCategory.Columns["colCreatedDate"].FillWeight = 120;
            dgvCategory.Columns["colUpdatedDate"].FillWeight = 120;
            dgvCategory.Columns["colEdit"].FillWeight = 70;
            dgvCategory.Columns["colDelete"].FillWeight = 70;

            // Design
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvCategory.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCategory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            dgvCategory.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCategory.ColumnHeadersHeight = 45;
            dgvCategory.RowTemplate.Height = 40;

            dgvCategory.GridColor = Color.Gainsboro;
            dgvCategory.BorderStyle = BorderStyle.None;
        }
        private bool ValidateCategory()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter Category Name.");

                txtCategoryName.Focus();

                return false;
            }

            if (txtCategoryName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Category Name must be at least 3 characters.");

                txtCategoryName.Focus();

                return false;
            }

            return true;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId > 0)
            {
                MessageBox.Show(
                    "Category already selected. Please click New before saving a new category.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (!ValidateCategory())
                return;

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter Category Name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            Category category = new Category
            {
                CategoryName = txtCategoryName.Text.Trim(),
                CategoryDescription = txtDescription.Text.Trim(),
                IsActive = true
            };

            await _categoryService.AddAsync(category);

            MessageBox.Show("Category saved successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtCategoryName.Clear();
            txtDescription.Clear();

            SetAddMode();

            txtCategoryName.Focus();

            await LoadCategories();

            await LoadDashboardCards();
        }

        //private async void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (_selectedCategoryId == 0)
        //    {
        //        MessageBox.Show("Please select a category.");
        //        return;
        //    }

        //    Category category = await _categoryService.GetByIdAsync(_selectedCategoryId);

        //    if (category != null)
        //    {
        //        category.CategoryName = txtCategoryName.Text.Trim();
        //        category.CategoryDescription = txtDescription.Text.Trim();

        //        await _categoryService.UpdateAsync(category);

        //        MessageBox.Show("Category updated successfully.");

        //        await LoadCategories();

        //        txtCategoryName.Clear();
        //        txtDescription.Clear();

        //        _selectedCategoryId = 0;
        //    }
        //}

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];

                _selectedCategoryId = Convert.ToInt32(row.Cells["Id"].Value);
                SetEditMode();

                txtCategoryName.Text = row.Cells["colCategoryName"].Value?.ToString();
                txtDescription.Text = row.Cells["colDescription"].Value?.ToString();
            }
        }

        private void SetAddMode()
        {
            btnSave.Enabled = true;

            btnUpdate.Enabled = false;

            btnDelete.Enabled = false;

            _selectedCategoryId = 0;
        }

        private void SetEditMode()
        {
            btnSave.Enabled = false;

            btnUpdate.Enabled = true;

            btnDelete.Enabled = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            if (!ValidateCategory())
                return;

            Category category = await _categoryService.GetByIdAsync(_selectedCategoryId);

            if (category != null)
            {
                category.CategoryName = txtCategoryName.Text.Trim();
                category.CategoryDescription = txtDescription.Text.Trim();
                category.UpdatedDate = DateTime.Now;
                await _categoryService.UpdateAsync(category);

                MessageBox.Show("Category updated successfully.");

                await LoadCategories();

                txtCategoryName.Clear();
                txtDescription.Clear();

                SetAddMode();


                _selectedCategoryId = 0;
            }

            await LoadDashboardCards();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _categoryService.DeleteAsync(_selectedCategoryId);

                MessageBox.Show("Category deleted successfully.");

                await LoadCategories();

                txtCategoryName.Clear();
                txtDescription.Clear();

                SetAddMode();


                _selectedCategoryId = 0;
            }

            await LoadDashboardCards();
        }

        //private void btnNew_Click(object sender, EventArgs e)
        //{

        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
            txtDescription.Clear();

            _selectedCategoryId = 0;

            SetAddMode();

            txtCategoryName.Focus();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var categories = await _categoryService.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                categories = categories
                    .Where(x => x.CategoryName.Contains(txtSearch.Text,
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvCategory.DataSource = categories;

            FormatGrid();
        }


        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void FrmCategory_Resize(object sender, EventArgs e)
        {
            pnHeroSection.Left = (this.ClientSize.Width - pnHeroSection.Width) / 2;
            pnHeroSection.Top = (this.ClientSize.Height - pnHeroSection.Height) / 2;
        }
    }
}
