using InstallerHelper.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper
{

    //public class SqlInstaller
    //{
    //    public bool IsSqlInstalled()
    //    {
    //        var detector = new SqlServerDetector();

    //        var instances = SqlInstanceHelper.GetSqlInstances();

    //        return instances.Count > 0;
    //    }

    //    public void InstallSqlServer(string installerPath)
    //    {
    //        // Next step me implementation karenge
    //    }
    //}

    public class SqlInstaller
    {
        public bool IsSqlInstalled()
        {
            return SqlInstanceHelper.GetSqlInstances().Count > 0;
        }

        public bool InstallSqlServer(string setupExePath)
        {
            if (!File.Exists(setupExePath))
                throw new FileNotFoundException("Setup.exe not found.", setupExePath);

            string setupFolder = Path.GetDirectoryName(setupExePath)!;
            string configFile = Path.Combine(setupFolder, "ConfigurationFile.ini");

            if (!File.Exists(configFile))
                throw new FileNotFoundException("ConfigurationFile.ini not found.", configFile);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Installing SQL Server Express...");
            Console.ResetColor();

            Process process = new Process();

            process.StartInfo.FileName = setupExePath;
            process.StartInfo.Arguments =
                $"/Q /ConfigurationFile=\"{configFile}\" " +
                "/IACCEPTSQLSERVERLICENSETERMS " +
                "/SUPPRESSPRIVACYSTATEMENTNOTICE " +
                "/ADDCURRENTUSERASSQLADMIN";

            process.StartInfo.WorkingDirectory = setupFolder;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";

            process.Start();

            process.WaitForExit();

            Console.WriteLine();
            //Console.WriteLine($"Exit Code : {process.ExitCode}");
            InstallerLogger.Info($"Exit Code : {process.ExitCode}");

            return process.ExitCode == 0;
        }

        //public bool InstallSqlServer(string installerPath)
        //{
        //    if (!File.Exists(installerPath))
        //        throw new FileNotFoundException(installerPath);

        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("SQL Server installation started...");
        //    Console.ResetColor();

        //    Process process = new Process();

        //    //process.StartInfo.FileName = installerPath;

        //    //process.StartInfo.UseShellExecute = true;
        //    //process.StartInfo.Verb = "runas";

        //    //Process process = new Process();

        //    process.StartInfo.FileName = installerPath;

        //    process.StartInfo.Arguments =
        //        "/Q " +
        //        "/ACTION=Install " +
        //        "/FEATURES=SQLEngine " +
        //        "/INSTANCENAME=SQLEXPRESS " +
        //        "/INSTANCEID=SQLEXPRESS " +
        //        "/TCPENABLED=1 " +
        //        "/NPENABLED=1 " +
        //        "/UPDATEENABLED=0 " +
        //        "/ADDCURRENTUSERASSQLADMIN " +
        //        "/IACCEPTSQLSERVERLICENSETERMS " +
        //        "/SUPPRESSPRIVACYSTATEMENTNOTICE";

        //    process.StartInfo.UseShellExecute = true;
        //    process.StartInfo.Verb = "runas";

        //    process.Start();

        //    process.WaitForExit();

        //    if (process.ExitCode == 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("SQL Server installed successfully.");
        //        Console.ResetColor();

        //        return true;
        //    }

        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"SQL Server installation failed. Exit Code: {process.ExitCode}");
        //    Console.ResetColor();

        //    return false;

        //    //process.Start();

        //    //process.WaitForExit();

        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("SQL Server installer closed.");
        //    Console.ResetColor();

        //    return true;
        //}
    }
}
