using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper.Models
{
    public class InstallerResult
    {
        public bool Success { get; set; }

        public string Message { get; set; } = string.Empty;
    }
}
