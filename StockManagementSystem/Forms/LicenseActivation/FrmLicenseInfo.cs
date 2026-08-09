using StockManagementSystem.Models.Common;
using StockManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.LicenseActivation
{
    public partial class FrmLicenseInfo : BaseForm
    {
        public event Action? LoadingCompleted;
        public FrmLicenseInfo()
        {
            InitializeComponent();
        }

        private void FrmLicenseInfo_Load(object sender, EventArgs e)
        {
            var package = LicenseService.GetCurrentLicense();

            if (package == null)
            {
                MessageBox.Show("License not found.");

                Close();

                return;
            }
            lblLicenseNumber.Text = package.License.LicenseNumber;

            lblCustomerName.Text = package.License.CustomerName;

            lblCompanyName.Text = package.License.CompanyName;

            lblCustomerName.Text = package.License.CustomerName;

            lblLicenseType.Text = package.License.LicenseType;

            lblIssueDate.Text =
                package.License.IssueDate.ToString("dd-MMM-yyyy");

            //lblExpiryDate.Text =
            //    package.License.ExpiryDate.ToString("dd-MMM-yyyy");
            if (package.License.ExpiryDate == DateTime.MaxValue)
            {
                lblExpiryDate.Text = "Lifetime";
            }
            else
            {
                lblExpiryDate.Text =
                    package.License.ExpiryDate.ToString("dd-MMM-yyyy");
            }

            lblMachineId.Text =
                package.License.MachineId;

            //lblStatus.Text = "Activated";
            if (package.License.ExpiryDate == DateTime.MaxValue ||
                package.License.ExpiryDate >= DateTime.Now)
            {
                lblStatus.Text = "Activated";
            }
            else
            {
                lblStatus.Text = "Expired";
            }

            //MakePictureCircular(picProducts);

            LoadingCompleted?.Invoke();
        }

        //private void MakePictureCircular(PictureBox pictureBox)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
        //    pictureBox.Region = new Region(path);

        //    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        //}
    }
}
