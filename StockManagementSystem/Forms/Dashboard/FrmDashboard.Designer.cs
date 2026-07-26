namespace StockManagementSystem.Forms.Dashboard
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
            label1 = new Label();
            pnlSidebar = new Panel();
            pnlMenu = new Panel();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox9 = new PictureBox();
            btnBackupRestore = new FontAwesome.Sharp.IconButton();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnHistory = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            btnStock = new FontAwesome.Sharp.IconButton();
            btnSales = new FontAwesome.Sharp.IconButton();
            btnPurchase = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnUnit = new FontAwesome.Sharp.IconButton();
            btnBrand = new FontAwesome.Sharp.IconButton();
            btnCategory = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnlHeader = new Panel();
            panel10 = new Panel();
            pictureBox8 = new PictureBox();
            lblUserName = new Label();
            lblTitle = new Label();
            label19 = new Label();
            btnMenu = new FontAwesome.Sharp.IconButton();
            lblDateTime = new Label();
            pnlMain = new Panel();
            pnlDesktop = new Panel();
            pnlFooter = new Panel();
            label18 = new Label();
            pnlDashboard = new Panel();
            pnlBottomSection = new Panel();
            tblBottomSection = new TableLayoutPanel();
            pnlRecentStock = new Panel();
            tblRecentStock = new TableLayoutPanel();
            pnlRecentHeader = new Panel();
            lblRecentStock = new Label();
            dgvRecentStock = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewTextBoxColumn();
            pnlRecentFooter = new Panel();
            lnkViewAll = new LinkLabel();
            pnlTopSelling = new Panel();
            tblTopSelling = new TableLayoutPanel();
            pnlTopHeader = new Panel();
            cmbDuration = new ComboBox();
            lblTopSelling = new Label();
            flpTopSelling = new FlowLayoutPanel();
            pnlChartSection = new Panel();
            tblCharts = new TableLayoutPanel();
            pnlSalesChart = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label15 = new Label();
            pnlStockChart = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            flpStockLegend = new FlowLayoutPanel();
            pnlInStock = new Panel();
            lblInStockValue = new Label();
            lblInStock = new Label();
            pnlGreen = new Panel();
            pnlLowStocks = new Panel();
            lblLowStockValue = new Label();
            lblLowStocks = new Label();
            panel11 = new Panel();
            pnlOutStock = new Panel();
            lblOutStockValue = new Label();
            lblOutStock = new Label();
            panel12 = new Panel();
            label17 = new Label();
            pnlDashboardCards = new Panel();
            tblDashboardCards = new TableLayoutPanel();
            pnlTotalBrands = new Panel();
            panel9 = new Panel();
            pictureBox7 = new PictureBox();
            label13 = new Label();
            lblTotalBrands = new Label();
            label16 = new Label();
            pnlLowStock = new Panel();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label11 = new Label();
            lblLowStock = new Label();
            label14 = new Label();
            pnlCurrentStock = new Panel();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            lblCurrentStock = new Label();
            label12 = new Label();
            pnlTotalSales = new Panel();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            lblSalesAmount = new Label();
            label10 = new Label();
            pnlTotalPurchase = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblPurchaseAmount = new Label();
            label8 = new Label();
            pnlTotalUnits = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblTotalUnits = new Label();
            label6 = new Label();
            pnlTotalCategories = new Panel();
            panel3 = new Panel();
            pictureBox10 = new PictureBox();
            label2 = new Label();
            lblTotalCategories = new Label();
            label4 = new Label();
            pnlTotalProducts = new Panel();
            panel2 = new Panel();
            picProducts = new PictureBox();
            lblProductDesc = new Label();
            lblTotalProducts = new Label();
            lblProductsTitle = new Label();
            timerSidebar = new System.Windows.Forms.Timer(components);
            timerClock = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnlMain.SuspendLayout();
            pnlDesktop.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlBottomSection.SuspendLayout();
            tblBottomSection.SuspendLayout();
            pnlRecentStock.SuspendLayout();
            tblRecentStock.SuspendLayout();
            pnlRecentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentStock).BeginInit();
            pnlRecentFooter.SuspendLayout();
            pnlTopSelling.SuspendLayout();
            tblTopSelling.SuspendLayout();
            pnlTopHeader.SuspendLayout();
            pnlChartSection.SuspendLayout();
            tblCharts.SuspendLayout();
            pnlSalesChart.SuspendLayout();
            pnlStockChart.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpStockLegend.SuspendLayout();
            pnlInStock.SuspendLayout();
            pnlLowStocks.SuspendLayout();
            pnlOutStock.SuspendLayout();
            pnlDashboardCards.SuspendLayout();
            tblDashboardCards.SuspendLayout();
            pnlTotalBrands.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pnlLowStock.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlCurrentStock.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlTotalSales.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlTotalPurchase.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTotalUnits.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTotalCategories.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            pnlTotalProducts.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 56);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(31, 41, 55);
            pnlSidebar.Controls.Add(pnlMenu);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 1050);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.AutoScroll = true;
            pnlMenu.Controls.Add(btnLogOut);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(btnBackupRestore);
            pnlMenu.Controls.Add(btnSetting);
            pnlMenu.Controls.Add(btnHistory);
            pnlMenu.Controls.Add(btnReports);
            pnlMenu.Controls.Add(btnStock);
            pnlMenu.Controls.Add(btnSales);
            pnlMenu.Controls.Add(btnPurchase);
            pnlMenu.Controls.Add(btnProduct);
            pnlMenu.Controls.Add(btnUnit);
            pnlMenu.Controls.Add(btnBrand);
            pnlMenu.Controls.Add(btnCategory);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 70);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 980);
            pnlMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogOut.ForeColor = SystemColors.ControlLightLight;
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnLogOut.IconColor = Color.White;
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.IconSize = 24;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 408);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(15, 0, 0, 0);
            btnLogOut.Size = new Size(250, 34);
            btnLogOut.TabIndex = 20;
            btnLogOut.Text = "LogOut";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox9);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 736);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 244);
            panel1.TabIndex = 19;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Image = Properties.Resources.ChatGPT_Image_Jul_23__2026__03_25_17_PM_removebg_preview;
            pictureBox9.Location = new Point(0, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(250, 202);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 17;
            pictureBox9.TabStop = false;
            // 
            // btnBackupRestore
            // 
            btnBackupRestore.Dock = DockStyle.Top;
            btnBackupRestore.FlatAppearance.BorderSize = 0;
            btnBackupRestore.FlatStyle = FlatStyle.Flat;
            btnBackupRestore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBackupRestore.ForeColor = SystemColors.ControlLightLight;
            btnBackupRestore.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnBackupRestore.IconColor = Color.White;
            btnBackupRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBackupRestore.IconSize = 24;
            btnBackupRestore.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackupRestore.Location = new Point(0, 374);
            btnBackupRestore.Name = "btnBackupRestore";
            btnBackupRestore.Padding = new Padding(15, 0, 0, 0);
            btnBackupRestore.Size = new Size(250, 34);
            btnBackupRestore.TabIndex = 18;
            btnBackupRestore.Text = "Backup/Restore";
            btnBackupRestore.TextAlign = ContentAlignment.MiddleLeft;
            btnBackupRestore.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackupRestore.UseVisualStyleBackColor = true;
            btnBackupRestore.Click += btnBackupRestore_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSetting.ForeColor = SystemColors.ControlLightLight;
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Github;
            btnSetting.IconColor = Color.White;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.IconSize = 24;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 340);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(15, 0, 0, 0);
            btnSetting.Size = new Size(250, 34);
            btnSetting.TabIndex = 16;
            btnSetting.Text = "Settings";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistory.ForeColor = SystemColors.ControlLightLight;
            btnHistory.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnHistory.IconColor = Color.White;
            btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistory.IconSize = 24;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 306);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(15, 0, 0, 0);
            btnHistory.Size = new Size(250, 34);
            btnHistory.TabIndex = 15;
            btnHistory.Text = "History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReports.ForeColor = SystemColors.ControlLightLight;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnReports.IconColor = Color.White;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.IconSize = 24;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 272);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(15, 0, 0, 0);
            btnReports.Size = new Size(250, 34);
            btnReports.TabIndex = 14;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStock.ForeColor = SystemColors.ControlLightLight;
            btnStock.IconChar = FontAwesome.Sharp.IconChar.Box;
            btnStock.IconColor = Color.White;
            btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStock.IconSize = 24;
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(0, 238);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(15, 0, 0, 0);
            btnStock.Size = new Size(250, 34);
            btnStock.TabIndex = 13;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSales.ForeColor = SystemColors.ControlLightLight;
            btnSales.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnSales.IconColor = Color.White;
            btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSales.IconSize = 24;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 204);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(15, 0, 0, 0);
            btnSales.Size = new Size(250, 34);
            btnSales.TabIndex = 12;
            btnSales.Text = "Sales";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.Dock = DockStyle.Top;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPurchase.ForeColor = SystemColors.ControlLightLight;
            btnPurchase.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnPurchase.IconColor = Color.White;
            btnPurchase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPurchase.IconSize = 24;
            btnPurchase.ImageAlign = ContentAlignment.MiddleLeft;
            btnPurchase.Location = new Point(0, 170);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Padding = new Padding(15, 0, 0, 0);
            btnPurchase.Size = new Size(250, 34);
            btnPurchase.TabIndex = 11;
            btnPurchase.Text = "Purchase";
            btnPurchase.TextAlign = ContentAlignment.MiddleLeft;
            btnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.ForeColor = SystemColors.ControlLightLight;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            btnProduct.IconColor = Color.White;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 24;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 136);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(15, 0, 0, 0);
            btnProduct.Size = new Size(250, 34);
            btnProduct.TabIndex = 10;
            btnProduct.Text = "Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnUnit
            // 
            btnUnit.Dock = DockStyle.Top;
            btnUnit.FlatAppearance.BorderSize = 0;
            btnUnit.FlatStyle = FlatStyle.Flat;
            btnUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUnit.ForeColor = SystemColors.ControlLightLight;
            btnUnit.IconChar = FontAwesome.Sharp.IconChar.RulerCombined;
            btnUnit.IconColor = Color.White;
            btnUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUnit.IconSize = 24;
            btnUnit.ImageAlign = ContentAlignment.MiddleLeft;
            btnUnit.Location = new Point(0, 102);
            btnUnit.Name = "btnUnit";
            btnUnit.Padding = new Padding(15, 0, 0, 0);
            btnUnit.Size = new Size(250, 34);
            btnUnit.TabIndex = 9;
            btnUnit.Text = "Unit";
            btnUnit.TextAlign = ContentAlignment.MiddleLeft;
            btnUnit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUnit.UseVisualStyleBackColor = true;
            btnUnit.Click += btnUnit_Click;
            // 
            // btnBrand
            // 
            btnBrand.Dock = DockStyle.Top;
            btnBrand.FlatAppearance.BorderSize = 0;
            btnBrand.FlatStyle = FlatStyle.Flat;
            btnBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrand.ForeColor = SystemColors.ControlLightLight;
            btnBrand.IconChar = FontAwesome.Sharp.IconChar.Award;
            btnBrand.IconColor = Color.White;
            btnBrand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrand.IconSize = 24;
            btnBrand.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrand.Location = new Point(0, 68);
            btnBrand.Name = "btnBrand";
            btnBrand.Padding = new Padding(15, 0, 0, 0);
            btnBrand.Size = new Size(250, 34);
            btnBrand.TabIndex = 8;
            btnBrand.Text = "Brand";
            btnBrand.TextAlign = ContentAlignment.MiddleLeft;
            btnBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrand.UseVisualStyleBackColor = true;
            btnBrand.Click += btnBrand_Click;
            // 
            // btnCategory
            // 
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCategory.ForeColor = SystemColors.ControlLightLight;
            btnCategory.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnCategory.IconColor = Color.White;
            btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCategory.IconSize = 24;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 34);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(15, 0, 0, 0);
            btnCategory.Size = new Size(250, 34);
            btnCategory.TabIndex = 6;
            btnCategory.Text = "Category";
            btnCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = SystemColors.ControlLightLight;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 24;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(250, 34);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 70);
            pnlLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_Jul_23__2026__03_25_17_PM_removebg_preview;
            pictureBox1.Location = new Point(-28, -22);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(panel10);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(label19);
            pnlHeader.Controls.Add(btnMenu);
            pnlHeader.Controls.Add(lblDateTime);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1114, 70);
            pnlHeader.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(lblUserName);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(943, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(171, 70);
            panel10.TabIndex = 10;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Image = Properties.Resources.profile;
            pictureBox8.Location = new Point(30, 21);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.Location = new Point(71, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(68, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Admin";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(30, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 10F);
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(32, 38);
            label19.Name = "label19";
            label19.Size = new Size(570, 28);
            label19.TabIndex = 8;
            label19.Text = "Welcome back, Admin! Here's what's happening with your store.";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenu.ForeColor = SystemColors.ActiveCaptionText;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.Black;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 24;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(15, 0, 0, 0);
            btnMenu.Size = new Size(55, 70);
            btnMenu.TabIndex = 7;
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Visible = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateTime.AutoSize = true;
            lblDateTime.BorderStyle = BorderStyle.FixedSingle;
            lblDateTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateTime.Location = new Point(807, 17);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Padding = new Padding(5);
            lblDateTime.Size = new Size(118, 37);
            lblDateTime.TabIndex = 2;
            lblDateTime.Text = "21 Jul 2026";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Transparent;
            pnlMain.BackgroundImageLayout = ImageLayout.Center;
            pnlMain.Controls.Add(pnlDesktop);
            pnlMain.Controls.Add(pnlDashboard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(250, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(10, 10, 10, 40);
            pnlMain.Size = new Size(1114, 980);
            pnlMain.TabIndex = 3;
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlFooter);
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(10, 913);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1094, 27);
            pnlDesktop.TabIndex = 3;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(label18);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(0, 0);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1094, 27);
            pnlFooter.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = SystemColors.MenuHighlight;
            label18.Location = new Point(283, 5);
            label18.Name = "label18";
            label18.Size = new Size(526, 25);
            label18.TabIndex = 0;
            label18.Text = "© 2026 Car Accessories Store | Version 1.0.0 | All Rights Reserved";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlBottomSection);
            pnlDashboard.Controls.Add(pnlChartSection);
            pnlDashboard.Controls.Add(pnlDashboardCards);
            pnlDashboard.Dock = DockStyle.Top;
            pnlDashboard.Location = new Point(10, 10);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1094, 903);
            pnlDashboard.TabIndex = 2;
            // 
            // pnlBottomSection
            // 
            pnlBottomSection.BackColor = Color.WhiteSmoke;
            pnlBottomSection.Controls.Add(tblBottomSection);
            pnlBottomSection.Dock = DockStyle.Fill;
            pnlBottomSection.Location = new Point(0, 596);
            pnlBottomSection.Name = "pnlBottomSection";
            pnlBottomSection.Size = new Size(1094, 307);
            pnlBottomSection.TabIndex = 0;
            // 
            // tblBottomSection
            // 
            tblBottomSection.ColumnCount = 2;
            tblBottomSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblBottomSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblBottomSection.Controls.Add(pnlRecentStock, 0, 0);
            tblBottomSection.Controls.Add(pnlTopSelling, 1, 0);
            tblBottomSection.Dock = DockStyle.Fill;
            tblBottomSection.Location = new Point(0, 0);
            tblBottomSection.Name = "tblBottomSection";
            tblBottomSection.RowCount = 1;
            tblBottomSection.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBottomSection.Size = new Size(1094, 307);
            tblBottomSection.TabIndex = 0;
            // 
            // pnlRecentStock
            // 
            pnlRecentStock.BackColor = Color.White;
            pnlRecentStock.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentStock.Controls.Add(tblRecentStock);
            pnlRecentStock.Dock = DockStyle.Fill;
            pnlRecentStock.Location = new Point(10, 10);
            pnlRecentStock.Margin = new Padding(10);
            pnlRecentStock.Name = "pnlRecentStock";
            pnlRecentStock.Padding = new Padding(10);
            pnlRecentStock.Size = new Size(636, 287);
            pnlRecentStock.TabIndex = 0;
            // 
            // tblRecentStock
            // 
            tblRecentStock.ColumnCount = 1;
            tblRecentStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecentStock.Controls.Add(pnlRecentHeader, 0, 0);
            tblRecentStock.Controls.Add(dgvRecentStock, 0, 1);
            tblRecentStock.Controls.Add(pnlRecentFooter, 0, 2);
            tblRecentStock.Dock = DockStyle.Fill;
            tblRecentStock.Location = new Point(10, 10);
            tblRecentStock.Name = "tblRecentStock";
            tblRecentStock.RowCount = 3;
            tblRecentStock.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblRecentStock.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblRecentStock.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblRecentStock.Size = new Size(614, 265);
            tblRecentStock.TabIndex = 0;
            // 
            // pnlRecentHeader
            // 
            pnlRecentHeader.Controls.Add(lblRecentStock);
            pnlRecentHeader.Dock = DockStyle.Fill;
            pnlRecentHeader.Location = new Point(3, 3);
            pnlRecentHeader.Name = "pnlRecentHeader";
            pnlRecentHeader.Size = new Size(608, 39);
            pnlRecentHeader.TabIndex = 0;
            // 
            // lblRecentStock
            // 
            lblRecentStock.AutoSize = true;
            lblRecentStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentStock.Location = new Point(10, 10);
            lblRecentStock.Name = "lblRecentStock";
            lblRecentStock.Size = new Size(273, 30);
            lblRecentStock.TabIndex = 0;
            lblRecentStock.Text = "Recent Stock Movements";
            // 
            // dgvRecentStock
            // 
            dgvRecentStock.AllowUserToAddRows = false;
            dgvRecentStock.AllowUserToDeleteRows = false;
            dgvRecentStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentStock.BorderStyle = BorderStyle.None;
            dgvRecentStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentStock.Columns.AddRange(new DataGridViewColumn[] { colDate, colType, colProduct, colQuantity, colDetails });
            dgvRecentStock.Dock = DockStyle.Fill;
            dgvRecentStock.Location = new Point(3, 48);
            dgvRecentStock.MultiSelect = false;
            dgvRecentStock.Name = "dgvRecentStock";
            dgvRecentStock.ReadOnly = true;
            dgvRecentStock.RowHeadersVisible = false;
            dgvRecentStock.RowHeadersWidth = 62;
            dgvRecentStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentStock.Size = new Size(608, 179);
            dgvRecentStock.TabIndex = 1;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 8;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 8;
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colProduct
            // 
            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 8;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colDetails
            // 
            colDetails.HeaderText = "Details";
            colDetails.MinimumWidth = 8;
            colDetails.Name = "colDetails";
            colDetails.ReadOnly = true;
            // 
            // pnlRecentFooter
            // 
            pnlRecentFooter.Controls.Add(lnkViewAll);
            pnlRecentFooter.Dock = DockStyle.Fill;
            pnlRecentFooter.Location = new Point(3, 233);
            pnlRecentFooter.Name = "pnlRecentFooter";
            pnlRecentFooter.Size = new Size(608, 29);
            pnlRecentFooter.TabIndex = 2;
            // 
            // lnkViewAll
            // 
            lnkViewAll.AutoSize = true;
            lnkViewAll.Location = new Point(10, 5);
            lnkViewAll.Name = "lnkViewAll";
            lnkViewAll.Size = new Size(221, 25);
            lnkViewAll.TabIndex = 0;
            lnkViewAll.TabStop = true;
            lnkViewAll.Text = "View All Stock Movements";
            lnkViewAll.LinkClicked += lnkViewAll_LinkClicked;
            // 
            // pnlTopSelling
            // 
            pnlTopSelling.BackColor = Color.White;
            pnlTopSelling.BorderStyle = BorderStyle.FixedSingle;
            pnlTopSelling.Controls.Add(tblTopSelling);
            pnlTopSelling.Dock = DockStyle.Fill;
            pnlTopSelling.Location = new Point(666, 10);
            pnlTopSelling.Margin = new Padding(10);
            pnlTopSelling.Name = "pnlTopSelling";
            pnlTopSelling.Padding = new Padding(10);
            pnlTopSelling.Size = new Size(418, 287);
            pnlTopSelling.TabIndex = 1;
            // 
            // tblTopSelling
            // 
            tblTopSelling.ColumnCount = 1;
            tblTopSelling.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTopSelling.Controls.Add(pnlTopHeader, 0, 0);
            tblTopSelling.Controls.Add(flpTopSelling, 0, 1);
            tblTopSelling.Dock = DockStyle.Fill;
            tblTopSelling.Location = new Point(10, 10);
            tblTopSelling.Name = "tblTopSelling";
            tblTopSelling.RowCount = 2;
            tblTopSelling.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblTopSelling.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTopSelling.Size = new Size(396, 265);
            tblTopSelling.TabIndex = 0;
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.Controls.Add(cmbDuration);
            pnlTopHeader.Controls.Add(lblTopSelling);
            pnlTopHeader.Dock = DockStyle.Fill;
            pnlTopHeader.Location = new Point(3, 3);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(390, 44);
            pnlTopHeader.TabIndex = 0;
            // 
            // cmbDuration
            // 
            cmbDuration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Location = new Point(270, 6);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(110, 33);
            cmbDuration.TabIndex = 1;
            cmbDuration.SelectedIndexChanged += cmbDuration_SelectedIndexChanged;
            // 
            // lblTopSelling
            // 
            lblTopSelling.AutoSize = true;
            lblTopSelling.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTopSelling.Location = new Point(10, 12);
            lblTopSelling.Name = "lblTopSelling";
            lblTopSelling.Size = new Size(225, 30);
            lblTopSelling.TabIndex = 0;
            lblTopSelling.Text = "Top Selling Products";
            // 
            // flpTopSelling
            // 
            flpTopSelling.AutoScroll = true;
            flpTopSelling.Dock = DockStyle.Fill;
            flpTopSelling.FlowDirection = FlowDirection.TopDown;
            flpTopSelling.Location = new Point(3, 53);
            flpTopSelling.Name = "flpTopSelling";
            flpTopSelling.Padding = new Padding(5);
            flpTopSelling.Size = new Size(390, 209);
            flpTopSelling.TabIndex = 1;
            flpTopSelling.WrapContents = false;
            flpTopSelling.SizeChanged += flpTopSelling_SizeChanged;
            // 
            // pnlChartSection
            // 
            pnlChartSection.BackColor = Color.WhiteSmoke;
            pnlChartSection.Controls.Add(tblCharts);
            pnlChartSection.Dock = DockStyle.Top;
            pnlChartSection.Location = new Point(0, 295);
            pnlChartSection.Name = "pnlChartSection";
            pnlChartSection.Size = new Size(1094, 301);
            pnlChartSection.TabIndex = 1;
            // 
            // tblCharts
            // 
            tblCharts.ColumnCount = 2;
            tblCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.065815F));
            tblCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.934185F));
            tblCharts.Controls.Add(pnlSalesChart, 0, 0);
            tblCharts.Controls.Add(pnlStockChart, 1, 0);
            tblCharts.Dock = DockStyle.Fill;
            tblCharts.Location = new Point(0, 0);
            tblCharts.Name = "tblCharts";
            tblCharts.RowCount = 1;
            tblCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCharts.Size = new Size(1094, 301);
            tblCharts.TabIndex = 0;
            // 
            // pnlSalesChart
            // 
            pnlSalesChart.BackColor = Color.White;
            pnlSalesChart.BorderStyle = BorderStyle.FixedSingle;
            pnlSalesChart.Controls.Add(cartesianChart1);
            pnlSalesChart.Controls.Add(label15);
            pnlSalesChart.Dock = DockStyle.Fill;
            pnlSalesChart.Location = new Point(10, 10);
            pnlSalesChart.Margin = new Padding(10);
            pnlSalesChart.Name = "pnlSalesChart";
            pnlSalesChart.Size = new Size(659, 281);
            pnlSalesChart.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.ChartTheme = null;
            cartesianChart1.Dock = DockStyle.Bottom;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart1.Legend = skDefaultLegend1;
            cartesianChart1.Location = new Point(0, 54);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(657, 225);
            cartesianChart1.TabIndex = 1;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart1.Tooltip = skDefaultTooltip1;
            cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(4, 1);
            label15.Name = "label15";
            label15.Size = new Size(170, 30);
            label15.TabIndex = 0;
            label15.Text = "Sales Overview";
            // 
            // pnlStockChart
            // 
            pnlStockChart.BackColor = Color.White;
            pnlStockChart.BorderStyle = BorderStyle.FixedSingle;
            pnlStockChart.Controls.Add(tableLayoutPanel1);
            pnlStockChart.Controls.Add(label17);
            pnlStockChart.Dock = DockStyle.Fill;
            pnlStockChart.Location = new Point(689, 10);
            pnlStockChart.Margin = new Padding(10);
            pnlStockChart.Name = "pnlStockChart";
            pnlStockChart.Size = new Size(395, 281);
            pnlStockChart.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.9083977F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.0916023F));
            tableLayoutPanel1.Controls.Add(pieChart1, 0, 0);
            tableLayoutPanel1.Controls.Add(flpStockLegend, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(393, 245);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pieChart1
            // 
            pieChart1.AutoUpdateEnabled = true;
            pieChart1.ChartTheme = null;
            pieChart1.Dock = DockStyle.Fill;
            skDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend2.Content = null;
            skDefaultLegend2.IsValid = false;
            skDefaultLegend2.Opacity = 1F;
            padding3.Bottom = 0F;
            padding3.Left = 0F;
            padding3.Right = 0F;
            padding3.Top = 0F;
            skDefaultLegend2.Padding = padding3;
            skDefaultLegend2.RemoveOnCompleted = false;
            skDefaultLegend2.RotateTransform = 0F;
            skDefaultLegend2.X = 0F;
            skDefaultLegend2.Y = 0F;
            pieChart1.Legend = skDefaultLegend2;
            pieChart1.Location = new Point(3, 3);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(198, 239);
            pieChart1.TabIndex = 2;
            skDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip2.Content = null;
            skDefaultTooltip2.IsValid = false;
            skDefaultTooltip2.Opacity = 1F;
            padding4.Bottom = 0F;
            padding4.Left = 0F;
            padding4.Right = 0F;
            padding4.Top = 0F;
            skDefaultTooltip2.Padding = padding4;
            skDefaultTooltip2.RemoveOnCompleted = false;
            skDefaultTooltip2.RotateTransform = 0F;
            skDefaultTooltip2.Wedge = 10;
            skDefaultTooltip2.X = 0F;
            skDefaultTooltip2.Y = 0F;
            pieChart1.Tooltip = skDefaultTooltip2;
            pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // flpStockLegend
            // 
            flpStockLegend.Controls.Add(pnlInStock);
            flpStockLegend.Controls.Add(pnlLowStocks);
            flpStockLegend.Controls.Add(pnlOutStock);
            flpStockLegend.Dock = DockStyle.Fill;
            flpStockLegend.FlowDirection = FlowDirection.TopDown;
            flpStockLegend.Location = new Point(207, 3);
            flpStockLegend.Name = "flpStockLegend";
            flpStockLegend.Padding = new Padding(10, 30, 10, 10);
            flpStockLegend.Size = new Size(183, 239);
            flpStockLegend.TabIndex = 3;
            flpStockLegend.WrapContents = false;
            // 
            // pnlInStock
            // 
            pnlInStock.Controls.Add(lblInStockValue);
            pnlInStock.Controls.Add(lblInStock);
            pnlInStock.Controls.Add(pnlGreen);
            pnlInStock.Location = new Point(10, 38);
            pnlInStock.Margin = new Padding(0, 8, 0, 8);
            pnlInStock.Name = "pnlInStock";
            pnlInStock.Size = new Size(233, 40);
            pnlInStock.TabIndex = 0;
            // 
            // lblInStockValue
            // 
            lblInStockValue.AutoSize = true;
            lblInStockValue.Location = new Point(124, 8);
            lblInStockValue.Name = "lblInStockValue";
            lblInStockValue.Size = new Size(86, 25);
            lblInStockValue.TabIndex = 2;
            lblInStockValue.Text = "0 (0.00%)";
            lblInStockValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Font = new Font("Segoe UI", 8F);
            lblInStock.Location = new Point(16, 8);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(64, 21);
            lblInStock.TabIndex = 1;
            lblInStock.Text = "In Stock";
            // 
            // pnlGreen
            // 
            pnlGreen.BackColor = Color.Green;
            pnlGreen.Location = new Point(0, 15);
            pnlGreen.Name = "pnlGreen";
            pnlGreen.Size = new Size(12, 12);
            pnlGreen.TabIndex = 0;
            // 
            // pnlLowStocks
            // 
            pnlLowStocks.Controls.Add(lblLowStockValue);
            pnlLowStocks.Controls.Add(lblLowStocks);
            pnlLowStocks.Controls.Add(panel11);
            pnlLowStocks.Location = new Point(10, 94);
            pnlLowStocks.Margin = new Padding(0, 8, 0, 8);
            pnlLowStocks.Name = "pnlLowStocks";
            pnlLowStocks.Size = new Size(220, 40);
            pnlLowStocks.TabIndex = 1;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Location = new Point(124, 8);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(96, 25);
            lblLowStockValue.TabIndex = 5;
            lblLowStockValue.Text = "9 (15.52%)";
            lblLowStockValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLowStocks
            // 
            lblLowStocks.AutoSize = true;
            lblLowStocks.Font = new Font("Segoe UI", 8F);
            lblLowStocks.Location = new Point(16, 7);
            lblLowStocks.Name = "lblLowStocks";
            lblLowStocks.Size = new Size(80, 21);
            lblLowStocks.TabIndex = 4;
            lblLowStocks.Text = "Low Stock";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(255, 128, 0);
            panel11.Location = new Point(0, 14);
            panel11.Name = "panel11";
            panel11.Size = new Size(12, 12);
            panel11.TabIndex = 3;
            // 
            // pnlOutStock
            // 
            pnlOutStock.Controls.Add(lblOutStockValue);
            pnlOutStock.Controls.Add(lblOutStock);
            pnlOutStock.Controls.Add(panel12);
            pnlOutStock.Location = new Point(10, 150);
            pnlOutStock.Margin = new Padding(0, 8, 0, 8);
            pnlOutStock.Name = "pnlOutStock";
            pnlOutStock.Size = new Size(220, 40);
            pnlOutStock.TabIndex = 2;
            // 
            // lblOutStockValue
            // 
            lblOutStockValue.AutoSize = true;
            lblOutStockValue.Location = new Point(124, 8);
            lblOutStockValue.Name = "lblOutStockValue";
            lblOutStockValue.Size = new Size(96, 25);
            lblOutStockValue.TabIndex = 8;
            lblOutStockValue.Text = "7 (12.07%)";
            lblOutStockValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOutStock
            // 
            lblOutStock.AutoSize = true;
            lblOutStock.Font = new Font("Segoe UI", 8F);
            lblOutStock.Location = new Point(16, 8);
            lblOutStock.Name = "lblOutStock";
            lblOutStock.Size = new Size(98, 21);
            lblOutStock.TabIndex = 7;
            lblOutStock.Text = "Out Of Stock";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(192, 0, 0);
            panel12.Location = new Point(0, 15);
            panel12.Name = "panel12";
            panel12.Size = new Size(12, 12);
            panel12.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(3, 1);
            label17.Name = "label17";
            label17.Size = new Size(139, 30);
            label17.TabIndex = 1;
            label17.Text = "Stock Status";
            // 
            // pnlDashboardCards
            // 
            pnlDashboardCards.BackColor = Color.White;
            pnlDashboardCards.Controls.Add(tblDashboardCards);
            pnlDashboardCards.Dock = DockStyle.Top;
            pnlDashboardCards.Location = new Point(0, 0);
            pnlDashboardCards.Name = "pnlDashboardCards";
            pnlDashboardCards.Size = new Size(1094, 295);
            pnlDashboardCards.TabIndex = 0;
            // 
            // tblDashboardCards
            // 
            tblDashboardCards.ColumnCount = 4;
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDashboardCards.Controls.Add(pnlTotalBrands, 3, 1);
            tblDashboardCards.Controls.Add(pnlLowStock, 2, 1);
            tblDashboardCards.Controls.Add(pnlCurrentStock, 1, 1);
            tblDashboardCards.Controls.Add(pnlTotalSales, 0, 1);
            tblDashboardCards.Controls.Add(pnlTotalPurchase, 3, 0);
            tblDashboardCards.Controls.Add(pnlTotalUnits, 2, 0);
            tblDashboardCards.Controls.Add(pnlTotalCategories, 1, 0);
            tblDashboardCards.Controls.Add(pnlTotalProducts, 0, 0);
            tblDashboardCards.Dock = DockStyle.Fill;
            tblDashboardCards.Location = new Point(0, 0);
            tblDashboardCards.Name = "tblDashboardCards";
            tblDashboardCards.RowCount = 2;
            tblDashboardCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboardCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboardCards.Size = new Size(1094, 295);
            tblDashboardCards.TabIndex = 0;
            // 
            // pnlTotalBrands
            // 
            pnlTotalBrands.AutoSize = true;
            pnlTotalBrands.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalBrands.Controls.Add(panel9);
            pnlTotalBrands.Controls.Add(label13);
            pnlTotalBrands.Controls.Add(lblTotalBrands);
            pnlTotalBrands.Controls.Add(label16);
            pnlTotalBrands.Dock = DockStyle.Fill;
            pnlTotalBrands.ForeColor = Color.DimGray;
            pnlTotalBrands.Location = new Point(829, 157);
            pnlTotalBrands.Margin = new Padding(10);
            pnlTotalBrands.Name = "pnlTotalBrands";
            pnlTotalBrands.Size = new Size(255, 128);
            pnlTotalBrands.TabIndex = 14;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox7);
            panel9.Location = new Point(15, 18);
            panel9.Name = "panel9";
            panel9.Size = new Size(55, 55);
            panel9.TabIndex = 7;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.MintCream;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Image = Properties.Resources.brand;
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Padding = new Padding(10);
            pictureBox7.Size = new Size(55, 55);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(90, 91);
            label13.Name = "label13";
            label13.Size = new Size(142, 25);
            label13.TabIndex = 3;
            label13.Text = "Available Brands";
            // 
            // lblTotalBrands
            // 
            lblTotalBrands.AutoSize = true;
            lblTotalBrands.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalBrands.ForeColor = Color.Black;
            lblTotalBrands.Location = new Point(90, 45);
            lblTotalBrands.Name = "lblTotalBrands";
            lblTotalBrands.Size = new Size(41, 48);
            lblTotalBrands.TabIndex = 2;
            lblTotalBrands.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label16.Location = new Point(90, 20);
            label16.Name = "label16";
            label16.Size = new Size(130, 28);
            label16.TabIndex = 1;
            label16.Text = "Total Brands";
            // 
            // pnlLowStock
            // 
            pnlLowStock.AutoSize = true;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(panel8);
            pnlLowStock.Controls.Add(label11);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(label14);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.ForeColor = Color.DimGray;
            pnlLowStock.Location = new Point(556, 157);
            pnlLowStock.Margin = new Padding(10);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(253, 128);
            pnlLowStock.TabIndex = 13;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox6);
            panel8.Location = new Point(15, 18);
            panel8.Name = "panel8";
            panel8.Size = new Size(55, 55);
            panel8.TabIndex = 7;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Cornsilk;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.warning;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Padding = new Padding(10);
            pictureBox6.Size = new Size(55, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(90, 91);
            label11.Name = "label11";
            label11.Size = new Size(133, 25);
            label11.TabIndex = 3;
            label11.Text = "Need Attention";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.Black;
            lblLowStock.Location = new Point(90, 45);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(41, 48);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(90, 20);
            label14.Name = "label14";
            label14.Size = new Size(108, 28);
            label14.TabIndex = 1;
            label14.Text = "Low Stock";
            // 
            // pnlCurrentStock
            // 
            pnlCurrentStock.AutoSize = true;
            pnlCurrentStock.BorderStyle = BorderStyle.FixedSingle;
            pnlCurrentStock.Controls.Add(panel7);
            pnlCurrentStock.Controls.Add(label9);
            pnlCurrentStock.Controls.Add(lblCurrentStock);
            pnlCurrentStock.Controls.Add(label12);
            pnlCurrentStock.Dock = DockStyle.Fill;
            pnlCurrentStock.ForeColor = Color.DimGray;
            pnlCurrentStock.Location = new Point(283, 157);
            pnlCurrentStock.Margin = new Padding(10);
            pnlCurrentStock.Name = "pnlCurrentStock";
            pnlCurrentStock.Size = new Size(253, 128);
            pnlCurrentStock.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(15, 18);
            panel7.Name = "panel7";
            panel7.Size = new Size(55, 55);
            panel7.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LavenderBlush;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.box;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Padding = new Padding(10);
            pictureBox5.Size = new Size(55, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(90, 91);
            label9.Name = "label9";
            label9.Size = new Size(131, 25);
            label9.TabIndex = 3;
            label9.Text = "Available Stock";
            // 
            // lblCurrentStock
            // 
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCurrentStock.ForeColor = Color.Black;
            lblCurrentStock.Location = new Point(90, 45);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(41, 48);
            lblCurrentStock.TabIndex = 2;
            lblCurrentStock.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.Location = new Point(90, 20);
            label12.Name = "label12";
            label12.Size = new Size(141, 28);
            label12.TabIndex = 1;
            label12.Text = "Current Stock";
            // 
            // pnlTotalSales
            // 
            pnlTotalSales.AutoSize = true;
            pnlTotalSales.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalSales.Controls.Add(panel6);
            pnlTotalSales.Controls.Add(label7);
            pnlTotalSales.Controls.Add(lblSalesAmount);
            pnlTotalSales.Controls.Add(label10);
            pnlTotalSales.Dock = DockStyle.Fill;
            pnlTotalSales.ForeColor = Color.DimGray;
            pnlTotalSales.Location = new Point(10, 157);
            pnlTotalSales.Margin = new Padding(10);
            pnlTotalSales.Name = "pnlTotalSales";
            pnlTotalSales.Size = new Size(253, 128);
            pnlTotalSales.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(15, 18);
            panel6.Name = "panel6";
            panel6.Size = new Size(55, 55);
            panel6.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.MistyRose;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.rupee_symbol;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(10);
            pictureBox4.Size = new Size(55, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(90, 91);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 3;
            label7.Text = "Sales Amount";
            // 
            // lblSalesAmount
            // 
            lblSalesAmount.AutoSize = true;
            lblSalesAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSalesAmount.ForeColor = Color.Black;
            lblSalesAmount.Location = new Point(90, 45);
            lblSalesAmount.Name = "lblSalesAmount";
            lblSalesAmount.Size = new Size(41, 48);
            lblSalesAmount.TabIndex = 2;
            lblSalesAmount.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(90, 20);
            label10.Name = "label10";
            label10.Size = new Size(113, 28);
            label10.TabIndex = 1;
            label10.Text = "Total Sales";
            // 
            // pnlTotalPurchase
            // 
            pnlTotalPurchase.AutoSize = true;
            pnlTotalPurchase.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalPurchase.Controls.Add(panel5);
            pnlTotalPurchase.Controls.Add(label5);
            pnlTotalPurchase.Controls.Add(lblPurchaseAmount);
            pnlTotalPurchase.Controls.Add(label8);
            pnlTotalPurchase.Dock = DockStyle.Fill;
            pnlTotalPurchase.ForeColor = Color.DimGray;
            pnlTotalPurchase.Location = new Point(829, 10);
            pnlTotalPurchase.Margin = new Padding(10);
            pnlTotalPurchase.Name = "pnlTotalPurchase";
            pnlTotalPurchase.Size = new Size(255, 127);
            pnlTotalPurchase.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(15, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 55);
            panel5.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(220, 240, 222);
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.back_in_store;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(10);
            pictureBox3.Size = new Size(55, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(90, 92);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 3;
            label5.Text = "Purchase Amount";
            // 
            // lblPurchaseAmount
            // 
            lblPurchaseAmount.AutoSize = true;
            lblPurchaseAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPurchaseAmount.ForeColor = Color.Black;
            lblPurchaseAmount.Location = new Point(90, 45);
            lblPurchaseAmount.Name = "lblPurchaseAmount";
            lblPurchaseAmount.Size = new Size(41, 48);
            lblPurchaseAmount.TabIndex = 2;
            lblPurchaseAmount.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(90, 20);
            label8.Name = "label8";
            label8.Size = new Size(150, 28);
            label8.TabIndex = 1;
            label8.Text = "Total Purchase";
            // 
            // pnlTotalUnits
            // 
            pnlTotalUnits.AutoSize = true;
            pnlTotalUnits.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalUnits.Controls.Add(panel4);
            pnlTotalUnits.Controls.Add(label3);
            pnlTotalUnits.Controls.Add(lblTotalUnits);
            pnlTotalUnits.Controls.Add(label6);
            pnlTotalUnits.Dock = DockStyle.Fill;
            pnlTotalUnits.ForeColor = Color.DimGray;
            pnlTotalUnits.Location = new Point(556, 10);
            pnlTotalUnits.Margin = new Padding(10);
            pnlTotalUnits.Name = "pnlTotalUnits";
            pnlTotalUnits.Size = new Size(253, 127);
            pnlTotalUnits.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(15, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lavender;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.pencil_and_ruler;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10);
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(90, 91);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 3;
            label3.Text = "Measurement Units";
            // 
            // lblTotalUnits
            // 
            lblTotalUnits.AutoSize = true;
            lblTotalUnits.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalUnits.ForeColor = Color.Black;
            lblTotalUnits.Location = new Point(90, 45);
            lblTotalUnits.Name = "lblTotalUnits";
            lblTotalUnits.Size = new Size(41, 48);
            lblTotalUnits.TabIndex = 2;
            lblTotalUnits.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(90, 20);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 1;
            label6.Text = "Total Units";
            // 
            // pnlTotalCategories
            // 
            pnlTotalCategories.AutoSize = true;
            pnlTotalCategories.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalCategories.Controls.Add(panel3);
            pnlTotalCategories.Controls.Add(label2);
            pnlTotalCategories.Controls.Add(lblTotalCategories);
            pnlTotalCategories.Controls.Add(label4);
            pnlTotalCategories.Dock = DockStyle.Fill;
            pnlTotalCategories.ForeColor = Color.DimGray;
            pnlTotalCategories.Location = new Point(283, 10);
            pnlTotalCategories.Margin = new Padding(10);
            pnlTotalCategories.Name = "pnlTotalCategories";
            pnlTotalCategories.Size = new Size(253, 127);
            pnlTotalCategories.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox10);
            panel3.Location = new Point(15, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 5;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Dock = DockStyle.Fill;
            pictureBox10.Image = Properties.Resources.list;
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Padding = new Padding(10);
            pictureBox10.Size = new Size(55, 55);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(90, 91);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 3;
            label2.Text = "Available Categories";
            // 
            // lblTotalCategories
            // 
            lblTotalCategories.AutoSize = true;
            lblTotalCategories.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCategories.ForeColor = Color.Black;
            lblTotalCategories.Location = new Point(90, 45);
            lblTotalCategories.Name = "lblTotalCategories";
            lblTotalCategories.Size = new Size(41, 48);
            lblTotalCategories.TabIndex = 2;
            lblTotalCategories.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(90, 20);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 1;
            label4.Text = "Total Categories";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.AutoSize = true;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(panel2);
            pnlTotalProducts.Controls.Add(lblProductDesc);
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Controls.Add(lblProductsTitle);
            pnlTotalProducts.Dock = DockStyle.Fill;
            pnlTotalProducts.ForeColor = Color.DimGray;
            pnlTotalProducts.Location = new Point(10, 10);
            pnlTotalProducts.Margin = new Padding(10);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(253, 127);
            pnlTotalProducts.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(picProducts);
            panel2.Location = new Point(15, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 55);
            panel2.TabIndex = 4;
            // 
            // picProducts
            // 
            picProducts.BackColor = Color.AliceBlue;
            picProducts.BackgroundImageLayout = ImageLayout.Stretch;
            picProducts.Dock = DockStyle.Fill;
            picProducts.Image = Properties.Resources.parcel;
            picProducts.Location = new Point(0, 0);
            picProducts.Name = "picProducts";
            picProducts.Padding = new Padding(10);
            picProducts.Size = new Size(55, 55);
            picProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducts.TabIndex = 0;
            picProducts.TabStop = false;
            // 
            // lblProductDesc
            // 
            lblProductDesc.AutoSize = true;
            lblProductDesc.Font = new Font("Segoe UI", 9F);
            lblProductDesc.ForeColor = Color.Gray;
            lblProductDesc.Location = new Point(90, 91);
            lblProductDesc.Name = "lblProductDesc";
            lblProductDesc.Size = new Size(107, 25);
            lblProductDesc.TabIndex = 3;
            lblProductDesc.Text = "All Products";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.Black;
            lblTotalProducts.Location = new Point(90, 45);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(41, 48);
            lblTotalProducts.TabIndex = 2;
            lblTotalProducts.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductsTitle.Location = new Point(90, 20);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(148, 28);
            lblProductsTitle.TabIndex = 1;
            lblProductsTitle.Text = "Total Products";
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 5;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // timerClock
            // 
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 1050);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Controls.Add(label1);
            MinimumSize = new Size(1200, 700);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Accessories Management Store";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnlMain.ResumeLayout(false);
            pnlDesktop.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlBottomSection.ResumeLayout(false);
            tblBottomSection.ResumeLayout(false);
            pnlRecentStock.ResumeLayout(false);
            tblRecentStock.ResumeLayout(false);
            pnlRecentHeader.ResumeLayout(false);
            pnlRecentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentStock).EndInit();
            pnlRecentFooter.ResumeLayout(false);
            pnlRecentFooter.PerformLayout();
            pnlTopSelling.ResumeLayout(false);
            tblTopSelling.ResumeLayout(false);
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlChartSection.ResumeLayout(false);
            tblCharts.ResumeLayout(false);
            pnlSalesChart.ResumeLayout(false);
            pnlSalesChart.PerformLayout();
            pnlStockChart.ResumeLayout(false);
            pnlStockChart.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flpStockLegend.ResumeLayout(false);
            pnlInStock.ResumeLayout(false);
            pnlInStock.PerformLayout();
            pnlLowStocks.ResumeLayout(false);
            pnlLowStocks.PerformLayout();
            pnlOutStock.ResumeLayout(false);
            pnlOutStock.PerformLayout();
            pnlDashboardCards.ResumeLayout(false);
            tblDashboardCards.ResumeLayout(false);
            tblDashboardCards.PerformLayout();
            pnlTotalBrands.ResumeLayout(false);
            pnlTotalBrands.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlCurrentStock.ResumeLayout(false);
            pnlCurrentStock.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlTotalSales.ResumeLayout(false);
            pnlTotalSales.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlTotalPurchase.ResumeLayout(false);
            pnlTotalPurchase.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTotalUnits.ResumeLayout(false);
            pnlTotalUnits.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTotalCategories.ResumeLayout(false);
            pnlTotalCategories.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlMain;
        private Panel pnlLogo;
        private Panel pnlMenu;
        private Label lblDateTime;
        private Label lblUserName;
        private Label lblTitle;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Timer timerClock;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnMenu;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnUnit;
        private FontAwesome.Sharp.IconButton btnBrand;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnPurchase;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnHistory;
        private Panel pnlDashboardCards;
        private TableLayoutPanel tblDashboardCards;
        private Panel pnlTotalProducts;
        private PictureBox picProducts;
        private Label lblTotalProducts;
        private Label lblProductsTitle;
        private Label lblProductDesc;
        private Panel pnlTotalCategories;
        private Label label2;
        private Label lblTotalCategories;
        private Label label4;
        private Panel pnlCurrentStock;
        private Label label9;
        private Label lblCurrentStock;
        private Label label12;
        private Panel pnlTotalSales;
        private Label label7;
        private Label lblSalesAmount;
        private Label label10;
        private Panel pnlTotalPurchase;
        private Label label5;
        private Label lblPurchaseAmount;
        private Label label8;
        private Panel pnlTotalUnits;
        private Label label3;
        private Label lblTotalUnits;
        private Label label6;
        private Panel pnlTotalBrands;
        private Label label13;
        private Label lblTotalBrands;
        private Label label16;
        private Panel pnlLowStock;
        private Label label11;
        private Label lblLowStock;
        private Label label14;
        private Panel pnlChartSection;
        private TableLayoutPanel tblCharts;
        private Panel pnlSalesChart;
        private Panel pnlStockChart;
        private Label label15;
        private Label label17;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Panel pnlDashboard;
        private Panel pnlDesktop;
        private Panel pnlBottomSection;
        private TableLayoutPanel tblBottomSection;
        private Panel pnlRecentStock;
        private Panel pnlTopSelling;
        private TableLayoutPanel tblRecentStock;
        private Panel pnlRecentHeader;
        private Label lblRecentStock;
        private DataGridView dgvRecentStock;
        private Panel pnlRecentFooter;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colDetails;
        private LinkLabel lnkViewAll;
        private TableLayoutPanel tblTopSelling;
        private Panel pnlTopHeader;
        private ComboBox cmbDuration;
        private Label lblTopSelling;
        private FlowLayoutPanel flpTopSelling;
        private FontAwesome.Sharp.IconButton btnSetting;
        private PictureBox pictureBox9;
        private FontAwesome.Sharp.IconButton btnBackupRestore;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private Panel panel2;
        private Panel panel9;
        private PictureBox pictureBox7;
        private Panel panel8;
        private PictureBox pictureBox6;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox10;
        private Panel pnlFooter;
        private Label label18;
        private Label label19;
        private Panel panel10;
        private PictureBox pictureBox8;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpStockLegend;
        private Panel pnlInStock;
        private Label lblInStock;
        private Panel pnlGreen;
        private Panel pnlLowStocks;
        private Panel pnlOutStock;
        private Label lblInStockValue;
        private Label lblLowStockValue;
        private Label lblLowStocks;
        private Panel panel11;
        private Label lblOutStockValue;
        private Label lblOutStock;
        private Panel panel12;
    }
}