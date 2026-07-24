using FontAwesome.Sharp;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Extensions.DependencyInjection;
using StockManagementSystem.Forms.BackupRestore;
using StockManagementSystem.Forms.Brands;
using StockManagementSystem.Forms.Categories;
using StockManagementSystem.Forms.History;
using StockManagementSystem.Forms.Products;
using StockManagementSystem.Forms.Purchase;
using StockManagementSystem.Forms.Reports;
using StockManagementSystem.Forms.Sales;
using StockManagementSystem.Forms.Stock;
using StockManagementSystem.Forms.Units;
using StockManagementSystem.Models.Common;
using StockManagementSystem.Models.Master;
using StockManagementSystem.Services.Dashboard;
using StockManagementSystem.Services.StockTransactionServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.Dashboard
{
    public partial class FrmDashboard : BaseForm
    {
        private readonly IStockTransactionService _stockTransactionService;
        private readonly IDashboardService _dashboardService;
        private const int SidebarExpandedWidth = 250;
        private const int SidebarCollapsedWidth = 70;
        private Form? activeForm;
        private bool isSidebarExpanded = true;
        private IconButton? currentButton;
        public FrmDashboard(IDashboardService dashboardService, IStockTransactionService stockTransactionService)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            _dashboardService = dashboardService;
            _stockTransactionService = stockTransactionService;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if (isSidebarExpanded)
            //{
            //    // Collapse
            //    pnlSidebar.Width = SidebarCollapsedWidth;
            //    isSidebarExpanded = false;

            //    SetMenuText(false);
            //    SetButtonLayout(false);
            //}
            //else
            //{
            //    // Expand
            //    pnlSidebar.Width = SidebarExpandedWidth;
            //    isSidebarExpanded = true;

            //    SetMenuText(true);
            //    SetButtonLayout(true);
            //}
            timerSidebar.Start();
        }
        const int AnimationSpeed = 25;
        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            pnlSidebar.SuspendLayout();
            if (isSidebarExpanded)
            {
                pnlSidebar.Width -= AnimationSpeed;

                if (pnlSidebar.Width <= SidebarCollapsedWidth)
                {
                    pnlSidebar.Width = SidebarCollapsedWidth;
                    timerSidebar.Stop();
                    isSidebarExpanded = false;
                    SetMenuText(false);

                    SetButtonLayout(false);
                }
            }
            else
            {
                pnlSidebar.Width += AnimationSpeed;

                if (pnlSidebar.Width >= SidebarExpandedWidth)
                {
                    pnlSidebar.Width = SidebarExpandedWidth;
                    timerSidebar.Stop();
                    isSidebarExpanded = true;

                    SetMenuText(true);
                    SetButtonLayout(true);
                }
            }
            pnlSidebar.ResumeLayout();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");
            //dtpDateTime.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");
        }
        private bool _isFormLoaded = false;
        private async void FrmDashboard_Load(object sender, EventArgs e)
        {
        //    MessageBox.Show(
        //$"Form Height = {this.Height}\n" +
        //$"Desktop Height = {pnlDesktop.Height}\n" +
        //$"Dashboard Height = {pnlDashboard.Height}\n" +
        //$"Footer Top = {pnlFooter.Top}\n" +
        //$"Footer Bottom = {pnlFooter.Bottom}"
    //);
            pnlDashboard.AutoScroll = true;
            pnlDashboard.HorizontalScroll.Enabled = false;
            pnlDashboard.HorizontalScroll.Visible = false;
            pnlDashboard.AutoScrollMinSize = new Size(0, 1200);

            pnlDashboard.Visible = true;
            pnlDesktop.Visible = false;

            lblTitle.Text = "Dashboard";

            lblUserName.Text = "Admin";

            lblDateTime.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm:ss tt");

            timerClock.Start();

            SetMenuText(true);

            SetButtonLayout(true);
            FormatRecentStockGrid();
            //LoadRecentStockDummyData();

            await LoadRecentStockAsync();

            cmbDuration.Items.Clear();

            //cmbDuration.Items.Add("Top 5");
            //cmbDuration.Items.Add("Top 10");
            //cmbDuration.Items.Add("Top 20");

            //cmbDuration.SelectedIndex = 1; // Default Top 10
            cmbDuration.Items.Add("Today");
            cmbDuration.Items.Add("This Week");
            cmbDuration.Items.Add("This Month");
            cmbDuration.Items.Add("This Year");
            cmbDuration.SelectedIndex = 2; // Default This Month
            await LoadTopSellingProductsAsync();
            await LoadDashboardAsync();
            await LoadRecentStockAsync();
            _isFormLoaded = true;
        }
        public async Task RefreshDashboardAsync()
        {
            await LoadDashboardAsync();
            await LoadRecentStockAsync();
            await LoadTopSellingProductsAsync();
        }
        //private async Task LoadTopSellingProductsAsync()
        //{
        //    flpTopSelling.Controls.Clear();

        //    //var products = await _dashboardService.GetTopSellingProductsAsync();
        //    string duration = cmbDuration.Text;

        //    var products =
        //    await _dashboardService.GetTopSellingProductsAsync(duration);
        //    foreach (var item in products)
        //    {
        //        var card = new ucTopSellingProduct();

        //        card.SetData(item);

        //        flpTopSelling.Controls.Add(card);
        //    }
        //}
        private async Task LoadTopSellingProductsAsync()
        {
            flpTopSelling.Controls.Clear();

            string duration = cmbDuration.Text;

            var products = await _dashboardService.GetTopSellingProductsAsync(duration);

            foreach (var item in products)
            {
                var card = new ucTopSellingProduct();

                // 👇 Full Width
                card.Width = flpTopSelling.ClientSize.Width;
                card.Margin = new Padding(0);

                card.SetData(item);

                flpTopSelling.Controls.Add(card);
            }
        }
        private void FormatRecentStockGrid()
        {
            dgvRecentStock.EnableHeadersVisualStyles = false;

            dgvRecentStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 130, 246);
            dgvRecentStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecentStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvRecentStock.ColumnHeadersHeight = 40;
            dgvRecentStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvRecentStock.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvRecentStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvRecentStock.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvRecentStock.RowTemplate.Height = 35;

            dgvRecentStock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            dgvRecentStock.GridColor = Color.Gainsboro;

            dgvRecentStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadRecentStockAsync()
        {
            dgvRecentStock.Rows.Clear();

            var transactions = await _stockTransactionService.GetRecentTransactionsAsync(10);

            foreach (var item in transactions)
            {
                string type = item.TransactionType switch
                {
                    TransactionType.Purchase => "Stock In",
                    TransactionType.Sale => "Stock Out",
                    TransactionType.Adjustment => "Adjustment",
                    TransactionType.OpeningStock => "Opening Stock",
                    _ => item.TransactionType.ToString()
                };

                dgvRecentStock.Rows.Add(
                    item.CreatedDate.ToString("dd MMM yyyy"),
                    type,
                    item.Product?.ProductName ?? "",
                    item.Quantity,
                    item.Remarks ?? ""
                );
            }
        }
        private void LoadRecentStockDummyData()
        {
            dgvRecentStock.Rows.Clear();

            dgvRecentStock.Rows.Add(
                DateTime.Now.ToString("dd MMM yyyy"),
                "Stock In",
                "LED Headlight",
                20,
                "Purchase");

            dgvRecentStock.Rows.Add(
                DateTime.Now.ToString("dd MMM yyyy"),
                "Stock Out",
                "Car Charger",
                5,
                "Sale");

            dgvRecentStock.Rows.Add(
                DateTime.Now.ToString("dd MMM yyyy"),
                "Stock In",
                "Seat Cover",
                10,
                "Purchase");
        }
        private async Task LoadDashboardAsync()
        {
            var dashboard = await _dashboardService.GetDashboardSummaryAsync();

            lblTotalProducts.Text = dashboard.TotalProducts.ToString();

            lblTotalCategories.Text = dashboard.TotalCategories.ToString();

            lblTotalBrands.Text = dashboard.TotalBrands.ToString();

            lblTotalUnits.Text = dashboard.TotalUnits.ToString();

            lblPurchaseAmount.Text = dashboard.TotalPurchaseAmount.ToString("N2");

            lblSalesAmount.Text = dashboard.TotalSalesAmount.ToString("N2");

            lblCurrentStock.Text = dashboard.CurrentStock.ToString();

            lblLowStock.Text = dashboard.LowStockProducts.ToString();


            //await LoadSalesChartAsync();
            await LoadSalesChartAsync(cmbDuration.Text);
            await LoadStockChartAsync();
        }

        private async Task LoadSalesChartAsync(string dt)
        {
            var data = await _dashboardService.GetSalesChartAsync(dt);

            cartesianChart1.Series = new ISeries[]
            {
        new LineSeries<decimal>
        {
            Values = data.Select(x => x.TotalSales).ToArray(),
            Name = "Sales"
        }
            };

            cartesianChart1.XAxes = new Axis[]
            {
        new Axis
        {
            Labels = data.Select(x => x.Month).ToArray()
        }
            };
        }
        //private async Task LoadStockChartAsync()
        //{
        //    var data = await _dashboardService.GetStockChartAsync();

        //    pieChart1.Series = data
        //        .Select(x => new PieSeries<int>
        //        {
        //            Values = new[] { x.Total },
        //            Name = x.Status
        //        })
        //        .Cast<ISeries>()
        //        .ToArray();
        //}

        private async Task LoadStockChartAsync()
        {
            var data = await _dashboardService.GetStockChartAsync();

            int total = data.Sum(x => x.Total);

            var inStock = data.FirstOrDefault(x => x.Status == "In Stock");
            var lowStock = data.FirstOrDefault(x => x.Status == "Low Stock");
            var outStock = data.FirstOrDefault(x => x.Status == "Out of Stock");

            pieChart1.Series = data
                .Select(x => new PieSeries<int>
                {
                    Values = new[] { x.Total },
                    Name = x.Status,

                    InnerRadius = 60,      // Donut Chart

                    DataLabelsSize = 0      // Chart ke upar values mat dikhao
                })
                .Cast<ISeries>()
                .ToArray();

            if (total > 0)
            {
                lblInStockValue.Text =
                    $"{inStock?.Total ?? 0} ({((inStock?.Total ?? 0) * 100.0 / total):0.00}%)";

                lblLowStockValue.Text =
                    $"{lowStock?.Total ?? 0} ({((lowStock?.Total ?? 0) * 100.0 / total):0.00}%)";

                lblOutStockValue.Text =
                    $"{outStock?.Total ?? 0} ({((outStock?.Total ?? 0) * 100.0 / total):0.00}%)";
            }
            else
            {
                lblInStockValue.Text = "0 (0.00%)";
                lblLowStockValue.Text = "0 (0.00%)";
                lblOutStockValue.Text = "0 (0.00%)";
            }
        }
        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }

        //    activeForm = childForm;
        //    pnlDashboardCards.Visible = false;
        //    pnlChartSection.Visible = false;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;

        //    //pnlDesktop.Controls.Clear();
        //    pnlMain.Controls.Add(childForm);
        //    pnlMain.Tag = childForm;

        //    childForm.BringToFront();
        //    childForm.Show();
        //}
        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //        activeForm.Dispose();
        //        activeForm = null;
        //    }

        //    activeForm = childForm;

        //    // Dashboard Hide
        //    pnlDashboard.Visible = false;

        //    // Desktop Show
        //    pnlDesktop.Visible = true;

        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;

        //    pnlDesktop.Controls.Clear();      // Sirf child forms ke liye
        //    pnlDesktop.Controls.Add(childForm);

        //    childForm.Show();
        //    childForm.BringToFront();
        //}

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            activeForm = childForm;

            pnlDashboard.Visible = false;
            pnlDesktop.Visible = true;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Clear();
            pnlDesktop.Controls.Add(childForm);

            childForm.Show();
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCategory);
            OpenChildForm(Program.Services.GetRequiredService<FrmCategory>());

            lblTitle.Text = "Category";
        }

        private async void btnDashboard_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pnlMain.Controls.Count.ToString());
            //ActivateButton(btnDashboard);

            //if (activeForm != null)
            //{
            //    activeForm.Close();
            //    activeForm = null;
            //}
            //pnlDashboardCards.Visible = true;
            //pnlChartSection.Visible = true;
            ////pnlDesktop.Controls.Clear();

            //lblTitle.Text = "Dashboard";
            //await LoadDashboardAsync();

            ActivateButton(btnDashboard);

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }

            // Desktop Clear
            pnlDesktop.Controls.Clear();
            pnlDesktop.Visible = false;

            // Dashboard Show
            pnlDashboard.Visible = true;
            pnlDashboard.BringToFront();

            lblTitle.Text = "Dashboard";

            //await LoadDashboardAsync();
            await RefreshDashboardAsync();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }


        private void ActivateButton(IconButton button)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 41, 55);
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
            }

            currentButton = button;

            currentButton.BackColor = Color.FromArgb(59, 130, 246);
            currentButton.ForeColor = Color.White;
            currentButton.IconColor = Color.White;
        }

        private void SetMenuText(bool expanded)
        {
            btnDashboard.Text = expanded ? " Dashboard" : "";
            //btnMasters.Text = expanded ? " Masters" : "";
            btnCategory.Text = expanded ? " Category" : "";
            btnBrand.Text = expanded ? " Brands" : "";
            btnUnit.Text = expanded ? " Unit" : "";
            //tnSupplier.Text = expanded ? " Supplier" : "";
            //btnCustomer.Text = expanded ? " Customer" : "";
            btnProduct.Text = expanded ? " Product" : "";
            btnPurchase.Text = expanded ? " Purchase" : "";
            btnSales.Text = expanded ? " Sales" : "";
            btnStock.Text = expanded ? " Stock" : "";
            btnReports.Text = expanded ? " Reports" : "";
            btnHistory.Text = expanded ? " History" : "";
            btnSetting.Text = expanded ? " Settings" : "";
            btnLogOut.Text = expanded ? " LogOut" : "";
            btnBackupRestore.Text = expanded ? " Backup/Restore" : "";
        }

        private void SetButtonLayout(bool expanded)
        {
            IconButton[] buttons =
            {
        btnDashboard,
        btnCategory,
        btnBackupRestore
    };

            foreach (var button in buttons)
            {
                if (expanded)
                {
                    button.TextImageRelation = TextImageRelation.ImageBeforeText;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.TextAlign = ContentAlignment.MiddleLeft;
                    button.Padding = new Padding(15, 0, 0, 0);
                }
                else
                {
                    button.TextImageRelation = TextImageRelation.Overlay;
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Padding = new Padding(0);
                }
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBrand);

            OpenChildForm(Program.Services.GetRequiredService<FrmBrand>());


            lblTitle.Text = "Brand";
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            ActivateButton(btnUnit);

            OpenChildForm(Program.Services.GetRequiredService<FrmUnit>());

            lblTitle.Text = "Unit";
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProduct);

            OpenChildForm(Program.Services.GetRequiredService<FrmProduct>());

            lblTitle.Text = "Product";
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ActivateButton(btnPurchase);

            OpenChildForm(Program.Services.GetRequiredService<FrmPurchase>());

            lblTitle.Text = "Purchase";
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSales);

            OpenChildForm(Program.Services.GetRequiredService<FrmSale>());

            lblTitle.Text = "Sale";
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ActivateButton(btnStock);

            OpenChildForm(Program.Services.GetRequiredService<FrmStock>());

            lblTitle.Text = "Stock";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReports);

            OpenChildForm(Program.Services.GetRequiredService<RrmReports>());

            lblTitle.Text = "Reports";
        }

        private async void cmbDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isFormLoaded)
                return;

            await LoadTopSellingProductsAsync();
            await LoadSalesChartAsync(cmbDuration.Text);
        }

        private void flpTopSelling_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flpTopSelling.Controls)
            {
                control.Width = flpTopSelling.ClientSize.Width;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(btnHistory);

            OpenChildForm(Program.Services.GetRequiredService<FrmHistory>());

            lblTitle.Text = "History";
        }

        private void lnkViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenChildForm(Program.Services.GetRequiredService<FrmHistory>());
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBackupRestore);
            OpenChildForm(Program.Services.GetRequiredService<FrmBackupRestore>());

            lblTitle.Text = "Backup and Restore data";
        }
    }
}
