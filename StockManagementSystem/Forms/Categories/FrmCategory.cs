using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.CategoryServices;
namespace StockManagementSystem.Forms.Categories
{
    public partial class FrmCategory : Form
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
        }

        private async void FrmCategory_Load(object sender, EventArgs e)
        {
            await LoadCategories();
        }
        private async Task LoadCategories()
        {
            dgvCategory.DataSource = await _categoryService.GetAllAsync();
            FormatGrid();
        }

        private void FormatGrid()
        {
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.MultiSelect = false;
            dgvCategory.ReadOnly = true;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.RowHeadersVisible = false;

            dgvCategory.Columns["Id"].Visible = false;
            dgvCategory.Columns["CreatedDate"].Visible = false;
            dgvCategory.Columns["UpdatedDate"].Visible = false;
            dgvCategory.Columns["IsDeleted"].Visible = false;

            dgvCategory.Columns["CategoryName"].HeaderText = "Category";
            dgvCategory.Columns["CategoryDescription"].HeaderText = "Description";
            dgvCategory.Columns["IsActive"].HeaderText = "Active";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
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
            txtCategoryName.Focus();

            await LoadCategories();
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

                txtCategoryName.Text = row.Cells["CategoryName"].Value?.ToString();
                txtDescription.Text = row.Cells["CategoryDescription"].Value?.ToString();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            Category category = await _categoryService.GetByIdAsync(_selectedCategoryId);

            if (category != null)
            {
                category.CategoryName = txtCategoryName.Text.Trim();
                category.CategoryDescription = txtDescription.Text.Trim();

                await _categoryService.UpdateAsync(category);

                MessageBox.Show("Category updated successfully.");

                await LoadCategories();

                txtCategoryName.Clear();
                txtDescription.Clear();

                _selectedCategoryId = 0;
            }
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

                _selectedCategoryId = 0;
            }
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
    }
}
