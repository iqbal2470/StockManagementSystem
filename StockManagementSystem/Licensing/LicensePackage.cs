using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public class LicensePackage
    {
        public LicenseModel License { get; set; } = new();

        public string Signature { get; set; } = "";
    }
}
