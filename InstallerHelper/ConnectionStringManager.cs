using InstallerHelper.Constants;
using InstallerHelper.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace InstallerHelper
{
    public class ConnectionStringManager
    {
        public bool UpdateConnectionString(
            string appSettingsPath,
            string instanceName,
            string databaseName)
        {
            try
            {
                InstallerLogger.Info($"AppSettings Path : {appSettingsPath}");
                InstallerLogger.Info($"SQL Instance : {instanceName}");


                if (!File.Exists(appSettingsPath))
                    throw new FileNotFoundException(
                        "appsettings.json not found.",
                        appSettingsPath);

                string json = File.ReadAllText(appSettingsPath);

                JsonNode? root = JsonNode.Parse(json);

                if (root == null)
                    throw new Exception("Invalid appsettings.json");

                string connectionString =
                    $"Server={instanceName};" +
                    $"Database={databaseName};" +
                    $"Integrated Security=True;" +
                    $"TrustServerCertificate=True;" +
                    $"Encrypt=True;";

                //root["ConnectionStrings"]!["Conn"] = connectionString;
                root["ConnectionStrings"]![InstallerConstants.ConnectionName]
    = connectionString;

                File.SetAttributes(appSettingsPath, FileAttributes.Normal);

                File.WriteAllText(
                    appSettingsPath,
                    root.ToJsonString(new JsonSerializerOptions
                    {
                        WriteIndented = true
                    }));

                InstallerLogger.Success("appsettings.json updated successfully.");

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
