using StockManagementSystem.Licensing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagementSystem.Services
{
    public static class LicenseService
    {
        private static readonly string LicenseFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "StockManagementSystem");

        private static readonly string LicenseFile =
            Path.Combine(LicenseFolder, "license.lic");

        public static void SaveLicense(LicensePackage package)
        {
            if (!Directory.Exists(LicenseFolder))
            {
                Directory.CreateDirectory(LicenseFolder);
            }

            string json = JsonSerializer.Serialize(
                package,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(LicenseFile, json);
        }

        public static LicensePackage? LoadLicense()
        {
            if (!File.Exists(LicenseFile))
                return null;

            string json = File.ReadAllText(LicenseFile);

            return JsonSerializer.Deserialize<LicensePackage>(json);
        }

        public static bool LicenseExists()
        {
            return File.Exists(LicenseFile);
        }

        public static string GetLicensePath()
        {
            return LicenseFile;
        }

        public static bool IsLicenseValid()
        {
            try
            {
                LicensePackage? package = LoadLicense();

                if (package == null)
                    return false;

                // Verify Digital Signature
                if (!LicenseValidator.Verify(package))
                    return false;

                // Verify Machine ID
                if (package.License.MachineId != MachineIdProvider.GetMachineId())
                    return false;

                // Verify Expiry
                if (package.License.ExpiryDate < DateTime.Now)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static LicensePackage? GetCurrentLicense()
        {
            try
            {
                if (!LicenseExists())
                    return null;

                return LoadLicense();
            }
            catch
            {
                return null;
            }
        }

        public static int GetRemainingDays()
        {
            var package = GetCurrentLicense();

            if (package == null)
                return 0;

            // Lifetime License
            if (package.License.ExpiryDate == DateTime.MaxValue)
                return int.MaxValue;

            return (package.License.ExpiryDate.Date - DateTime.Now.Date).Days;
        }

        public static bool IsLifetimeLicense()
        {
            var package = GetCurrentLicense();

            if (package == null)
                return false;

            return package.License.ExpiryDate == DateTime.MaxValue;
        }

        public static TimeSpan GetRemainingTime()
        {
            var package = GetCurrentLicense();

            if (package == null)
                return TimeSpan.Zero;

            return package.License.ExpiryDate - DateTime.Now;
        }
    }
}
