using InstallerHelper.Constants;
using InstallerHelper.Logging;
using InstallerHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper
{
    public class InstallerService
    {
        //private const string DatabaseName = "StockManagementDB";
        private readonly ApplicationLauncher _launcher = new();

        private readonly SqlInstaller _sqlInstaller = new();
        private readonly SqlServerDetector _sqlDetector = new();
        private readonly DatabaseManager _databaseManager = new();
        private readonly ConnectionStringManager _connectionStringManager = new();
        private readonly DatabaseRemover _databaseRemover = new();
        public InstallerResult Install(
            string sqlSetupPath,
            string appSettingsPath,
            string applicationPath)
        {
            try
            {
                InstallerLogger.Info("========== INSTALL START ==========");
                InstallerLogger.Info("Step 1 : Checking SQL Server...");

                // 1. SQL Installed?
                if (!_sqlInstaller.IsSqlInstalled())
                {
                    //Console.WriteLine("SQL Server not found.");
                    InstallerLogger.Warning("SQL Server not found.");

                    //if (!_sqlInstaller.InstallSqlServer(sqlSetupPath))
                    //    return false;

                    if (!_sqlInstaller.InstallSqlServer(sqlSetupPath))
                    {
                        return new InstallerResult
                        {
                            Success = false,
                            Message = "SQL Server installation failed."
                        };
                    }

                    // 👇 YE CODE YAHAN ADD KARO
                    InstallerLogger.Info("Waiting for SQL Server service...");

                    for (int i = 0; i < 60; i++)
                    {
                        var tempInstances = SqlInstanceHelper.GetSqlInstances();

                        if (tempInstances.Count > 0)
                        {
                            InstallerLogger.Success("SQL Server instance detected.");
                            break;
                        }

                        Thread.Sleep(1000);
                    }

                }

                InstallerLogger.Success("SQL Server installation completed.");

                InstallerLogger.Info("Step 2 : Detecting SQL Instance...");

                // 2. Detect Instance
                var instances = SqlInstanceHelper.GetSqlInstances();

                //if (instances.Count == 0)
                //{
                //    Console.WriteLine("No SQL Instance Found.");
                //    return false;
                //}

                if (instances.Count == 0)
                {

                    InstallerLogger.Error("No SQL Instance Found.");

                    return new InstallerResult
                    {
                        Success = false,
                        Message = "No SQL Server instance found."
                    };
                }

                //string selectedInstance = instances[0];

                //Console.WriteLine($"Using Instance : {selectedInstance}");

                string? selectedInstance = null;

                // Check if database already exists in any instance
                foreach (var instance in instances)
                {
                    if (_sqlDetector.DatabaseExists(instance, InstallerConstants.DatabaseName))
                    {
                        selectedInstance = instance;
                        Console.WriteLine($"Existing database found on : {instance}");
                        break;
                    }
                }

                // If database not found, use first available instance
                selectedInstance ??= instances[0];

                //Console.WriteLine($"Selected Instance : {selectedInstance}");
                InstallerLogger.Info($"Selected Instance : {selectedInstance}");

                InstallerLogger.Info("Step 3 : Creating Database...");

                // 3. Create Database
                //if (!_databaseManager.CreateDatabase(selectedInstance, InstallerConstants.DatabaseName))
                //    return false;

                if (!_databaseManager.CreateDatabase(selectedInstance, InstallerConstants.DatabaseName))
                {
                    return new InstallerResult
                    {
                        Success = false,
                        Message = "Database creation failed."
                    };
                }

                InstallerLogger.Success("Database created successfully.");

                // 4. Update Connection String
                //if (!_connectionStringManager.UpdateConnectionString(
                //    appSettingsPath,
                //    selectedInstance,
                //    InstallerConstants.DatabaseName))
                //    return false;

                InstallerLogger.Info("Step 4 : Updating appsettings.json...");

                if (!_connectionStringManager.UpdateConnectionString(
    appSettingsPath,
    selectedInstance,
    InstallerConstants.DatabaseName))
                {
                    return new InstallerResult
                    {
                        Success = false,
                        Message = "Failed to update appsettings.json."
                    };
                }

                InstallerLogger.Success("Connection string updated.");
                InstallerLogger.Info("Step 5 : Launching Application...");


                //if (!_launcher.Launch(applicationPath))
                //    return false;

                if (!_launcher.Launch(applicationPath))
                {
                    return new InstallerResult
                    {
                        Success = false,
                        Message = "Failed to launch application."
                    };
                }

                //Console.WriteLine("Installer completed successfully.");
                InstallerLogger.Success("Installer completed successfully.");

                //return true;

                return new InstallerResult
                {
                    Success = true,
                    Message = "Installation completed successfully."
                };
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //return false;
                return new InstallerResult
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }



        public InstallerResult Uninstall()
        {
            try
            {
                var instances = SqlInstanceHelper.GetSqlInstances();

                if (instances.Count == 0)
                {
                    return new InstallerResult
                    {
                        Success = false,
                        Message = "No SQL Server instance found."
                    };
                }

                string? selectedInstance = null;

                foreach (var instance in instances)
                {
                    if (_sqlDetector.DatabaseExists(instance, InstallerConstants.DatabaseName))
                    {
                        selectedInstance = instance;
                        break;
                    }
                }

                if (selectedInstance == null)
                {
                    return new InstallerResult
                    {
                        Success = true,
                        Message = "Database not found. Nothing to remove."
                    };
                }

                if (!_databaseRemover.RemoveDatabase(selectedInstance))
                {
                    return new InstallerResult
                    {
                        Success = false,
                        Message = "Failed to remove database."
                    };
                }

                InstallerLogger.Success("Database removed successfully.");

                return new InstallerResult
                {
                    Success = true,
                    Message = "Database removed successfully."
                };
            }
            catch (Exception ex)
            {
                return new InstallerResult
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}
