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
        public event Action? LoadingCompleted;
        private int _purchaseId = 0;
        public FrmPurchase(IPurchaseService purchaseService, IProductService productService)
        {
            InitializeComponent();
            _purchaseService = purchaseService;
            _productService = productService;

            dgvPurchases.RowPostPaint += dgvPurchases_RowPostPaint;
            dgvPurchases.CellFormatting += dgvPurchases_CellFormatting;

            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
        }

        private void dgvPurchases_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvPurchases.Columns.Contains("colSrNo"))
            {
                dgvPurchases.Rows[e.RowIndex].Cells["colSrNo"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void dgvPurchases_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvPurchases.Columns[e.ColumnIndex].Name;

            // 1. Product Name Display (Nested Navigation Property)
            if (columnName == "colProductName")
            {
                var purchase = dgvPurchases.Rows[e.RowIndex].DataBoundItem as PurchaseEntiity;
                if (purchase != null && purchase.Product != null)
                {
                    e.Value = purchase.Product.ProductName;
                    e.FormattingApplied = true;
                }
            }

            // 2. Date Formatting
            if (columnName == "colPurchaseDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy");
                    e.FormattingApplied = true;
                }
            }

            // 3. Purchase Price Formatting
            if (columnName == "colPurchasePrice")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("0.00");
                    e.FormattingApplied = true;
                }
            }

            if (columnName == "colCreatedDate")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

          
            if (columnName == "colUpdatedDate")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd-MM-yyyy hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            // 4. Quantity Formatting & Color
            if (columnName == "colQuantity")
            {
                if (e.Value != null)
                {
                    e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            // 5. Total Amount Formatting & Highlight
            if (columnName == "colTotalAmount")
            {
                if (e.Value != null)
                {
                    decimal total = Convert.ToDecimal(e.Value);
                    e.Value = total.ToString("0.00");

                    // Text Bold and Green Color for Total Amount
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
            }
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

               await ClearForm();

                SetButtonAddMode();

                LoadingCompleted?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                txtPurchasePrice.Text = product.PurchasePrice.ToString("0.00");
            }
            catch
            {

            }
        }

        private void FormatGrid()
        {
            dgvPurchases.AutoGenerateColumns = false;
            dgvPurchases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchases.MultiSelect = false;
            dgvPurchases.ReadOnly = true;
            dgvPurchases.AllowUserToAddRows = false;
            dgvPurchases.AllowUserToDeleteRows = false;
            dgvPurchases.AllowUserToResizeRows = false;
            dgvPurchases.RowHeadersVisible = false;
            dgvPurchases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPurchases.Columns["Id"] != null)
                dgvPurchases.Columns["Id"].Visible = false;

            dgvPurchases.Columns["colProductId"].Visible = false;
            dgvPurchases.EnableHeadersVisualStyles = false;
            dgvPurchases.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPurchases.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPurchases.ColumnHeadersHeight = 45;
            dgvPurchases.RowTemplate.Height = 40;

            dgvPurchases.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            dgvPurchases.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private async Task LoadPurchases()
        {
            FormatGrid();

            var purchases = await _purchaseService.GetAllPurchasesAsync();

            dgvPurchases.DataSource = null;
            dgvPurchases.DataSource = purchases;

            dgvPurchases.ClearSelection();
        }



        //private async Task LoadPurchases()
        //{
        //    var purchases = await _purchaseService.GetAllPurchasesAsync();

        //    dgvPurchases.AutoGenerateColumns = true;
        //    dgvPurchases.DataSource = null;
        //    dgvPurchases.DataSource = purchases;

        //    // Hide unwanted columns
        //    dgvPurchases.Columns["Id"].Visible = false;
        //    dgvPurchases.Columns["ProductId"].Visible = false;
        //    dgvPurchases.Columns["Product"].Visible = false;
        //    dgvPurchases.Columns["CreatedDate"].Visible = false;
        //    dgvPurchases.Columns["UpdatedDate"].Visible = false;
        //    dgvPurchases.Columns["IsDeleted"].Visible = false;

        //    // Header Text
        //    dgvPurchases.Columns["PurchaseNo"].HeaderText = "Purchase No";
        //    dgvPurchases.Columns["PurchaseDate"].HeaderText = "Date";
        //    dgvPurchases.Columns["PurchasePrice"].HeaderText = "Price";
        //    dgvPurchases.Columns["Quantity"].HeaderText = "Qty";
        //    dgvPurchases.Columns["TotalAmount"].HeaderText = "Total";
        //    dgvPurchases.Columns["Remarks"].HeaderText = "Remarks";

        //    // Format
        //    dgvPurchases.Columns["PurchasePrice"].DefaultCellStyle.Format = "N2";
        //    dgvPurchases.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";

        //    dgvPurchases.ClearSelection();
        //}
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
            //var purchases = await _purchaseService.SearchPurchasesAsync(txtSearch.Text);

            //dgvPurchases.DataSource = null;

            //dgvPurchases.DataSource = purchases;

            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    await LoadPurchases();
                    return;
                }

                dgvPurchases.DataSource = null;
                dgvPurchases.DataSource = await _purchaseService.SearchPurchasesAsync(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_purchaseId > 0)
                {
                    MessageBox.Show(
                        "Purchase already selected. Please click Clear before saving a new purchase.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!ValidatePurchase())
                    return;
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

                SetButtonAddMode();
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
            //try
            //{
            //    if (e.RowIndex < 0)
            //        return;

            //    var purchase = dgvPurchases.Rows[e.RowIndex].DataBoundItem as PurchaseEntiity;

            //    if (purchase == null)
            //        return;

            //    purchase = await _purchaseService.GetPurchaseByIdAsync(purchase.Id);

            //    if (purchase == null)
            //        return;

            //    _purchaseId = purchase.Id;

            //    txtPurchaseNo.Text = purchase.PurchaseNo;

            //    dtpPurchaseDate.Value = purchase.PurchaseDate;

            //    cmbProduct.SelectedValue = purchase.ProductId;

            //    txtPurchasePrice.Text = purchase.PurchasePrice.ToString();

            //    txtQuantity.Text = purchase.Quantity.ToString();

            //    txtTotalAmount.Text = purchase.TotalAmount.ToString("0.00");

            //    rtxtRemarks.Text = purchase.Remarks;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {
                if (e.RowIndex < 0)
                    return;

                var purchaseItem = dgvPurchases.Rows[e.RowIndex].DataBoundItem as PurchaseEntiity;

                if (purchaseItem == null)
                    return;

                var purchase = await _purchaseService.GetPurchaseByIdAsync(purchaseItem.Id);

                if (purchase == null)
                    return;

                _purchaseId = purchase.Id;

                SetButtonEditMode();

                txtPurchaseNo.Text = purchase.PurchaseNo;
                dtpPurchaseDate.Value = purchase.PurchaseDate;
                cmbProduct.SelectedValue = purchase.ProductId;
                txtPurchasePrice.Text = purchase.PurchasePrice.ToString("0.00");
                txtQuantity.Text = purchase.Quantity.ToString();
                txtTotalAmount.Text = purchase.TotalAmount.ToString("0.00");
                rtxtRemarks.Text = purchase.Remarks;


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
                if (!ValidatePurchase())
                    return;
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
                    Remarks = rtxtRemarks.Text.Trim(),
                    UpdatedDate = DateTime.Now
                };
                await _purchaseService.UpdatePurchaseAsync(purchase);

                MessageBox.Show("Purchase updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadPurchases();

                await ClearForm();
                SetButtonAddMode();
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


                SetButtonAddMode();
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


            SetButtonAddMode();

            dgvPurchases.ClearSelection();
        }

        private bool ValidatePurchase()
        {
            if (cmbProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Product.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbProduct.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
            {
                MessageBox.Show("Please enter Purchase Price.");

                txtPurchasePrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPurchasePrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid Purchase Price.");

                txtPurchasePrice.Focus();
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show("Purchase Price must be greater than zero.");

                txtPurchasePrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter Quantity.");

                txtQuantity.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty))
            {
                MessageBox.Show("Please enter a valid Quantity.");

                txtQuantity.Focus();
                return false;
            }

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");

                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private void SetButtonAddMode()
        {
            btnSave.Enabled = true;

            btnUpdate.Enabled = false;

            btnDelete.Enabled = false;
        }

        private void SetButtonEditMode()
        {
            btnSave.Enabled = false;

            btnUpdate.Enabled = true;

            btnDelete.Enabled = true;
        }
    }
}
