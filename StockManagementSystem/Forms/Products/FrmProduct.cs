using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.BrandServices;
using StockManagementSystem.Services.CategoryServices;
using StockManagementSystem.Services.ProductServices;
using StockManagementSystem.Services.UnitServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace StockManagementSystem.Forms.Products
{
    public partial class FrmProduct : BaseForm
    {
        private string _imagePath = "";
        private int _productId = 0;
        private bool _isNewImageSelected = false;
        private bool _isLoadingProduct = false;
        private bool _isClearingForm = false;


        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IUnitService _unitService;
        public FrmProduct(IProductService productService, ICategoryService categoryService, IBrandService brandService, IUnitService unitService)
        {
            InitializeComponent();
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
            _unitService = unitService;

            dgvProducts.RowPostPaint += dgvProducts_RowPostPaint;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
        }
        private void dgvProducts_RowPostPaint(
    object sender,
    DataGridViewRowPostPaintEventArgs e)
        {
            dgvProducts.Rows[e.RowIndex]
                .Cells["colSrNo"].Value =
                (e.RowIndex + 1).ToString();
        }
        private void dgvProducts_CellFormatting(
    object sender,
    DataGridViewCellFormattingEventArgs e)
        {
            string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

            // Status
            //if (columnName == "colStatus")
            //{
            //    bool status = Convert.ToBoolean(e.Value);

            //    e.Value = status ? "Active" : "Inactive";

            //    e.FormattingApplied = true;
            //}
            if (columnName == "colStatus")
            {
                bool status = Convert.ToBoolean(e.Value);

                e.Value = status ? "Active" : "Inactive";

                if (status)
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }

                e.CellStyle.Font =
                    new Font("Segoe UI", 9, FontStyle.Bold);

                e.FormattingApplied = true;
            }

            // Purchase Price
            if (columnName == "colPurchasePrice")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("0.00");
                    e.FormattingApplied = true;
                }
            }

            // Sale Price
            if (columnName == "colSalePrice")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("0.00");
                    e.FormattingApplied = true;
                }
            }

            // Created Date
            if (columnName == "colCreatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value)
                        .ToString("dd-MM-yyyy");

                    e.FormattingApplied = true;
                }
            }

            // Updated Date
            if (columnName == "colUpdatedDate")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value)
                        .ToString("dd-MM-yyyy");

                    e.FormattingApplied = true;
                }
            }

            if (columnName == "colCurrentStock")
            {
                if (e.Value != null)
                {
                    int stock = Convert.ToInt32(e.Value);

                    if (stock == 0)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font =
                            new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                    else if (stock <= 10)
                    {
                        e.CellStyle.ForeColor = Color.DarkOrange;
                        e.CellStyle.Font =
                            new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font =
                            new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                }
            }

            // Product Image
            if (columnName == "colImage")
            {
                dynamic row = dgvProducts.Rows[e.RowIndex].DataBoundItem;

                if (row != null)
                {
                    e.Value = GetProductImage(row.ImagePath);
                    e.FormattingApplied = true;
                }
            }
            //if (columnName == "colImage")
            //{
            //    Product? product = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;

            //    if (product != null)
            //    {
            //        e.Value = GetProductImage(product.ImagePath);
            //        e.FormattingApplied = true;
            //    }
            //}
        }


        //private async void FrmProduct_Load(object sender, EventArgs e)
        //{
        //    await LoadCategories();
        //    await LoadBrands();
        //    await LoadUnits();

        //    txtMinimumStock.Text = "10";

        //    //await GenerateProductCode();

        //    await LoadProducts();
        //}

        private async void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {

                pnlMain.AutoScroll = true;
                pnlMain.AutoScrollMinSize = new Size(0, 1200);
                await LoadCategories();
                await LoadBrands();
                await LoadUnits();
                //txtMinimumStock.Text = "10";

                // Agar Product Code auto generate karna hai to


                await LoadProducts();

                await LoadDashboardCards();

                dgvProducts.ClearSelection();

                ClearForm();
                await GenerateProductCode();

                if (chkAutoBarcode.Checked)
                {
                    await GenerateNewBarcode();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task LoadDashboardCards()
        {
            lblTotalProducts.Text = (await _productService.GetTotalProductsCountAsync()).ToString();

            lblCurrentStock.Text = (await _productService.GetInStockCountAsync()).ToString();

            lblLowStock.Text = (await _productService.GetLowStockCountAsync()).ToString();

            lblOutofStock.Text = (await _productService.GetOutOfStockCountAsync()).ToString();
        }


        private async Task GenerateProductCode()
        {
            txtProductCode.Text = await _productService.GenerateProductCodeAsync();
        }

        private void GenerateBarcodeImage(string barcodeText)
        {
            if (string.IsNullOrWhiteSpace(barcodeText))
            {
                picBarcode.Image = null;
                return;
            }

            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 350,
                    Height = 90,
                    Margin = 2,
                    PureBarcode = false
                }
            };

            Bitmap bitmap = writer.Write(barcodeText);

            if (picBarcode.Image != null)
            {
                picBarcode.Image.Dispose();
            }

            picBarcode.Image = bitmap;
        }
        //private string GenerateBarcodeNumber()
        //{
        //    Random random = new Random();

        //    return random.NextInt64(
        //        1000000000000,
        //        9999999999999).ToString();
        //}
        //private void GenerateNewBarcode()
        //{
        //    string barcode = GenerateBarcodeNumber();

        //    txtBarcode.Text = barcode;

        //    GenerateBarcodeImage(barcode);
        //}

        private async Task GenerateNewBarcode()
        {
            string barcode = await _productService.GenerateBarcodeAsync();

            txtBarcode.Text = barcode;

            GenerateBarcodeImage(barcode);
        }
        //private async Task LoadProducts()
        //{
        //    var products = await _productService.GetAllProductsAsync();

        //    dgvProducts.AutoGenerateColumns = false;
        //    dgvProducts.DataSource = products;
        //}
        //private async Task LoadProducts()
        //{
        //    try
        //    {
        //        var products = await _productService.GetAllProductsAsync();
        //        //MessageBox.Show($"Products Count = {products.Count}");
        //        //dgvProducts.AutoGenerateColumns = false;
        //        dgvProducts.DataSource = null;
        //        dgvProducts.DataSource = products;

        //        dgvProducts.ClearSelection();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            ex.Message,
        //            "Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}
        private async Task LoadProducts()
        {
            dgvProducts.AutoGenerateColumns = false;

            var products = await _productService.GetAllProductsAsync();

            dgvProducts.DataSource = products.Select(x => new
            {
                x.Id,
                x.ProductCode,
                x.ProductName,
                CategoryName = x.Category?.CategoryName,
                BrandName = x.Brand?.BrandName,
                UnitName = x.Unit?.UnitName,
                x.PurchasePrice,
                x.SalePrice,
                x.CurrentStock,
                x.MinimumStock,
                x.IsActive,
                x.CreatedDate,
                x.UpdatedDate,
                x.ImagePath,
                Product = x
            }).ToList();

            FormatGrid();

            dgvProducts.ClearSelection();
        }
        //private async Task LoadProducts()
        //{
        //    dgvProducts.AutoGenerateColumns = false;

        //    dgvProducts.DataSource =
        //        await _productService.GetAllProductsAsync();

        //     FormatGrid();

        //    dgvProducts.ClearSelection();
        //}

        private Image? GetProductImage(string? imageName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imageName))
                    return null;

                string imagePath = Path.Combine(
                    Application.StartupPath,
                    "ProductImages",
                    imageName);

                if (!File.Exists(imagePath))
                    return null;

                using (var bmp = new Bitmap(imagePath))
                {
                    return new Bitmap(bmp);
                }
            }
            catch
            {
                return null;
            }
        }

        private void FormatGrid()
        {
            dgvProducts.AutoGenerateColumns = false;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect = false;

            dgvProducts.ReadOnly = true;

            dgvProducts.AllowUserToAddRows = false;

            dgvProducts.AllowUserToDeleteRows = false;

            dgvProducts.AllowUserToResizeRows = false;

            dgvProducts.RowHeadersVisible = false;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.Columns["Id"].Visible = false;

            dgvProducts.EnableHeadersVisualStyles = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvProducts.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvProducts.ColumnHeadersHeight = 45;

            dgvProducts.RowTemplate.Height = 55;

            dgvProducts.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(235, 243, 255);

            dgvProducts.DefaultCellStyle.SelectionForeColor =
                Color.Black;
            dgvProducts.Columns["colImage"].Width = 70;
            dgvProducts.RowTemplate.Height = 60;
        }
        private async Task LoadCategories()
        {
            var categories = await _categoryService.GetAllAsync();

            cmbCategory.DataSource = null;
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }

        private async Task LoadBrands()
        {
            var brands = await _brandService.GetAllAsync();

            cmbBrand.DataSource = null;
            cmbBrand.DataSource = brands;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";
            cmbBrand.SelectedIndex = -1;
        }

        private async Task LoadUnits()
        {
            var units = await _unitService.GetAllAsync();

            cmbUnit.DataSource = null;
            cmbUnit.DataSource = units;
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "Id";
            cmbUnit.SelectedIndex = -1;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Select Product Image";
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = openFile.FileName;
                    _isNewImageSelected = true;

                    // Old image release
                    if (picProductImage.Image != null)
                    {
                        picProductImage.Image.Dispose();
                        picProductImage.Image = null;
                    }

                    // Load image without locking file
                    using (FileStream fs = new FileStream(_imagePath, FileMode.Open, FileAccess.Read))
                    {
                        using (Image img = Image.FromStream(fs))
                        {
                            picProductImage.Image = new Bitmap(img);
                        }
                    }
                }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (picProductImage.Image != null)
            {
                picProductImage.Image.Dispose();
                picProductImage.Image = null;
            }

            _imagePath = "";
            _isNewImageSelected = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateProduct())
                    return;

                string imageName = SaveImage();

                Product product = new Product
                {
                    // Agar ProductCode auto generate baad me karna hai
                    // to filhal is line ko hata sakte ho ya baad me set karna.
                    ProductCode = txtProductCode.Text,

                    ProductName = txtProductName.Text.Trim(),

                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                    BrandId = Convert.ToInt32(cmbBrand.SelectedValue),
                    UnitId = Convert.ToInt32(cmbUnit.SelectedValue),

                    VehicleModel = txtVehicleModel.Text.Trim(),

                    PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                    SalePrice = Convert.ToDecimal(txtSalePrice.Text),

                    CurrentStock = Convert.ToInt32(txtCurrentStock.Text),
                    MinimumStock = Convert.ToInt32(txtMinimumStock.Text),

                    Barcode = txtBarcode.Text.Trim(),
                    Description = rtxtDescription.Text.Trim(),

                    ImagePath = imageName,

                    IsActive = true
                };

                await _productService.AddProductAsync(product);

                MessageBox.Show("Product Saved Successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadProducts();

                await LoadDashboardCards();

                ClearForm();

                await GenerateProductCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private  void ClearForm()
        {
            txtProductName.Clear();
            txtVehicleModel.Clear();

            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            txtCurrentStock.Clear();

            txtMinimumStock.Text = "10";

            //txtBarcode.Clear();

            chkAutoBarcode.Checked = true;

            txtBarcode.ReadOnly = true;

            //await GenerateNewBarcode();
            rtxtDescription.Clear();

            cmbCategory.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;

            if (picProductImage.Image != null)
            {
                picProductImage.Image.Dispose();
                picProductImage.Image = null;
            }

            _imagePath = "";
            _isNewImageSelected = false;
            _productId = 0;

            txtProductName.Focus();
        }
        private async void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _isLoadingProduct = true;

                if (e.RowIndex < 0)
                    return;

                if (dgvProducts.Rows[e.RowIndex].Cells["Id"].Value == null)
                    return;

                int id = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["Id"].Value);

                var product = await _productService.GetProductByIdAsync(id);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                _productId = product.Id;
                txtProductCode.Text = product.ProductCode;
                txtProductName.Text = product.ProductName;

                cmbCategory.SelectedValue = product.CategoryId;
                cmbBrand.SelectedValue = product.BrandId;
                cmbUnit.SelectedValue = product.UnitId;

                txtVehicleModel.Text = product.VehicleModel ?? "";

                txtPurchasePrice.Text = product.PurchasePrice.ToString();
                txtSalePrice.Text = product.SalePrice.ToString();

                txtCurrentStock.Text = product.CurrentStock.ToString();
                txtMinimumStock.Text = product.MinimumStock.ToString();

                //txtBarcode.Text = product.Barcode ?? "";
                //if (!string.IsNullOrWhiteSpace(product.Barcode))
                //{
                //    GenerateBarcodeImage(product.Barcode);
                //}
                //else
                //{
                //    picBarcode.Image = null;
                //}
                //chkAutoBarcode.Checked = false;
                //txtBarcode.ReadOnly = false;

                chkAutoBarcode.Checked = false;
                txtBarcode.ReadOnly = false;

                txtBarcode.Text = product.Barcode ?? "";

                if (!string.IsNullOrWhiteSpace(product.Barcode))
                {
                    GenerateBarcodeImage(product.Barcode);
                }
                else
                {
                    picBarcode.Image = null;
                }

                rtxtDescription.Text = product.Description ?? "";

                // Reset Image State
                _imagePath = "";
                _isNewImageSelected = false;

                if (picProductImage.Image != null)
                {
                    picProductImage.Image.Dispose();
                    picProductImage.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(product.ImagePath))
                {
                    string imagePath = Path.Combine(
                        Application.StartupPath,
                        "ProductImages",
                        product.ImagePath);

                    if (File.Exists(imagePath))
                    {
                        using (Bitmap bmp = new Bitmap(imagePath))
                        {
                            picProductImage.Image = new Bitmap(bmp);
                        }
                    }
                }
                _isLoadingProduct = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_productId == 0)
                {
                    MessageBox.Show("Please select a product first.");
                    return;
                }

                if (!ValidateProduct())
                    return;

                var product = await _productService.GetProductByIdAsync(_productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                // New Image Selected
                //if (!string.IsNullOrWhiteSpace(_imagePath) && File.Exists(_imagePath))
                //{
                //    DeleteImage(product.ImagePath);
                //    product.ImagePath = SaveImage();
                //}
                if (_isNewImageSelected)
                {
                    DeleteImage(product.ImagePath);
                    product.ImagePath = SaveImage();
                }
                product.ProductName = txtProductName.Text.Trim();
                product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                product.BrandId = Convert.ToInt32(cmbBrand.SelectedValue);
                product.UnitId = Convert.ToInt32(cmbUnit.SelectedValue);

                product.VehicleModel = txtVehicleModel.Text.Trim();

                product.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
                product.SalePrice = Convert.ToDecimal(txtSalePrice.Text);

                product.CurrentStock = Convert.ToInt32(txtCurrentStock.Text);
                product.MinimumStock = Convert.ToInt32(txtMinimumStock.Text);

                product.Barcode = txtBarcode.Text.Trim();
                product.Description = rtxtDescription.Text.Trim();

                product.UpdatedDate = DateTime.Now;

                await _productService.UpdateProductAsync(product);

                MessageBox.Show("Product Updated Successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadProducts();

                await LoadDashboardCards();

                ClearForm();

                await GenerateProductCode();
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
                if (_productId == 0)
                {
                    MessageBox.Show("Please select a product first.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                var product = await _productService.GetProductByIdAsync(_productId);

                if (product == null)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                // Delete Product Image
                DeleteImage(product.ImagePath);

                // Delete Product
                await _productService.DeleteProductAsync(_productId);

                MessageBox.Show("Product deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadProducts();

                await LoadDashboardCards();

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        //private string SaveImage()
        //{
        //    if (string.IsNullOrWhiteSpace(_imagePath) || !File.Exists(_imagePath))
        //        return "";

        //    string imageName = Guid.NewGuid() + Path.GetExtension(_imagePath);

        //    string folder = Path.Combine(Application.StartupPath, "ProductImages");

        //    if (!Directory.Exists(folder))
        //        Directory.CreateDirectory(folder);

        //    string destination = Path.Combine(folder, imageName);

        //    File.Copy(_imagePath, destination, true);

        //    return imageName;
        //}
        private string SaveImage()
        {
            if (!_isNewImageSelected)
                return "";

            if (string.IsNullOrWhiteSpace(_imagePath))
                return "";

            if (!File.Exists(_imagePath))
                return "";

            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(_imagePath);

            string folder = Path.Combine(Application.StartupPath, "ProductImages");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string destination = Path.Combine(folder, imageName);

            File.Copy(_imagePath, destination, true);

            return imageName;
        }
        private bool ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter Product Name.");
                txtProductName.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Category.");
                cmbCategory.Focus();
                return false;
            }

            if (cmbBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Brand.");
                cmbBrand.Focus();
                return false;
            }

            if (cmbUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Unit.");
                cmbUnit.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPurchasePrice.Text, out decimal purchasePrice))
            {
                MessageBox.Show("Enter valid Purchase Price.");
                txtPurchasePrice.Focus();
                return false;
            }

            if (purchasePrice < 0)
            {
                MessageBox.Show("Purchase Price cannot be negative.");
                txtPurchasePrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
            {
                MessageBox.Show("Enter valid Sale Price.");
                txtSalePrice.Focus();
                return false;
            }

            if (salePrice < 0)
            {
                MessageBox.Show("Sale Price cannot be negative.");
                txtSalePrice.Focus();
                return false;
            }

            if (!int.TryParse(txtCurrentStock.Text, out int currentStock))
            {
                MessageBox.Show("Enter valid Current Stock.");
                txtCurrentStock.Focus();
                return false;
            }

            if (currentStock < 0)
            {
                MessageBox.Show("Current Stock cannot be negative.");
                txtCurrentStock.Focus();
                return false;
            }

            if (!int.TryParse(txtMinimumStock.Text, out int minimumStock))
            {
                MessageBox.Show("Enter valid Minimum Stock.");
                txtMinimumStock.Focus();
                return false;
            }

            if (minimumStock < 0)
            {
                MessageBox.Show("Minimum Stock cannot be negative.");
                txtMinimumStock.Focus();
                return false;
            }

            if (salePrice < purchasePrice)
            {
                DialogResult result = MessageBox.Show(
                    "Sale Price is less than Purchase Price.\nDo you still want to continue?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    txtSalePrice.Focus();
                    return false;
                }
            }

            return true;
        }

        //private bool ValidateProduct()
        //{
        //    if (string.IsNullOrWhiteSpace(txtProductName.Text))
        //    {
        //        MessageBox.Show("Please enter Product Name.");
        //        txtProductName.Focus();
        //        return false;
        //    }

        //    if (cmbCategory.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select Category.");
        //        cmbCategory.Focus();
        //        return false;
        //    }

        //    if (cmbBrand.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select Brand.");
        //        cmbBrand.Focus();
        //        return false;
        //    }

        //    if (cmbUnit.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select Unit.");
        //        cmbUnit.Focus();
        //        return false;
        //    }

        //    if (!decimal.TryParse(txtPurchasePrice.Text, out _))
        //    {
        //        MessageBox.Show("Enter valid Purchase Price.");
        //        txtPurchasePrice.Focus();
        //        return false;
        //    }

        //    if (!decimal.TryParse(txtSalePrice.Text, out _))
        //    {
        //        MessageBox.Show("Enter valid Sale Price.");
        //        txtSalePrice.Focus();
        //        return false;
        //    }

        //    if (!int.TryParse(txtCurrentStock.Text, out _))
        //    {
        //        MessageBox.Show("Enter valid Current Stock.");
        //        txtCurrentStock.Focus();
        //        return false;
        //    }

        //    if (!int.TryParse(txtMinimumStock.Text, out _))
        //    {
        //        MessageBox.Show("Enter valid Minimum Stock.");
        //        txtMinimumStock.Focus();
        //        return false;
        //    }

        //    return true;
        //}

        private void DeleteImage(string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                return;

            string imagePath = Path.Combine(Application.StartupPath, "ProductImages", imageName);

            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    await LoadProducts();
                    return;
                }

                dgvProducts.DataSource = await _productService.SearchProductsAsync(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void chkAutoBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (_isLoadingProduct)
                return;
            if (chkAutoBarcode.Checked)
            {
                txtBarcode.ReadOnly = true;

                await GenerateNewBarcode();
            }
            else
            {
                txtBarcode.ReadOnly = false;

                txtBarcode.Clear();

                picBarcode.Image = null;

                txtBarcode.Focus();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (_isLoadingProduct || _isClearingForm)
                return;

            if (!chkAutoBarcode.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    GenerateBarcodeImage(txtBarcode.Text);
                }
                else
                {
                    picBarcode.Image = null;
                }
            }
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ClearForm();

            //    await GenerateProductCode();

            //    await LoadProducts();

            //    dgvProducts.ClearSelection();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message,
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}


            try
            {
                _isClearingForm = true;

                ClearForm();

                await GenerateProductCode();

                await GenerateNewBarcode();

                await LoadProducts();

                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _isClearingForm = false;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
