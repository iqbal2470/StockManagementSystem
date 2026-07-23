using StockManagementSystem.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class ucTopSellingProduct : UserControl
    {
        public ucTopSellingProduct()
        {
            InitializeComponent();
        }

        //public void SetData(TopSellingProductModel model)
        //{
        //    lblProductName.Text = model.ProductName;

        //    lblSold.Text = $"Sold : {model.TotalQuantity}";

        //    if (!string.IsNullOrWhiteSpace(model.ImagePath)
        //        && File.Exists(model.ImagePath))
        //    {
        //        picProduct.Image = Image.FromFile(model.ImagePath);
        //    }
        //    else
        //    {
        //        picProduct.Image = Properties.Resources.Group_4;
        //    }
        //}
        public void SetData(TopSellingProductModel model)
        {
            lblProductName.Text = model.ProductName;

            lblSold.Text = $"Sold : {model.TotalQuantity}";

            prgSold.Maximum = 100;

            prgSold.Value = Math.Min(model.Progress, 100);

            string imagePath = Path.Combine(
                Application.StartupPath,
                "ProductImages",
                model.ImagePath ?? "");

            if (File.Exists(imagePath))
            {
                //picProduct.Image?.Dispose();
                //picProduct.Image = Image.FromFile(imagePath);
                picProduct.Image?.Dispose();

                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    ms.Position = 0;

                    picProduct.Image = Image.FromStream(ms);
                }
            }
            else
            {
                picProduct.Image = null;
            }
        }
        //public void SetData(TopSellingProductModel model)
        //{
        //    lblProductName.Text = model.ProductName;
        //    lblSold.Text = $"Sold : {model.TotalQuantity}";

        //    string imagePath = Path.Combine(
        //        Application.StartupPath,
        //        "ProductImages",
        //        model.ImagePath ?? "");

        //    //MessageBox.Show(imagePath);
        //    //MessageBox.Show(File.Exists(imagePath).ToString());

        //    if (File.Exists(imagePath))
        //    {
        //        picProduct.Image?.Dispose();
        //        picProduct.Image = Image.FromFile(imagePath);
        //    }
        //    else
        //    {
        //        picProduct.Image = null;
        //    }
        //}
    }
}
