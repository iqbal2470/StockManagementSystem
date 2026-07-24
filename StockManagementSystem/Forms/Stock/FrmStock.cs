using StockManagementSystem.Models.Common;
using StockManagementSystem.Services.StockServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private async void FrmStock_Load(object sender, EventArgs e)
        {
            await LoadStock();
            await LoadCounts();
            dgvStock.ClearSelection();
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
            var stocks = await _stockService.GetAllStockAsync();

            dgvStock.AutoGenerateColumns = true;

            dgvStock.DataSource = null;

            dgvStock.DataSource = stocks;

            dgvStock.ClearSelection();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStock.DataSource = null;

            dgvStock.DataSource =
                await _stockService.SearchStockAsync(txtSearch.Text);
        }

        private async void btnLowStock_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = null;

            dgvStock.DataSource =
                await _stockService.GetLowStockAsync();
        }

        private async void btnOutOfStock_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = null;

            dgvStock.DataSource =
                await _stockService.GetOutOfStockAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            await LoadStock();
            await LoadStock();
        }
    }
}
