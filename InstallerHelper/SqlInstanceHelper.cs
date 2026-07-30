using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
namespace InstallerHelper
{
    

   
    public static class SqlInstanceHelper
    {
        public static List<string> GetSqlInstances()
        {
            List<string> result = new();

            try
            {
                using RegistryKey? key =
                    Registry.LocalMachine.OpenSubKey(
                        @"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");

                if (key != null)
                {
                    foreach (string name in key.GetValueNames())
                    {
                        result.Add(Environment.MachineName + "\\" + name);
                    }
                }
            }
            catch
            {
            }

            return result;
        }
    }
}
