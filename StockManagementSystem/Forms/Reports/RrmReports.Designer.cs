namespace StockManagementSystem.Forms.Reports
{
    partial class RrmReports
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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RrmReports));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
            dgvReport = new DataGridView();
            cmbReportType = new ComboBox();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            label2 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            btnLoad = new FontAwesome.Sharp.IconButton();
            btnExportPdf = new FontAwesome.Sharp.IconButton();
            btnExportExcel = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            pnlMain = new Panel();
            panel11 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel12 = new Panel();
            panel9 = new Panel();
            pnlSalesOverview = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel8 = new Panel();
            grpSalesTrend = new GroupBox();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            grpCategory = new GroupBox();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel10 = new Panel();
            pnlDashboardCards = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlTotalSales = new Panel();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            lblTotalSales = new Label();
            label10 = new Label();
            pnlTotalPurchase = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            lblTotalPurchase = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            label21 = new Label();
            lblProfit = new Label();
            pnlTotalProducts = new Panel();
            panel4 = new Panel();
            picProducts = new PictureBox();
            lblProductDesc = new Label();
            lblProductsTitle = new Label();
            lblTotalProducts = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            pnlMain.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel12.SuspendLayout();
            pnlSalesOverview.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel8.SuspendLayout();
            grpSalesTrend.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            grpCategory.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel10.SuspendLayout();
            pnlDashboardCards.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlTotalSales.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlTotalPurchase.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTotalProducts.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(0, 0);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 62;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(1280, 305);
            dgvReport.TabIndex = 0;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(13, 49);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(255, 33);
            cmbReportType.TabIndex = 1;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "ReportType";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(286, 51);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(205, 31);
            dtpFrom.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(280, 19);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 4;
            label2.Text = "From";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(508, 51);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(205, 31);
            dtpTo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(502, 19);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 6;
            label3.Text = "To";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(37, 99, 235);
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoad.ForeColor = Color.White;
            btnLoad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLoad.IconColor = Color.Black;
            btnLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoad.Location = new Point(729, 51);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportPdf.BackColor = Color.FromArgb(220, 38, 38);
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportPdf.IconColor = Color.Black;
            btnExportPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportPdf.Location = new Point(871, 49);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(112, 35);
            btnExportPdf.TabIndex = 8;
            btnExportPdf.Text = "Export Pdf";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportExcel.BackColor = Color.FromArgb(22, 163, 74);
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExportExcel.IconColor = Color.Black;
            btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportExcel.Location = new Point(999, 49);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(135, 35);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(871, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = " Search here....";
            txtSearch.Size = new Size(394, 31);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(panel11);
            pnlMain.Controls.Add(panel9);
            pnlMain.Controls.Add(pnlSalesOverview);
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(pnlDashboardCards);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1306, 918);
            pnlMain.TabIndex = 12;
            // 
            // panel11
            // 
            panel11.Controls.Add(tableLayoutPanel6);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 548);
            panel11.Name = "panel11";
            panel11.Size = new Size(1306, 321);
            panel11.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(panel12, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1306, 321);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(dgvReport);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(13, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(1280, 305);
            panel12.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 869);
            panel9.Name = "panel9";
            panel9.Size = new Size(1306, 49);
            panel9.TabIndex = 15;
            // 
            // pnlSalesOverview
            // 
            pnlSalesOverview.Controls.Add(tableLayoutPanel3);
            pnlSalesOverview.Dock = DockStyle.Top;
            pnlSalesOverview.Location = new Point(0, 260);
            pnlSalesOverview.Name = "pnlSalesOverview";
            pnlSalesOverview.Size = new Size(1306, 288);
            pnlSalesOverview.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1306, 288);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel8, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(10, 0, 0, 10);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(908, 282);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(grpSalesTrend);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(13, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(892, 266);
            panel8.TabIndex = 0;
            // 
            // grpSalesTrend
            // 
            grpSalesTrend.Controls.Add(cartesianChart1);
            grpSalesTrend.Dock = DockStyle.Fill;
            grpSalesTrend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpSalesTrend.Location = new Point(0, 0);
            grpSalesTrend.Name = "grpSalesTrend";
            grpSalesTrend.Size = new Size(890, 264);
            grpSalesTrend.TabIndex = 0;
            grpSalesTrend.TabStop = false;
            grpSalesTrend.Text = "Sales / Purchase Trend";
            // 
            // cartesianChart1
            // 
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.ChartTheme = null;
            cartesianChart1.Dock = DockStyle.Fill;
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
            cartesianChart1.Location = new Point(3, 35);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(884, 226);
            cartesianChart1.TabIndex = 0;
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel7, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(917, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(386, 282);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(grpCategory);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(13, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 266);
            panel7.TabIndex = 0;
            // 
            // grpCategory
            // 
            grpCategory.Controls.Add(pieChart1);
            grpCategory.Dock = DockStyle.Fill;
            grpCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpCategory.Location = new Point(0, 0);
            grpCategory.Name = "grpCategory";
            grpCategory.Size = new Size(358, 264);
            grpCategory.TabIndex = 1;
            grpCategory.TabStop = false;
            grpCategory.Text = "Category Distribution";
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
            pieChart1.Location = new Point(3, 35);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(352, 226);
            pieChart1.TabIndex = 0;
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
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 110);
            panel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel10, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1306, 110);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(btnExportExcel);
            panel10.Controls.Add(cmbReportType);
            panel10.Controls.Add(btnExportPdf);
            panel10.Controls.Add(txtSearch);
            panel10.Controls.Add(btnLoad);
            panel10.Controls.Add(label1);
            panel10.Controls.Add(dtpFrom);
            panel10.Controls.Add(dtpTo);
            panel10.Controls.Add(label3);
            panel10.Controls.Add(label2);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(13, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(1280, 94);
            panel10.TabIndex = 0;
            panel10.Paint += panel10_Paint;
            // 
            // pnlDashboardCards
            // 
            pnlDashboardCards.Controls.Add(tableLayoutPanel1);
            pnlDashboardCards.Dock = DockStyle.Top;
            pnlDashboardCards.Location = new Point(0, 0);
            pnlDashboardCards.Name = "pnlDashboardCards";
            pnlDashboardCards.Size = new Size(1306, 150);
            pnlDashboardCards.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlTotalSales, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlTotalPurchase, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlTotalProducts, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1306, 150);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlTotalSales
            // 
            pnlTotalSales.AutoSize = true;
            pnlTotalSales.BackColor = Color.White;
            pnlTotalSales.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalSales.Controls.Add(panel6);
            pnlTotalSales.Controls.Add(label7);
            pnlTotalSales.Controls.Add(lblTotalSales);
            pnlTotalSales.Controls.Add(label10);
            pnlTotalSales.Dock = DockStyle.Fill;
            pnlTotalSales.ForeColor = Color.DimGray;
            pnlTotalSales.Location = new Point(662, 10);
            pnlTotalSales.Margin = new Padding(10);
            pnlTotalSales.Name = "pnlTotalSales";
            pnlTotalSales.Size = new Size(306, 130);
            pnlTotalSales.TabIndex = 17;
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
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(90, 45);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(41, 48);
            lblTotalSales.TabIndex = 2;
            lblTotalSales.Text = "0";
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
            pnlTotalPurchase.BackColor = Color.White;
            pnlTotalPurchase.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalPurchase.Controls.Add(panel5);
            pnlTotalPurchase.Controls.Add(label5);
            pnlTotalPurchase.Controls.Add(lblTotalPurchase);
            pnlTotalPurchase.Controls.Add(label8);
            pnlTotalPurchase.Dock = DockStyle.Fill;
            pnlTotalPurchase.ForeColor = Color.DimGray;
            pnlTotalPurchase.Location = new Point(336, 10);
            pnlTotalPurchase.Margin = new Padding(10);
            pnlTotalPurchase.Name = "pnlTotalPurchase";
            pnlTotalPurchase.Size = new Size(306, 130);
            pnlTotalPurchase.TabIndex = 16;
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
            // lblTotalPurchase
            // 
            lblTotalPurchase.AutoSize = true;
            lblTotalPurchase.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalPurchase.ForeColor = Color.Black;
            lblTotalPurchase.Location = new Point(90, 45);
            lblTotalPurchase.Name = "lblTotalPurchase";
            lblTotalPurchase.Size = new Size(41, 48);
            lblTotalPurchase.TabIndex = 2;
            lblTotalPurchase.Text = "0";
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
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(lblProfit);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(988, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 130);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(15, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.cancel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.ForeColor = Color.Gray;
            label19.Location = new Point(90, 91);
            label19.Name = "label19";
            label19.Size = new Size(97, 25);
            label19.TabIndex = 3;
            label19.Text = "Profit/Loss";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label21.Location = new Point(90, 20);
            label21.Name = "label21";
            label21.Size = new Size(119, 28);
            label21.TabIndex = 1;
            label21.Text = "Total Profit";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProfit.ForeColor = Color.Black;
            lblProfit.Location = new Point(90, 45);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(41, 48);
            lblProfit.TabIndex = 124;
            lblProfit.Text = "0";
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.AutoSize = true;
            pnlTotalProducts.BackColor = Color.White;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(panel4);
            pnlTotalProducts.Controls.Add(lblProductDesc);
            pnlTotalProducts.Controls.Add(lblProductsTitle);
            pnlTotalProducts.Controls.Add(lblTotalProducts);
            pnlTotalProducts.Dock = DockStyle.Fill;
            pnlTotalProducts.ForeColor = Color.DimGray;
            pnlTotalProducts.Location = new Point(10, 10);
            pnlTotalProducts.Margin = new Padding(10);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Size = new Size(306, 130);
            pnlTotalProducts.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(picProducts);
            panel4.Location = new Point(15, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 4;
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
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.Black;
            lblTotalProducts.Location = new Point(90, 45);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(41, 48);
            lblTotalProducts.TabIndex = 125;
            lblTotalProducts.Text = "0";
            // 
            // RrmReports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 241, 252);
            ClientSize = new Size(1306, 918);
            Controls.Add(pnlMain);
            Name = "RrmReports";
            Text = "Master Reports";
            Load += RrmReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            pnlMain.ResumeLayout(false);
            panel11.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel12.ResumeLayout(false);
            pnlSalesOverview.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            grpSalesTrend.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            grpCategory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            pnlDashboardCards.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlTotalSales.ResumeLayout(false);
            pnlTotalSales.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlTotalPurchase.ResumeLayout(false);
            pnlTotalPurchase.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReport;
        private ComboBox cmbReportType;
        private Label label1;
        private DateTimePicker dtpFrom;
        private Label label2;
        private DateTimePicker dtpTo;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnLoad;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private TextBox txtSearch;
        private Panel pnlMain;
        private Panel pnlDashboardCards;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label19;
        private Label label21;
        private Label lblProfit;
        private Panel pnlTotalProducts;
        private Panel panel4;
        private PictureBox picProducts;
        private Label lblProductDesc;
        private Label lblProductsTitle;
        private Label lblTotalProducts;
        private Panel pnlTotalPurchase;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label5;
        private Label lblTotalPurchase;
        private Label label8;
        private Panel pnlTotalSales;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Label label7;
        private Label lblTotalSales;
        private Label label10;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel10;
        private Panel pnlSalesOverview;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel7;
        private Panel panel11;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel12;
        private GroupBox grpSalesTrend;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private GroupBox grpCategory;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}