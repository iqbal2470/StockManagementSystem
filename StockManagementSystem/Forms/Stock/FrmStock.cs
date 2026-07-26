using StockManagementSystem.Models.Common;
using StockManagementSystem.Services.StockServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.Stock
{
    public partial class FrmStock : BaseForm
    {
        private readonly IStockService _stockService;
        public FrmStock(IStockService stockService)
        {
            InitializeComponent();
            _stockService = stockService;

            // Event Subscriptions
            dgvStock.RowPostPaint += dgvStock_RowPostPaint;
            dgvStock.CellFormatting += dgvStock_CellFormatting;
        }

        private async void FrmStock_Load(object sender, EventArgs e)
        {
            //await LoadStock();
            //await LoadCounts();
            //dgvStock.ClearSelection();

            try
            {
                await LoadStock();
                await LoadCounts();
                dgvStock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // GRID FORMATTING & CUSTOM DISPLAY
        // ==========================================

        private void FormatGrid()
        {
            dgvStock.AutoGenerateColumns = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.MultiSelect = false;
            dgvStock.ReadOnly = true;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvStock.Columns["Id"] != null)
                dgvStock.Columns["Id"].Visible = false;

            if (dgvStock.Columns["Id"] != null)
                dgvStock.Columns["Id"].Visible = false;

            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStock.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStock.ColumnHeadersHeight = 45;
            dgvStock.RowTemplate.Height = 40;

            dgvStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 243, 255);
            dgvStock.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvStock_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvStock.Columns.Contains("colSrNo"))
            {
                dgvStock.Rows[e.RowIndex].Cells["colSrNo"].Value = (e.RowIndex + 1).ToString();
            }
        }
        //private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex < 0 || e.RowIndex >= dgvStock.Rows.Count) return;

        //    string columnName = dgvStock.Columns[e.ColumnIndex].Name;
        //    object rawValue = e.Value;

        //    // 1. Current Stock Formatting
        //    if (columnName == "colCurrentStock")
        //    {
        //        e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    }

        //    // 2. Minimum Stock Formatting
        //    if (columnName == "colMinimumStock")
        //    {
        //        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    }

        //    // 3. Purchase & Sale Price Formatting (Blank hone par 0.00 dikhayega)
        //    if (columnName == "colPurchasePrice" || columnName == "colSalePrice")
        //    {
        //        if (rawValue != null && decimal.TryParse(rawValue.ToString(), out decimal price))
        //        {
        //            e.Value = price.ToString("0.00");
        //            e.FormattingApplied = true;
        //        }
        //        else
        //        {
        //            e.Value = "0.00";
        //            e.FormattingApplied = true;
        //        }
        //    }

        //    // 4. Stock Status Auto-Calculation & Visual Colors
        //    if (columnName == "colStockStatus")
        //    {
        //        var currentCell = dgvStock.Rows[e.RowIndex].Cells["colCurrentStock"].Value;
        //        var minCell = dgvStock.Rows[e.RowIndex].Cells["colMinimumStock"].Value;

        //        if (currentCell != null && minCell != null)
        //        {
        //            int currentStock = Convert.ToInt32(currentCell);
        //            int minStock = Convert.ToInt32(minCell);

        //            if (currentStock <= 0)
        //            {
        //                e.Value = "Out of Stock";
        //                e.CellStyle.ForeColor = Color.Red;
        //                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //            }
        //            else if (currentStock <= minStock)
        //            {
        //                e.Value = "Low Stock";
        //                e.CellStyle.ForeColor = Color.OrangeRed;
        //                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //            }
        //            else
        //            {
        //                e.Value = "In Stock";
        //                e.CellStyle.ForeColor = Color.DarkGreen;
        //                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //            }
        //            e.FormattingApplied = true;
        //        }
        //    }

        //    // 5. Created Date Display Formatting
        //    if (columnName == "colCreatedDate")
        //    {
        //        if (rawValue != null && rawValue != DBNull.Value && DateTime.TryParse(rawValue.ToString(), out DateTime createdDate) && createdDate != DateTime.MinValue)
        //        {
        //            e.Value = createdDate.ToString("dd-MM-yyyy hh:mm tt");
        //        }
        //        else
        //        {
        //            e.Value = "-";
        //        }
        //        e.FormattingApplied = true;
        //    }

        //    // 6. Updated Date Display Formatting
        //    if (columnName == "colUpdatedDate")
        //    {
        //        if (rawValue != null && rawValue != DBNull.Value && DateTime.TryParse(rawValue.ToString(), out DateTime updatedDate) && updatedDate != DateTime.MinValue)
        //        {
        //            e.Value = updatedDate.ToString("dd-MM-yyyy hh:mm tt");
        //        }
        //        else
        //        {
        //            e.Value = "-";
        //        }
        //        e.FormattingApplied = true;
        //    }
        //}
        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvStock.Rows.Count) return;

            string columnName = dgvStock.Columns[e.ColumnIndex].Name;
            var rowItem = dgvStock.Rows[e.RowIndex].DataBoundItem;

            if (rowItem == null) return;

            // ==========================================
            // 1. PRODUCT NAME & CATEGORY EXTRACTION (Dynamic Mapping)
            // ==========================================
            if (columnName == "colProductName")
            {
                e.Value = GetPropertyValue(rowItem, "ProductName")
                       ?? GetNestedPropertyValue(rowItem, "Product.ProductName")
                       ?? GetPropertyValue(rowItem, "Name")
                       ?? "-";
                e.FormattingApplied = true;
            }

            if (columnName == "colCategoryName" || columnName == "colCategory")
            {
                e.Value = GetPropertyValue(rowItem, "CategoryName")
                       ?? GetNestedPropertyValue(rowItem, "Category.CategoryName")
                       ?? GetNestedPropertyValue(rowItem, "Category.Name")
                       ?? GetNestedPropertyValue(rowItem, "Product.Category.CategoryName")
                       ?? "-";
                e.FormattingApplied = true;
            }

            // ==========================================
            // 2. SALE PRICE FORMATTING
            // ==========================================
            if (columnName == "colSalePrice")
            {
                object rawSalePrice = GetPropertyValue(rowItem, "SalePrice")
                                   ?? GetNestedPropertyValue(rowItem, "Product.SalePrice")
                                   ?? e.Value;

                if (rawSalePrice != null && decimal.TryParse(rawSalePrice.ToString(), out decimal salePrice))
                {
                    e.Value = salePrice.ToString("0.00");
                }
                else
                {
                    e.Value = "0.00";
                }
                e.FormattingApplied = true;
            }

            // ==========================================
            // 3. PURCHASE PRICE FORMATTING
            // ==========================================
            if (columnName == "colPurchasePrice")
            {
                object rawPurchasePrice = GetPropertyValue(rowItem, "PurchasePrice")
                                       ?? GetNestedPropertyValue(rowItem, "Product.PurchasePrice")
                                       ?? e.Value;

                if (rawPurchasePrice != null && decimal.TryParse(rawPurchasePrice.ToString(), out decimal purchasePrice))
                {
                    e.Value = purchasePrice.ToString("0.00");
                }
                else
                {
                    e.Value = "0.00";
                }
                e.FormattingApplied = true;
            }

            // ==========================================
            // 4. CURRENT & MIN STOCK
            // ==========================================
            if (columnName == "colCurrentStock")
            {
                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (columnName == "colMinimumStock")
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // ==========================================
            // 5. STOCK STATUS BADGES
            // ==========================================
            if (columnName == "colStockStatus")
            {
                var currentVal = GetPropertyValue(rowItem, "CurrentStock") ?? dgvStock.Rows[e.RowIndex].Cells["colCurrentStock"].Value;
                var minVal = GetPropertyValue(rowItem, "MinimumStock") ?? dgvStock.Rows[e.RowIndex].Cells["colMinimumStock"].Value;

                if (currentVal != null && minVal != null)
                {
                    int currentStock = Convert.ToInt32(currentVal);
                    int minStock = Convert.ToInt32(minVal);

                    if (currentStock <= 0)
                    {
                        e.Value = "Out of Stock";
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                    else if (currentStock < minStock)
                    {
                        e.Value = "Low Stock";
                        e.CellStyle.ForeColor = Color.OrangeRed;
                        e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                    else
                    {
                        e.Value = "In Stock";
                        e.CellStyle.ForeColor = Color.DarkGreen;
                        e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                    e.FormattingApplied = true;
                }
            }

            // ==========================================
            // 6. CREATED & UPDATED DATES
            // ==========================================
            if (columnName == "colCreatedDate")
            {
                object rawCreated = GetPropertyValue(rowItem, "CreatedDate");
                if (rawCreated != null && DateTime.TryParse(rawCreated.ToString(), out DateTime createdDate) && createdDate != DateTime.MinValue)
                {
                    e.Value = createdDate.ToString("dd-MM-yyyy hh:mm tt");
                }
                else
                {
                    e.Value = "-";
                }
                e.FormattingApplied = true;
            }

            if (columnName == "colUpdatedDate")
            {
                object rawUpdated = GetPropertyValue(rowItem, "UpdatedDate");
                if (rawUpdated != null && DateTime.TryParse(rawUpdated.ToString(), out DateTime updatedDate) && updatedDate != DateTime.MinValue)
                {
                    e.Value = updatedDate.ToString("dd-MM-yyyy hh:mm tt");
                }
                else
                {
                    e.Value = "-";
                }
                e.FormattingApplied = true;
            }
        }

        // ==========================================
        // HELPER REFLECTION METHODS FOR NESTED DATA
        // ==========================================
        private object GetPropertyValue(object obj, string propertyName)
        {
            if (obj == null) return null;
            PropertyInfo prop = obj.GetType().GetProperty(propertyName);
            return prop?.GetValue(obj, null);
        }

        private object GetNestedPropertyValue(object obj, string propertyPath)
        {
            if (obj == null || string.IsNullOrEmpty(propertyPath)) return null;

            foreach (var part in propertyPath.Split('.'))
            {
                if (obj == null) return null;
                PropertyInfo prop = obj.GetType().GetProperty(part);
                if (prop == null) return null;
                obj = prop.GetValue(obj, null);
            }
            return obj;
        }

        private async Task LoadCounts()
        {
            lblTotalProducts.Text =
                (await _stockService.GetTotalProductsCountAsync()).ToString();

            lblLowStock.Text =
                (await _stockService.GetLowStockCountAsync()).ToString();

            lblOutOfStock.Text =
                (await _stockService.GetOutOfStockCountAsync()).ToString();

            lblInStock.Text =
                (await _stockService.GetInStockCountAsync()).ToString();
        }
        private async Task LoadStock()
        {
            FormatGrid();

            var stocks = await _stockService.GetAllStockAsync();

            //dgvStock.AutoGenerateColumns = true;

            dgvStock.DataSource = null;

            dgvStock.DataSource = stocks;

            dgvStock.ClearSelection();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dgvStock.DataSource = null;

            //dgvStock.DataSource =
            //    await _stockService.SearchStockAsync(txtSearch.Text);

            try
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    await LoadStock();
                    return;
                }

                dgvStock.DataSource = null;
                dgvStock.DataSource = await _stockService.SearchStockAsync(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLowStock_Click(object sender, EventArgs e)
        {
            //dgvStock.DataSource = null;

            //dgvStock.DataSource =
            //    await _stockService.GetLowStockAsync();

            try
            {
                dgvStock.DataSource = null;
                dgvStock.DataSource = await _stockService.GetLowStockAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnOutOfStock_Click(object sender, EventArgs e)
        {
            //dgvStock.DataSource = null;

            //dgvStock.DataSource =
            //    await _stockService.GetOutOfStockAsync();

            try
            {
                dgvStock.DataSource = null;
                dgvStock.DataSource = await _stockService.GetOutOfStockAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            //txtSearch.Clear();

            //await LoadStock();
            //await LoadStock();

            try
            {
                txtSearch.Clear();
                await LoadStock();
                await LoadCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
