using InstallerHelper.Constants;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerHelper
{
    public class DatabaseRemover
    {
        public bool RemoveDatabase(string serverName)
        {
            try
            {
                string connectionString =
                    $"Server={serverName};Database=master;Integrated Security=True;TrustServerCertificate=True;";

                using SqlConnection connection = new(connectionString);
                connection.Open();

                string sql = $@"
IF DB_ID('{InstallerConstants.DatabaseName}') IS NOT NULL
BEGIN
    ALTER DATABASE [{InstallerConstants.DatabaseName}]
    SET SINGLE_USER
    WITH ROLLBACK IMMEDIATE;

    DROP DATABASE [{InstallerConstants.DatabaseName}]
END";

                using SqlCommand command = new(sql, connection);
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
