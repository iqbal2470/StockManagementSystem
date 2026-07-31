using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Services
{
    public static class LicenseWarningService
    {
        private static readonly string FolderPath =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "StockManagementSystem");

        private static readonly string WarningFile =
            Path.Combine(FolderPath, "LastWarning.txt");

        public static bool ShouldShowWarning()
        {
            try
            {
                if (!File.Exists(WarningFile))
                    return true;

                string text = File.ReadAllText(WarningFile);

                if (DateTime.TryParse(text, out DateTime lastDate))
                {
                    return lastDate.Date != DateTime.Today;
                }

                return true;
            }
            catch
            {
                return true;
            }
        }

        public static void SaveWarningDate()
        {
            Directory.CreateDirectory(FolderPath);

            File.WriteAllText(
                WarningFile,
                DateTime.Today.ToString("yyyy-MM-dd"));
        }
    }
}
