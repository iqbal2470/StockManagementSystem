//using InstallerHelper;
//using Microsoft.Win32;

//Console.Title = "Installer Helper";

//Console.WriteLine("======================================");
//Console.WriteLine("   TEAMARRIVE SOFTWARE COMPANY - Installer Helper");
//Console.WriteLine("======================================");
//Console.WriteLine();

////List<string> instances = GetSqlInstances();
//List<string> instances = SqlInstanceHelper.GetSqlInstances();

//if (instances.Count == 0)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("No SQL Server instance found.");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("SQL Server Instances Found:");
//    Console.ResetColor();

//    //foreach (var instance in instances)
//    //{
//    //    Console.WriteLine($" - {instance}");
//    //}

//    var detector = new SqlServerDetector();

//    const string databaseName = "StockManagementDB";

//    string? selected = null;

//    foreach (var instance in instances)
//    {
//        Console.WriteLine("--------------------------------");

//        Console.WriteLine($"Checking : {instance}");

//        bool exists = detector.DatabaseExists(instance, databaseName);

//        Console.WriteLine($"Database Exists : {exists}");

//        if (exists)
//        {
//            selected = instance;
//            break;
//        }
//    }

//    if (selected == null && instances.Count > 0)
//    {
//        selected = instances[0];
//    }

//    Console.WriteLine();
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine($"Selected SQL Instance : {selected}");
//    Console.ResetColor();

//    DatabaseManager databaseManager = new DatabaseManager();

//    bool databaseCreated =
//        databaseManager.CreateDatabase(selected!, databaseName);

//    if (databaseCreated)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Database '{databaseName}' is ready.");
//        Console.ResetColor();
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"Failed to create database '{databaseName}'.");
//        Console.ResetColor();

//        return;
//    }
//}
//var installer = new SqlInstaller();

//if (!installer.IsSqlInstalled())
//{
//    //installer.InstallSqlServer(
//    //    @"C:\Users\HomePC\source\repos\Installer\Prerequisites\SqlServer\SQLEXPR_x64_ENU.exe");

//    string setupPath =
//    @"C:\Users\HomePC\source\repos\Installer\Prerequisites\SqlServer\SQLEXPR_x64_ENU\SETUP.exe";

//    bool result = installer.InstallSqlServer(setupPath);

//    if (result)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("SQL Server Installed Successfully.");
//        Console.ResetColor();
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("SQL Server Installation Failed.");
//        Console.ResetColor();
//}
//}
//else
//{
//    Console.WriteLine();
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("SQL Server already installed.");
//    Console.ResetColor();
//}
//Console.WriteLine();
//Console.WriteLine("Press any key to exit...");
//Console.ReadKey();

////static List<string> GetSqlInstances()
////{
////    List<string> result = new();

////    try
////    {
////        using RegistryKey? key =
////            Registry.LocalMachine.OpenSubKey(
////                @"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");

////        if (key != null)
////        {
////            foreach (string name in key.GetValueNames())
////            {
////                result.Add(Environment.MachineName + "\\" + name);
////            }
////        }
////    }
////    catch
////    {
////    }

////    return result;
////}
///


using InstallerHelper;
using InstallerHelper.Logging;
using InstallerHelper.Models;

Console.Title = "Installer Helper";

InstallerLogger.Info("======================================");
InstallerLogger.Info(" TEAMARRIVE SOFTWARE COMPANY");
InstallerLogger.Info(" Installer Helper");
InstallerLogger.Info("======================================");
Console.WriteLine();

// Expected Arguments:
// args[0] = Install Directory
// Example:
// C:\Program Files\TEAMARRIVE\Stock Management System
//
// args[1] = SQL Server Setup Folder
// Example:
// C:\Users\<User>\AppData\Local\Temp\is-XXXX.tmp\SqlServer\SQLEXPR_x64_ENU



//if (args.Length < 2)
//{
//    InstallerLogger.Error("Invalid installer arguments.");
//    Console.WriteLine();
//    Console.WriteLine("Press any key to exit...");
//    Console.ReadKey();
//    return;
//}

//string installPath = args[0];
//string sqlFolder = args[1];

//string sqlSetupPath = Path.Combine(
//    sqlFolder,
//    "SETUP.exe");

//string appSettingsPath = Path.Combine(
//    installPath,
//    "appsettings.json");

//string applicationPath = Path.Combine(
//    installPath,
//    "StockManagementSystem.exe");

//InstallerService installer = new();

//InstallerResult result = installer.Install(
//    sqlSetupPath,
//    appSettingsPath,
//    applicationPath);

//if (result.Success)
//{
//    InstallerLogger.Success(result.Message);
//    Environment.Exit(0);
//}
//else
//{
//    InstallerLogger.Error(result.Message);
//    Environment.Exit(1);
//}


InstallerService installer = new();

InstallerResult result;

if (args.Length == 1 &&
    args[0].Equals("uninstall", StringComparison.OrdinalIgnoreCase))
{
    result = installer.Uninstall();
}
else if (args.Length >= 2)
{
    string installPath = args[0];
    string sqlFolder = args[1];

    string sqlSetupPath = Path.Combine(sqlFolder, "SETUP.exe");

    string appSettingsPath = Path.Combine(
        installPath,
        "appsettings.json");

    string applicationPath = Path.Combine(
        installPath,
        "StockManagementSystem.exe");

    result = installer.Install(
        sqlSetupPath,
        appSettingsPath,
        applicationPath);
}
else
{
    InstallerLogger.Error("Invalid installer arguments.");
    Console.WriteLine();
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
    return;
}

if (result.Success)
{
    InstallerLogger.Success(result.Message);
    Environment.Exit(0);
}
else
{
    InstallerLogger.Error(result.Message);
    Environment.Exit(1);
}


//if (result.Success)
//{
//    InstallerLogger.Success(result.Message);
//}
//else
//{
//    InstallerLogger.Error(result.Message);
//}

//Console.WriteLine();
//Console.WriteLine("Press any key to exit...");
//Console.ReadKey();