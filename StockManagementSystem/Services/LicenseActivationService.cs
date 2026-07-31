using StockManagementSystem.Licensing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagementSystem.Services
{
    public static class LicenseActivationService
    {
        public static bool ActivateLicense(
            string licenseFile,
            out string message)
        {
            message = "";

            try
            {
                if (!File.Exists(licenseFile))
                {
                    message = "License file not found.";
                    return false;
                }

                string json = File.ReadAllText(licenseFile);

                LicensePackage? package =
                    JsonSerializer.Deserialize<LicensePackage>(json);

                if (package == null)
                {
                    message = "Invalid license file.";
                    return false;
                }

                if (!LicenseValidator.Verify(package))
                {
                    message = "License signature is invalid.";
                    return false;
                }

                if (package.License.MachineId != MachineIdProvider.GetMachineId())
                {
                    message = "License belongs to another computer.";
                    return false;
                }

                if (package.License.ExpiryDate < DateTime.Now)
                {
                    message = "License has expired.";
                    return false;
                }
                LicenseService.SaveLicense(package);

                //LicenseWarningService.SaveWarningDate();

                message = "License activated successfully.";

                return true;

                //LicenseService.SaveLicense(package);

                //message = "License activated successfully.";

                //return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
