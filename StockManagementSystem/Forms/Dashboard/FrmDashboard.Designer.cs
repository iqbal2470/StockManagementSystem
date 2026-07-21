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
            label1 = new Label();
            pnlSidebar = new Panel();
            pnlMenu = new Panel();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            btnStock = new FontAwesome.Sharp.IconButton();
            btnSales = new FontAwesome.Sharp.IconButton();
            btnPurchase = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnUnit = new FontAwesome.Sharp.IconButton();
            btnBrand = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnCategory = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnlHeader = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            lblDateTime = new Label();
            lblUserName = new Label();
            lblTitle = new Label();
            pnlDesktop = new Panel();
            timerSidebar = new System.Windows.Forms.Timer(components);
            timerClock = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
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
            pnlSidebar.Size = new Size(250, 644);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.AutoScroll = true;
            pnlMenu.Controls.Add(btnSetting);
            pnlMenu.Controls.Add(btnReports);
            pnlMenu.Controls.Add(btnStock);
            pnlMenu.Controls.Add(btnSales);
            pnlMenu.Controls.Add(btnPurchase);
            pnlMenu.Controls.Add(btnProduct);
            pnlMenu.Controls.Add(btnUnit);
            pnlMenu.Controls.Add(btnBrand);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Controls.Add(btnCategory);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 70);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 574);
            pnlMenu.TabIndex = 0;
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
            btnSetting.Location = new Point(0, 306);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(15, 0, 0, 0);
            btnSetting.Size = new Size(250, 34);
            btnSetting.TabIndex = 15;
            btnSetting.Text = "Settings\r\n";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
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
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 24;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 540);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(250, 34);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "LogOut";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
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
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Group_4;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnMenu);
            pnlHeader.Controls.Add(lblDateTime);
            pnlHeader.Controls.Add(lblUserName);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(928, 60);
            pnlHeader.TabIndex = 2;
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
            btnMenu.Size = new Size(55, 60);
            btnMenu.TabIndex = 7;
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(813, 21);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(102, 25);
            lblDateTime.TabIndex = 2;
            lblDateTime.Text = "21 Jul 2026";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(660, 21);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Admin";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(367, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // pnlDesktop
            // 
            pnlDesktop.BackColor = Color.Transparent;
            pnlDesktop.BackgroundImageLayout = ImageLayout.Center;
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(250, 60);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(928, 584);
            pnlDesktop.TabIndex = 3;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
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
            ClientSize = new Size(1178, 644);
            Controls.Add(pnlDesktop);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Controls.Add(label1);
            MinimumSize = new Size(1200, 700);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDashboard";
            WindowState = FormWindowState.Maximized;
            Load += FrmDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlDesktop;
        private Panel pnlLogo;
        private Panel pnlMenu;
        private Label lblDateTime;
        private Label lblUserName;
        private Label lblTitle;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Timer timerClock;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnLogout;
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
        private FontAwesome.Sharp.IconButton btnSetting;
    }
}