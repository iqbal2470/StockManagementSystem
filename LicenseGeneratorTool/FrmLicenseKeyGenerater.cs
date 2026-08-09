using LicenseGeneratorTool.Models;
using LicenseGeneratorTool.Services;
using System.Security.Cryptography;
using System.Text.Json;

namespace LicenseGeneratorTool
{
    public partial class FrmLicenseKeyGenerater : Form
    {
        public FrmLicenseKeyGenerater()
        {
            InitializeComponent();
        }
        private void FrmLicenseKeyGenerater_Load(object sender, EventArgs e)
        {
            txtLicenseNumber.Text =
        $"LIC-{DateTime.Now:yyyy}-{DateTime.Now:HHmmss}";

            cmbLicenseType.Items.AddRange(new string[]
            {
        "Trial",
        "Licensed"
            });

            cmbLicenseType.SelectedIndex = 0;

        //    cmbDuration.Items.AddRange(new string[]
        //    {
        //"1 Hour",
        //"1 Day",
        //"7 Days",
        //"30 Days",
        //"Lifetime"
        //    });

            cmbDuration.SelectedIndex = 0;
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            using RSA rsa = RSA.Create(4096);

            string privateKey = rsa.ExportRSAPrivateKeyPem();
            string publicKey = rsa.ExportRSAPublicKeyPem();

            File.WriteAllText("PrivateKey.pem", privateKey);
            File.WriteAllText("PublicKey.pem", publicKey);

            MessageBox.Show(
                "RSA Keys generated successfully.\n\n" +
                "PrivateKey.pem\n" +
                "PublicKey.pem",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btnGenerateLicense_Click(object sender, EventArgs e)
        {

            LicenseModel license = new LicenseModel();

            // Pehle saara data fill karo
            license.ProductName = "Stock Management System";
            //license.CustomerName = "Demo Customer";
            license.CustomerName = txtCustomerName.Text.Trim();

            license.CompanyName = txtCompanyName.Text.Trim();

            //license.LicenseNumber = txtLicenseNumber.Text.Trim();

            license.LicenseNumber =
    $"LIC-{DateTime.Now:yyyy}-{Guid.NewGuid().ToString("N")[..8].ToUpper()}";

            txtLicenseNumber.Text = license.LicenseNumber;

            license.MachineId = txtMachineId.Text.Trim();
            license.LicenseType = cmbLicenseType.Text;
            license.IssueDate = DateTime.Now;

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show(
                    "Customer Name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrWhiteSpace(txtMachineId.Text))
            {
                MessageBox.Show("Machine ID is required.");
                return;
            }
            switch (cmbDuration.Text)
            {
                case "1 Hour":
                    license.ExpiryDate = DateTime.Now.AddHours(1);
                    break;

                case "1 Day":
                    license.ExpiryDate = DateTime.Now.AddDays(1);
                    break;

                case "7 Days":
                    license.ExpiryDate = DateTime.Now.AddDays(7);
                    break;

                case "30 Days":
                    license.ExpiryDate = DateTime.Now.AddDays(30);
                    break;

                case "1 Year":
                    license.ExpiryDate = DateTime.Now.AddYears(1);
                    break;

                case "2 Years":
                    license.ExpiryDate = DateTime.Now.AddYears(2);
                    break;

                case "3 Years":
                    license.ExpiryDate = DateTime.Now.AddYears(3);
                    break;

                case "5 Years":
                    license.ExpiryDate = DateTime.Now.AddYears(5);
                    break;

                case "Lifetime":
                    license.ExpiryDate = DateTime.MaxValue;
                    break;
            }

            //switch (cmbDuration.Text)
            //{
            //    case "1 Hour":
            //        license.ExpiryDate = DateTime.Now.AddHours(1);
            //        break;

            //    case "1 Day":
            //        license.ExpiryDate = DateTime.Now.AddDays(1);
            //        break;

            //    case "7 Days":
            //        license.ExpiryDate = DateTime.Now.AddDays(7);
            //        break;

            //    case "30 Days":
            //        license.ExpiryDate = DateTime.Now.AddDays(30);
            //        break;

            //    case "Lifetime":
            //        license.ExpiryDate = DateTime.MaxValue;
            //        break;
            //}

            // Ab signature banao
            string signature = LicenseSigner.Sign(license);

            // Ab package banao
            LicensePackage package = new LicensePackage
            {
                License = license,
                Signature = signature
            };

            string json = JsonSerializer.Serialize(
                package,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            txtLicense.Text = json;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicense.Text))
            {
                MessageBox.Show("Please generate a license first.");
                return;
            }

            using SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "License File (*.lic)|*.lic";
            saveFile.FileName = "license.lic";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, txtLicense.Text);

                MessageBox.Show("License saved successfully.");
            }
        }

        private void cmbLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbDuration.Items.Clear();

            //if (cmbLicenseType.Text == "Demo")
            //{
            //    cmbDuration.Items.Add("1 Hour");
            //    cmbDuration.Items.Add("1 Day");
            //    cmbDuration.Items.Add("7 Days");
            //    cmbDuration.Items.Add("30 Days");

            //    cmbDuration.SelectedIndex = 0;
            //    cmbDuration.Enabled = true;
            //}
            //else if (cmbLicenseType.Text == "Full")
            //{
            //    cmbDuration.Items.Add("Lifetime");

            //    cmbDuration.SelectedIndex = 0;

            //    // User duration change nahi kar payega
            //    cmbDuration.Enabled = false;
            //}

            cmbDuration.Items.Clear();

            if (cmbLicenseType.Text == "Trial")
            {
                cmbDuration.Items.AddRange(new string[]
                {
            "1 Hour",
            "1 Day",
            "7 Days",
            "30 Days"
                });

                cmbDuration.SelectedIndex = 0;
                cmbDuration.Enabled = true;
            }
            else if (cmbLicenseType.Text == "Licensed")
            {
                cmbDuration.Items.AddRange(new string[]
                {
            "1 Year",
            "2 Years",
            "3 Years",
            "5 Years",
            "Lifetime"
                });

                cmbDuration.SelectedIndex = 0;
                cmbDuration.Enabled = true;
            }

        }
    }
}
