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
        }

        private async void FrmSale_Load(object sender, EventArgs e)
        {
            await LoadProducts();

            await LoadSales();

            await ClearForm();

            dgvSales.ClearSelection();
        }

        private async Task LoadProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            cmbProduct.DataSource = products;

            cmbProduct.DisplayMember = "ProductName";

            cmbProduct.ValueMember = "Id";

            cmbProduct.SelectedIndex = -1;
        }

        private async Task LoadSales()
        {
            var sales = await _saleService.GetAllSalesAsync();

            dgvSales.AutoGenerateColumns = true;

            dgvSales.DataSource = null;

            dgvSales.DataSource = sales;

            dgvSales.ClearSelection();
        }

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
                    Remarks = rtxtRemarks.Text.Trim()
                };

                await _saleService.AddSaleAsync(sale);

                MessageBox.Show("Sale saved successfully.");

                await LoadSales();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                txtSalePrice.Text = sale.SalePrice.ToString();

                txtQuantity.Text = sale.Quantity.ToString();

                txtTotalAmount.Text = sale.TotalAmount.ToString("0.00");

                rtxtRemarks.Text = sale.Remarks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_saleId == 0)
                {
                    MessageBox.Show("Please select a sale.");
                    return;
                }

                Sale sale = new Sale()
                {
                    Id = _saleId,
                    SaleNo = txtSaleNo.Text.Trim(),
                    SaleDate = dtpSaleDate.Value,
                    ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                    SalePrice = Convert.ToDecimal(txtSalePrice.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
                    Remarks = rtxtRemarks.Text.Trim()
                };

                await _saleService.UpdateSaleAsync(sale);

                MessageBox.Show("Sale updated successfully.");

                await LoadSales();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
            var sales = await _saleService.SearchSalesAsync(txtSearch.Text);

            dgvSales.DataSource = null;

            dgvSales.DataSource = sales;
        }
    }
}
