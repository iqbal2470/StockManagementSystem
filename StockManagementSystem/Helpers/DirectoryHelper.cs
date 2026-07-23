using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Helpers
{
    public static class DirectoryHelper
    {
        public static string ApplicationPath =>
            AppDomain.CurrentDomain.BaseDirectory;

        public static string BackupFolder =>
            Path.Combine(ApplicationPath, "Backups");

        public static string TempFolder =>
            Path.Combine(ApplicationPath, "TempBackup");

        public static string ProductImagesFolder =>
            Path.Combine(ApplicationPath, "ProductImages");
    }
}
