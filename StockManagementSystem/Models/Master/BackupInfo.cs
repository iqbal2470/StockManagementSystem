using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.Master
{
    public class BackupInfo
    {
        public string SoftwareName { get; set; } = "Car Accessory Management Store";

        public string Version { get; set; } = "1.0.0";

        public string DatabaseName { get; set; } = string.Empty;

        public DateTime BackupDate { get; set; }

        public string MachineName { get; set; } = Environment.MachineName;

        public string WindowsUser { get; set; } = Environment.UserName;

        public string SqlServer { get; set; } = string.Empty;
    }
}
