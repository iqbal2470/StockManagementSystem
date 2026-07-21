using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.CategoryServices;
using StockManagementSystem.Services.BrandServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace StockManagementSystem.Forms.Brands
{
    public partial class FrmBrand : Form
    {

        private readonly IBrandService _brandService;
        private int _selectedBrandId = 0;
        public FrmBrand(IBrandService brandService)
        {
            InitializeComponent();
            
            txtBrandName.KeyDown += Control_KeyDown;
            
            txtSearch.KeyDown += Control_KeyDown;
            _brandService = brandService;
        }



        private async void FrmBrand_Load(object sender, EventArgs e)
        {
            await LoadBrands();
        }
        private async Task LoadBrands()
        {
            dgvBrand.DataSource = await _brandService.GetAllAsync();
            FormatGrid();
        }

        private void FormatGrid()
        {
            dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrand.MultiSelect = false;
            dgvBrand.ReadOnly = true;
            dgvBrand.AllowUserToAddRows = false;
            dgvBrand.AllowUserToDeleteRows = false;
            dgvBrand.RowHeadersVisible = false;

            dgvBrand.Columns["Id"].Visible = false;
            dgvBrand.Columns["CreatedDate"].Visible = false;
            dgvBrand.Columns["UpdatedDate"].Visible = false;
            dgvBrand.Columns["IsDeleted"].Visible = false;

            dgvBrand.Columns["BrandName"].HeaderText = "Brands";
         
            dgvBrand.Columns["IsActive"].HeaderText = "Active";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandName.Text))
            {
                MessageBox.Show("Please enter Brand Name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrandName.Focus();
                return;
            }

            Brand brand = new Brand
            {
                BrandName = txtBrandName.Text.Trim(),
               
                IsActive = true
            };

            await _brandService.AddAsync(brand);

            MessageBox.Show("Brands saved successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtBrandName.Clear();
            
            txtBrandName.Focus();

            await LoadBrands();
        }

        //private async void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (_selectedCategoryId == 0)
        //    {
        //        MessageBox.Show("Please select a category.");
        //        return;
        //    }

        //    Category category = await _brandService.GetByIdAsync(_selectedCategoryId);

        //    if (category != null)
        //    {
        //        category.CategoryName = txtBrandName.Text.Trim();
        //        category.CategoryDescription = txtDescription.Text.Trim();

        //        await _brandService.UpdateAsync(category);

        //        MessageBox.Show("Category updated successfully.");

        //        await LoadCategories();

        //        txtBrandName.Clear();
        //        txtDescription.Clear();

        //        _selectedCategoryId = 0;
        //    }
        //}

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBrand.Rows[e.RowIndex];

                _selectedBrandId = Convert.ToInt32(row.Cells["Id"].Value);

                txtBrandName.Text = row.Cells["BrandName"].Value?.ToString();
                
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedBrandId == 0)
            {
                MessageBox.Show("Please select a brand.");
                return;
            }

            Brand brand = await _brandService.GetByIdAsync(_selectedBrandId);

            if (brand != null)
            {
                brand.BrandName = txtBrandName.Text.Trim();
              

                await _brandService.UpdateAsync(brand);

                MessageBox.Show("Brands updated successfully.");

                await LoadBrands();

                txtBrandName.Clear();
               

                _selectedBrandId = 0;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBrandId == 0)
            {
                MessageBox.Show("Please select a brand to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this brand?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _brandService.DeleteAsync(_selectedBrandId);

                MessageBox.Show("Brands deleted successfully.");

                await LoadBrands();

                txtBrandName.Clear();
            

                _selectedBrandId = 0;
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
            txtBrandName.Clear();
           

            _selectedBrandId = 0;

            txtBrandName.Focus();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var categories = await _brandService.GetAllAsync();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                categories = categories
                    .Where(x => x.BrandName.Contains(txtSearch.Text,
                            StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dgvBrand.DataSource = categories;

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
