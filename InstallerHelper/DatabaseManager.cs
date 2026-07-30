using InstallerHelper.Logging;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper
{
    public class DatabaseManager
    {
        public bool CreateDatabase(string instanceName, string databaseName)
        {
            try
            {
                string connectionString =
                    $"Server={instanceName};Database=master;Integrated Security=True;TrustServerCertificate=True;Encrypt=True;";

                using SqlConnection con = new(connectionString);

                con.Open();

                string sql = $@"
IF DB_ID('{databaseName}') IS NULL
BEGIN
    CREATE DATABASE [{databaseName}]
END";

                using SqlCommand cmd = new(sql, con);

                cmd.ExecuteNonQuery();

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
