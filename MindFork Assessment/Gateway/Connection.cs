using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Gateway
{
    public class Connection
    {
        private static readonly SqlConnectionStringBuilder connection =
           new SqlConnectionStringBuilder
           {
               DataSource = "ISHTIAQASIF-PC",
               InitialCatalog = "MindForkDB",
               IntegratedSecurity = true,
               ConnectTimeout = 30,
               Encrypt = false,
               TrustServerCertificate = false
           };

        public static IDbConnection DBConnection = new SqlConnection(connection.ConnectionString);
    }
}
