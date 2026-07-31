using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public class LicenseModel
    {
        public string ProductName { get; set; } = "";

        public string CustomerName { get; set; } = "";

        public string CompanyName { get; set; } = "";

        public string LicenseNumber { get; set; } = "";

        public string MachineId { get; set; } = "";

        public string LicenseType { get; set; } = "";

        public DateTime IssueDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        [JsonIgnore]
        public string Signature { get; set; } = "";
    }
}
