namespace StockManagementSystem
{
    partial class ucTopSellingProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            prgSold = new ProgressBar();
            lblSold = new Label();
            lblProductName = new Label();
            picProduct = new PictureBox();
            pnlBottomBorder = new Panel();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(prgSold);
            pnlMain.Controls.Add(lblSold);
            pnlMain.Controls.Add(lblProductName);
            pnlMain.Controls.Add(picProduct);
            pnlMain.Dock = DockStyle.Top;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(10);
            pnlMain.Size = new Size(430, 79);
            pnlMain.TabIndex = 0;
            // 
            // prgSold
            // 
            prgSold.BackColor = Color.Gainsboro;
            prgSold.Location = new Point(80, 56);
            prgSold.Name = "prgSold";
            prgSold.Size = new Size(300, 6);
            prgSold.Style = ProgressBarStyle.Continuous;
            prgSold.TabIndex = 3;
            // 
            // lblSold
            // 
            lblSold.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSold.AutoSize = true;
            lblSold.Location = new Point(354, 13);
            lblSold.Name = "lblSold";
            lblSold.Size = new Size(72, 25);
            lblSold.TabIndex = 2;
            lblSold.Text = "Sold : 0";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductName.Location = new Point(75, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(148, 28);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // picProduct
            // 
            picProduct.Location = new Point(10, 15);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(55, 55);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // pnlBottomBorder
            // 
            pnlBottomBorder.BackColor = Color.Silver;
            pnlBottomBorder.Dock = DockStyle.Bottom;
            pnlBottomBorder.Location = new Point(0, 89);
            pnlBottomBorder.Name = "pnlBottomBorder";
            pnlBottomBorder.Size = new Size(430, 1);
            pnlBottomBorder.TabIndex = 1;
            // 
            // ucTopSellingProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlBottomBorder);
            Controls.Add(pnlMain);
            Margin = new Padding(5);
            Name = "ucTopSellingProduct";
            Size = new Size(430, 90);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private ProgressBar prgSold;
        private Label lblSold;
        private Label lblProductName;
        private PictureBox picProduct;
        private Panel pnlBottomBorder;
    }
}
