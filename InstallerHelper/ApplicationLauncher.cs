using InstallerHelper.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper
{
    public class ApplicationLauncher
    {
        public bool Launch(string exePath)
        {
            try
            {
                if (!File.Exists(exePath))
                    throw new FileNotFoundException("Application not found.", exePath);

                Process.Start(new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true
                });

                return true;
            }
            catch (Exception ex)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine(ex.Message);
                //Console.ResetColor();
                InstallerLogger.Error(ex.Message);

                return false;
            }
        }
    }
}
