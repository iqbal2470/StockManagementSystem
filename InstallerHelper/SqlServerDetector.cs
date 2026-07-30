using InstallerHelper.Logging;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper
{
    public class SqlServerDetector
    {
        public string? SelectedInstance { get; private set; }

        public bool DatabaseExists(string instanceName, string databaseName)
        {
            try
            {
                string connectionString =
                    $"Server={instanceName};Database=master;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;";

                using SqlConnection con = new(connectionString);

                con.Open();

                using SqlCommand cmd = new(
                    "SELECT COUNT(*) FROM sys.databases WHERE name=@db",
                    con);

                cmd.Parameters.AddWithValue("@db", databaseName);

                int count = (int)cmd.ExecuteScalar()!;

                if (count > 0)
                {
                    SelectedInstance = instanceName;
                    return true;
                }
            }
            catch (Exception ex)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine($"Error checking database on {instanceName}");
                //Console.WriteLine(ex.Message);
                //Console.ResetColor();
                InstallerLogger.Error(ex.Message);
            }

            return false;
        }
    }
}
