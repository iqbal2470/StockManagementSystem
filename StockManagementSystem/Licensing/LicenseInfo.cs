using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public class LicenseInfo
    {
        public string LicenseKey { get; set; } = "";

        public string MachineId { get; set; } = "";

        public LicenseType LicenseType { get; set; }

        public DateTime ActivatedOn { get; set; }

        public bool IsActivated { get; set; }
    }
}
