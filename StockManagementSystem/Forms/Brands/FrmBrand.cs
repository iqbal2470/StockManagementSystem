using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;

using StockManagementSystem.Services.BrandServices;

using System.Data;

namespace StockManagementSystem.Forms.Brands
{
    public partial class FrmBrand : BaseForm
    {

        private readonly IBrandService _brandService;
        private int _selectedBrandId = 0;
        public FrmBrand(IBrandService brandService)
        {
            InitializeComponent();
            
            txtBrandName.KeyDown += Control_KeyDown;
            
            txtSearch.KeyDown += Control_KeyDown;
            _brandService = brandService;

            dgvBrand.RowPostPaint += dgvBrand_RowPostPaint;
            dgvBrand.CellFormatting += dgvBrand_CellFormatting;
        }



        private async void FrmBrand_Load(object sender, EventArgs e)
        {
            await LoadBrands();

            await LoadDashboardCards();

            SetAddMode();
        }
        private async Task LoadBrands()
        {
            dgvBrand.AutoGenerateColumns = false;
            dgvBrand.DataSource = await _brandService.GetAllAsync();
            FormatGrid();
        }

        //private void FormatGrid()
        //{
        //    dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgvBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvBrand.MultiSelect = false;
        //    dgvBrand.ReadOnly = true;
        //    dgvBrand.AllowUserToAddRows = false;
        //    dgvBrand.AllowUserToDeleteRows = false;
        //    dgvBrand.RowHeadersVisible = false;

        //    dgvBrand.Columns["Id"].Visible = false;
        //    dgvBrand.Columns["CreatedDate"].Visible = false;
        //    dgvBrand.Columns["UpdatedDate"].Visible = false;
        //    dgvBrand.Columns["IsDeleted"].Visible = false;

        //    dgvBrand.Columns["BrandName"].HeaderText = "Brands";

        //    dgvBrand.Columns["IsActive"].HeaderText = "Active";
        //}

        private void FormatGrid()
        {
            dgvBrand.AutoGenerateColumns = false;

            dgvBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrand.MultiSelect = false;
            dgvBrand.ReadOnly = true;
            dgvBrand.AllowUserToAddRows = false;
            dgvBrand.AllowUserToDeleteRows = false;
            dgvBrand.AllowUserToResizeRows = false;
            dgvBrand.RowHeadersVisible = false;

            dgvBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBrand.Columns["Id"].Visible = false;

            dgvBrand.Columns["colSrNo"].HeaderText = "#";
            dgvBrand.Columns["colBrandName"].HeaderText = "Brand Name";
            dgvBrand.Columns["colStatus"].HeaderText = "Status";
            dgvBrand.Columns["colCreatedDate"].HeaderText = "Created Date";
            dgvBrand.Columns["colUpdatedDate"].HeaderText = "Updated Date";

            //dgvBrand.Columns["colEdit"].Visible = false;
            //dgvBrand.Columns["colDelete"].Visible = false;

            dgvBrand.Columns["colSrNo"].FillWeight = 40;
            dgvBrand.Columns["colBrandName"].FillWeight = 180;
            dgvBrand.Columns["colStatus"].FillWeight = 90;
            dgvBrand.Columns["colCreatedDate"].FillWeight = 120;
            dgvBrand.Columns["colUpdatedDate"].FillWeight = 120;
            //dgvBrand.Columns["colEdit"].FillWeight = 70;
            //dgvBrand.Columns["colDelete"].FillWeight = 70;

            dgvBrand.EnableHeadersVisualStyles = false;

            dgvBrand.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvBrand.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvBrand.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvBrand.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvBrand.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 243, 255);

            dgvBrand.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvBrand.ColumnHeadersHeight = 45;
            dgvBrand.RowTemplate.Height = 40;

            dgvBrand.GridColor = Color.Gainsboro;
            dgvBrand.BorderStyle = BorderStyle.None;
        }

        private void dgvBrand_RowPostPaint(object sender,
    DataGridViewRowPostPaintEventArgs e)
        {
            dgvBrand.Rows[e.RowIndex]
                .Cells["colSrNo"].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvBrand_CellFormatting(object sender,
    DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBrand.Columns[e.ColumnIndex].Name == "colStatus")
            {
                bool status = Convert.ToBoolean(e.Value);

                e.Value = status ? "Active" : "Inactive";

                e.FormattingApplied = true;
            }

            if (dgvBrand.Columns[e.ColumnIndex].Name == "colCreatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value)
                        .ToString("dd-MM-yyyy");

                    e.FormattingApplied = true;
                }
            }

            if (dgvBrand.Columns[e.ColumnIndex].Name == "colUpdatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value)
                        .ToString("dd-MM-yyyy");

                    e.FormattingApplied = true;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateBrand())
                return;
            if (_selectedBrandId > 0)
            {
                MessageBox.Show(
                    "Brand already selected. Please click New before saving a new brand.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
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

            SetAddMode();

            txtBrandName.Focus();

            await LoadBrands();

            await LoadDashboardCards();
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

                SetEditMode();

                txtBrandName.Text = row.Cells["colBrandName"].Value?.ToString();
                
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateBrand())
                return;
            if (_selectedBrandId == 0)
            {
                MessageBox.Show("Please select a brand.");
                return;
            }
            
            Brand brand = await _brandService.GetByIdAsync(_selectedBrandId);
brand.UpdatedDate = DateTime.Now;
            if (brand != null)
            {
                brand.BrandName = txtBrandName.Text.Trim();
              

                await _brandService.UpdateAsync(brand);

                MessageBox.Show("Brands updated successfully.");

                await LoadBrands();

                await LoadDashboardCards();
                txtBrandName.Clear();
               

                _selectedBrandId = 0;

                SetAddMode();
                txtBrandName.Focus();
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
                await LoadDashboardCards();
                txtBrandName.Clear();
            

                _selectedBrandId = 0;

                SetAddMode();

                txtBrandName.Focus();
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

            SetAddMode();

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


        private async Task LoadDashboardCards()
        {
            var brands = await _brandService.GetAllAsync();

            lblTotalBrand.Text = brands.Count.ToString();

            lblActive.Text = brands.Count(x => x.IsActive).ToString();

            lblInActive.Text = brands.Count(x => !x.IsActive).ToString();
        }

        private void SetAddMode()
        {
            btnSave.Enabled = true;

            btnUpdate.Enabled = false;

            btnDelete.Enabled = false;

            _selectedBrandId = 0;
        }

        private void SetEditMode()
        {
            btnSave.Enabled = false;

            btnUpdate.Enabled = true;

            btnDelete.Enabled = true;
        }

        private bool ValidateBrand()
        {
            if (string.IsNullOrWhiteSpace(txtBrandName.Text))
            {
                MessageBox.Show("Please enter Brand Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBrandName.Focus();
                return false;
            }

            if (txtBrandName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Brand Name must be at least 3 characters.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBrandName.Focus();
                return false;
            }

            return true;
        }
    }
}
