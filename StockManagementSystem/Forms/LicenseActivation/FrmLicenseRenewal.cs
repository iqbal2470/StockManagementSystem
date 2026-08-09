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
    public partial class FrmLicenseRenewal : Form
    {
        public event Action? LoadingCompleted;

        public FrmLicenseRenewal()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog open = new();

            open.Filter = "License Files (*.lic)|*.lic";

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtLicenseFile.Text = open.FileName;
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseFile.Text))
            {
                MessageBox.Show(
                    "Please select a license file.",
                    "Renew License",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool success = LicenseActivationService.ActivateLicense(
                txtLicenseFile.Text,
                out string message);

            if (!success)
            {
                MessageBox.Show(
                    message,
                    "Renew License",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "License renewed successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmLicenseRenewal_Load(object sender, EventArgs e)
        {
            LoadingCompleted?.Invoke();

            MakePictureCircular(picProducts);

            //CenterPanel();
        }
        //private void CenterPanel()
        //{
        //    pnlRenewLicense.Left = (pnlRenewLicense1.ClientSize.Width - pnlRenewLicense.Width) / 2;
        //    pnlRenewLicense.Top = (pnlRenewLicense1.ClientSize.Height - pnlRenewLicense.Height) / 2;
        //}

        private void MakePictureCircular(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void picProducts_Click(object sender, EventArgs e)
        {

        }

        private void pnlRenewLicense1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRenewLicense1_Resize(object sender, EventArgs e)
        {
            //CenterPanel();
        }
    }
}
