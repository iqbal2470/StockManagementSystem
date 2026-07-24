using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.ProductServices;
using StockManagementSystem.Services.PurchaseService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.Purchase
{
    public partial class FrmPurchase : BaseForm
    {

        private readonly IPurchaseService _purchaseService;
        private readonly IProductService _productService;

        private int _purchaseId = 0;
        public FrmPurchase(IPurchaseService purchaseService, IProductService productService)
        {
            InitializeComponent();
            _purchaseService = purchaseService;
            _productService = productService;
        }

        private async void FrmPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();

                await LoadPurchases();

                txtPurchaseNo.Text =
                    await _purchaseService.GeneratePurchaseNumberAsync();

                dgvPurchases.ClearSelection();

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private async Task LoadPurchases()
        //{
        //    var purchases = await _purchaseService.GetAllPurchasesAsync();

        //    dgvPurchases.AutoGenerateColumns = true;

        //    dgvPurchases.DataSource = null;

        //    dgvPurchases.DataSource = purchases;

        //    dgvPurchases.ClearSelection();
        //}

        private async Task LoadPurchases()
        {
            var purchases = await _purchaseService.GetAllPurchasesAsync();

            dgvPurchases.AutoGenerateColumns = true;
            dgvPurchases.DataSource = null;
            dgvPurchases.DataSource = purchases;

            // Hide unwanted columns
            dgvPurchases.Columns["Id"].Visible = false;
            dgvPurchases.Columns["ProductId"].Visible = false;
            dgvPurchases.Columns["Product"].Visible = false;
            dgvPurchases.Columns["CreatedDate"].Visible = false;
            dgvPurchases.Columns["UpdatedDate"].Visible = false;
            dgvPurchases.Columns["IsDeleted"].Visible = false;

            // Header Text
            dgvPurchases.Columns["PurchaseNo"].HeaderText = "Purchase No";
            dgvPurchases.Columns["PurchaseDate"].HeaderText = "Date";
            dgvPurchases.Columns["PurchasePrice"].HeaderText = "Price";
            dgvPurchases.Columns["Quantity"].HeaderText = "Qty";
            dgvPurchases.Columns["TotalAmount"].HeaderText = "Total";
            dgvPurchases.Columns["Remarks"].HeaderText = "Remarks";

            // Format
            dgvPurchases.Columns["PurchasePrice"].DefaultCellStyle.Format = "N2";
            dgvPurchases.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";

            dgvPurchases.ClearSelection();
        }
        private async Task ClearForm()
        {
            _purchaseId = 0;

            txtPurchaseNo.Text = await _purchaseService.GeneratePurchaseNumberAsync();

            dtpPurchaseDate.Value = DateTime.Now;

            cmbProduct.SelectedIndex = -1;

            txtPurchasePrice.Clear();

            txtQuantity.Clear();

            txtTotalAmount.Clear();

            rtxtRemarks.Clear();

            txtSearch.Clear();

            cmbProduct.Focus();
        }
        private async Task LoadProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            cmbProduct.DataSource = products;

            cmbProduct.DisplayMember = "ProductName";

            cmbProduct.ValueMember = "Id";

            cmbProduct.SelectedIndex = -1;
        }
        private void CalculateTotal()
        {
            decimal price = 0;
            int qty = 0;

            decimal.TryParse(txtPurchasePrice.Text, out price);

            int.TryParse(txtQuantity.Text, out qty);

            txtTotalAmount.Text = (price * qty).ToString("0.00");
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var purchases = await _purchaseService.SearchPurchasesAsync(txtSearch.Text);

            dgvPurchases.DataSource = null;

            dgvPurchases.DataSource = purchases;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product.");
                    cmbProduct.Focus();
                    return;
                }
              

                if (!decimal.TryParse(txtPurchasePrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Enter a valid purchase price.");
                    txtPurchasePrice.Focus();
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity.");
                    txtQuantity.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
                {
                    MessageBox.Show("Please enter purchase price.");
                    txtPurchasePrice.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Please enter quantity.");
                    txtQuantity.Focus();
                    return;
                }

                PurchaseEntiity purchase = new PurchaseEntiity()
                {
                    PurchaseNo = txtPurchaseNo.Text.Trim(),
                    PurchaseDate = dtpPurchaseDate.Value,
                    ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                    PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
                    Remarks = rtxtRemarks.Text.Trim()
                };

                await _purchaseService.AddPurchaseAsync(purchase);

                MessageBox.Show("Purchase saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadPurchases();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void dgvPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                var purchase = dgvPurchases.Rows[e.RowIndex].DataBoundItem as PurchaseEntiity;

                if (purchase == null)
                    return;

                purchase = await _purchaseService.GetPurchaseByIdAsync(purchase.Id);

                if (purchase == null)
                    return;

                _purchaseId = purchase.Id;

                txtPurchaseNo.Text = purchase.PurchaseNo;

                dtpPurchaseDate.Value = purchase.PurchaseDate;

                cmbProduct.SelectedValue = purchase.ProductId;

                txtPurchasePrice.Text = purchase.PurchasePrice.ToString();

                txtQuantity.Text = purchase.Quantity.ToString();

                txtTotalAmount.Text = purchase.TotalAmount.ToString("0.00");

                rtxtRemarks.Text = purchase.Remarks;
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
                if (_purchaseId == 0)
                {
                    MessageBox.Show("Please select a purchase first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProduct.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product.");
                    cmbProduct.Focus();
                    return;
                }
               

                if (!decimal.TryParse(txtPurchasePrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Enter a valid purchase price.");
                    txtPurchasePrice.Focus();
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Enter a valid quantity.");
                    txtQuantity.Focus();
                    return;
                }
                PurchaseEntiity purchase = new PurchaseEntiity
                {
                    Id = _purchaseId,
                    PurchaseNo = txtPurchaseNo.Text.Trim(),
                    PurchaseDate = dtpPurchaseDate.Value,
                    ProductId = Convert.ToInt32(cmbProduct.SelectedValue),
                    PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    TotalAmount = Convert.ToDecimal(txtTotalAmount.Text),
                    Remarks = rtxtRemarks.Text.Trim()
                };

                await _purchaseService.UpdatePurchaseAsync(purchase);

                MessageBox.Show("Purchase updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadPurchases();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_purchaseId == 0)
                {
                    MessageBox.Show("Please select a purchase first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this purchase?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                await _purchaseService.DeletePurchaseAsync(_purchaseId);

                MessageBox.Show("Purchase deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadPurchases();

                await ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            await ClearForm();

            dgvPurchases.ClearSelection();
        }
    }
}
