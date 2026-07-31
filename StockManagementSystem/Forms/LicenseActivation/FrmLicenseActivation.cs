using StockManagementSystem.Licensing;
using StockManagementSystem.Models.Common;
using StockManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Forms.LicenseActivation
{
    public partial class FrmLicenseActivation : BaseForm
    {
        public FrmLicenseActivation()
        {
            InitializeComponent();
        }

        private void FrmLicenseActivation_Load(object sender, EventArgs e)
        {
            txtMachineId.Text = MachineIdProvider.GetMachineId();
        }

        private void btnCopyMachineId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMachineId.Text);

            MessageBox.Show(
                "Machine ID copied successfully.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog open = new OpenFileDialog();

            open.Filter = "License File (*.lic)|*.lic";

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtLicenseFile.Text = open.FileName;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseFile.Text))
            {
                MessageBox.Show(
                    "Please select a license file.",
                    "Activation",
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
                    "Activation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                message,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();

            //    try
            //    {
            //        if (string.IsNullOrWhiteSpace(txtLicenseFile.Text))
            //        {
            //            MessageBox.Show("Please select a license file.");
            //            return;
            //        }

            //        if (!File.Exists(txtLicenseFile.Text))
            //        {
            //            MessageBox.Show("License file not found.");
            //            return;
            //        }

            //        // Read License File
            //        string json = File.ReadAllText(txtLicenseFile.Text);

            //        // Deserialize
            //        LicensePackage? package =
            //            JsonSerializer.Deserialize<LicensePackage>(json);

            //        if (package == null)
            //        {
            //            MessageBox.Show("Invalid license.");
            //            return;
            //        }

            //        // Verify RSA Signature
            //        bool valid = LicenseValidator.Verify(package);

            //        if (!valid)
            //        {
            //            MessageBox.Show(
            //                "License signature is invalid.",
            //                "Activation",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);

            //            return;
            //        }

            //        // Machine ID Check
            //        string currentMachine =
            //            MachineIdProvider.GetMachineId();

            //        if (package.License.MachineId != currentMachine)
            //        {
            //            MessageBox.Show(
            //                "This license belongs to another computer.",
            //                "Activation",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);

            //            return;
            //        }

            //        // Expiry Check
            //        if (package.License.ExpiryDate < DateTime.Now)
            //        {
            //            MessageBox.Show(
            //                "License has expired.",
            //                "Activation",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);

            //            return;
            //        }

            //        MessageBox.Show(
            //            "License Verified Successfully.",
            //            "Activation",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information);

            //        LicenseService.SaveLicense(package);

            //        MessageBox.Show(
            //            "License Activated Successfully.",
            //            "Success",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information);

            //        this.DialogResult = DialogResult.OK;
            //        this.Close();

            //        // Save License
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
