using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.ProductServices;
using StockManagementSystem.Services.SaleService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.Sales
{

    public partial class FrmSale : BaseForm
    {

        private readonly ISaleService _saleService;
        private readonly IProductService _productService;

        private int _saleId = 0;
        public FrmSale(ISaleService saleService, IProductService productService)
        {
            InitializeComponent();
            _saleService = saleService;
            _productService = productService;

            dgvSales.RowPostPaint += dgvSales_RowPostPaint;
            dgvSales.CellFormatting += dgvSales_CellFormatting;

            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
        }


        private async void FrmSale_Load(object sender, EventArgs e)
        {

            try
            {
                FormatGrid();
                await LoadProducts();
                await LoadSales();

                txtSaleNo.Text = await _saleService.GenerateSaleNumberAsync();

                dgvSales.ClearSelection();
                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //await LoadProducts();

            //await LoadSales();

            //await ClearForm();

            //dgvSales.ClearSelection();
        }

        private async void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedValue == null)
                    return;

                if (!int.TryParse(cmbProduct.SelectedValue.ToString(), out int productId))
                    return;

                var product = await _productService.GetProductByIdAsync(productId);

                if (product == null)
                    return;

                txtSalePrice.Text = product.SalePrice.ToString("0.00");
            }
            catch
            {

            }
        }

        private void FormatGrid()
        {
            dgvSales.AutoGenerateColumns = false;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.MultiSelect = false;
            dgvSales.ReadOnly = true;
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.AllowUserToResizeRows = false;
            dgvSales.RowHeadersVisible = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvSales.Columns["Id"] != null)
                dgvSales.Columns["Id"].Visible = false;

            if (dgvSales.Columns["colProductId"] != null)
                dgvSales.Columns["colProductId"].Visible = false;

            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSales.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSales.ColumnHeadersHeight = 45;
            dgvSales.RowTemplate.Height = 40;

            dgvSales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            dgvSales.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvSales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvSales.Columns.Contains("colSrNo"))
            {
                dgvSales.Rows[e.RowIndex].Cells["colSrNo"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void dgvSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvSales.Columns[e.ColumnIndex].Name;

            // 1. Product Name Display (Nested Property)
            if (columnName == "colProductName")
            {
                var sale = dgvSales.Rows[e.RowIndex].DataBoundItem as Sale;
                if (sale != null && sale.Product != null)
                {
                    e.Value = sale.Product.ProductName;
                    e.FormattingApplied = true;
                }
            }

            // 2. Sale Date
            if (columnName == "colSaleDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy");
                    e.FormattingApplied = true;
                }
            }

            // 3. Created Date
            if (columnName == "colCreatedDate")
            {
                if (e.Value != null && e.Value != DBNull.Value && Convert.ToDateTime(e.Value) != default)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy hh:mm tt");
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "-";
                    e.FormattingApplied = true;
                }
            }

            // 4. Updated Date
            if (columnName == "colUpdatedDate")
            {
                if (e.Value != null && e.Value != DBNull.Value && Convert.ToDateTime(e.Value) != default)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy hh:mm tt");
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "-";
                    e.FormattingApplied = true;
                }
            }

            // 5. Sale Price Formatting
            if (columnName == "colSalePrice")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("0.00");
                    e.FormattingApplied = true;
                }
            }

            // 6. Quantity Formatting
            if (columnName == "colQuantity")
            {
                if (e.Value != null)
                {
                    e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            // 7. Total Amount Formatting & Styling
            if (columnName == "colTotalAmount")
            {
                if (e.Value != null)
                {
                    decimal total = Convert.ToDecimal(e.Value);
                    e.Value = total.ToString("0.00");
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
            }
        }

        private async Task LoadSales()
        {
            //FormatGrid();

            var sales = await _saleService.GetAllSalesAsync();

            dgvSales.DataSource = null;
            dgvSales.DataSource = sales.ToList();
            dgvSales.DataSource = sales;
            dgvSales.Refresh();
            dgvSales.ClearSelection();
        }

        private async Task LoadProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            cmbProduct.DataSource = null;
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "Id";
            cmbProduct.SelectedIndex = -1;
        }

        //private async Task LoadProducts()
        //{
        //    var products = await _productService.GetAllProductsAsync();

        //    cmbProduct.DataSource = products;

        //    cmbProduct.DisplayMember = "ProductName";

        //    cmbProduct.ValueMember = "Id";

        //    cmbProduct.SelectedIndex = -1;
        //}

        //private async Task LoadSales()
        //{
        //    var sales = await _saleService.GetAllSalesAsync();

        //    dgvSales.AutoGenerateColumns = true;

        //    dgvSales.DataSource = null;

        //    dgvSales.DataSource = sales;

        //    dgvSales.ClearSelection();
        //}

        private async Task ClearForm()
        {
            _saleId = 0;

            txtSaleNo.Text = await _saleService.GenerateSaleNumberAsync();

            dtpSaleDate.Value = DateTime.Now;

            cmbProduct.SelectedIndex = -1;

            txtSalePrice.Clear();

            txtQuantity.Clear();

            txtTotalAmount.Clear();

            rtxtRemarks.Clear();

            txtSearch.Clear();

            cmbProduct.Focus();
        }

        private void CalculateTotal()
        {
            decimal price = 0;

            int quantity = 0;

            decimal.TryParse(txtSalePrice.Text, out price);

            int.TryParse(txtQuantity.Text, out quantity);

            txtTotalAmount.Text = (price * quantity).ToString("0.00");
        }

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product.");
                    cmbProduct.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSalePrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Enter a valid sale price.");
                    txtSalePrice.Focus();
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity.");
                    txtQuantity.Focus();
                    return;
                }

                Sale sale = new Sale()
                {
                    SaleNo = txtSaleNo.Text.Trim(),
                    SaleDate = dtpSaleDate.Value,
                    ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                    SalePrice = price,
                    Quantity = quantity,
                    TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
                    Remarks = rtxtRemarks.Text.Trim(),
                    CreatedDate = DateTime.Now
                };

                await _saleService.AddSaleAsync(sale);

                MessageBox.Show("Sale saved successfully.");

                await LoadSales();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                var sale = dgvSales.Rows[e.RowIndex].DataBoundItem as Sale;

                if (sale == null)
                    return;

                sale = await _saleService.GetSaleByIdAsync(sale.Id);

                if (sale == null)
                    return;

                _saleId = sale.Id;

                txtSaleNo.Text = sale.SaleNo;

                dtpSaleDate.Value = sale.SaleDate;

                cmbProduct.SelectedValue = sale.ProductId;

                txtSalePrice.Text = sale.SalePrice.ToString("0.00");

                txtQuantity.Text = sale.Quantity.ToString();

                txtTotalAmount.Text = sale.TotalAmount.ToString("0.00");

                rtxtRemarks.Text = sale.Remarks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_saleId == 0)
                {
                    MessageBox.Show("Please select a sale first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbProduct.Focus();
                    return;
                }

                if (!decimal.TryParse(txtSalePrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Enter a valid sale price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalePrice.Focus();
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }

                Sale sale = new Sale()
                {
                    Id = _saleId,
                    SaleNo = txtSaleNo.Text.Trim(),
                    SaleDate = dtpSaleDate.Value,
                    ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                    SalePrice = price,
                    Quantity = quantity,
                    TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
                    Remarks = rtxtRemarks.Text.Trim()
                };

                // Service CALL
                await _saleService.UpdateSaleAsync(sale);

                MessageBox.Show("Sale updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // UI reload and clear form
                await LoadSales();
                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private async void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_saleId == 0)
        //        {
        //            MessageBox.Show("Please select a sale first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (cmbProduct.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Please select a product.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            cmbProduct.Focus();
        //            return;
        //        }

        //        if (!decimal.TryParse(txtSalePrice.Text, out decimal price) || price <= 0)
        //        {
        //            MessageBox.Show("Enter a valid sale price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txtSalePrice.Focus();
        //            return;
        //        }

        //        if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
        //        {
        //            MessageBox.Show("Enter a valid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            txtQuantity.Focus();
        //            return;
        //        }

        //        Sale sale = new Sale()
        //        {
        //            Id = _saleId,
        //            SaleNo = txtSaleNo.Text.Trim(),
        //            SaleDate = dtpSaleDate.Value,
        //            ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
        //            SalePrice = Convert.ToDecimal(txtSalePrice.Text),
        //            Quantity = Convert.ToInt32(txtQuantity.Text),
        //            TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
        //            Remarks = rtxtRemarks.Text.Trim(),
        //            UpdatedDate = DateTime.Now
        //        };

        //        await _saleService.UpdateSaleAsync(sale);

        //        MessageBox.Show("Sale updated successfully.");

        //        await LoadSales();

        //        await ClearForm();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_saleId == 0)
                {
                    MessageBox.Show("Please select a sale.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this sale?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                await _saleService.DeleteSaleAsync(_saleId);

                MessageBox.Show("Sale deleted successfully.");

                await LoadSales();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            await ClearForm();

            dgvSales.ClearSelection();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //var sales = await _saleService.SearchSalesAsync(txtSearch.Text);

            //dgvSales.DataSource = null;

            //dgvSales.DataSource = sales;

            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    await LoadSales();
                    return;
                }

                dgvSales.DataSource = null;
                dgvSales.DataSource = await _saleService.SearchSalesAsync(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
