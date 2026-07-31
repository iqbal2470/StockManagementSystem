using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public class DemoInfo
    {
        public DateTime FirstRun { get; set; }

        public DateTime LastRun { get; set; }

        public int DemoHours { get; set; }

        public bool DemoExpired { get; set; }
    }
}
