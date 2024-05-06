using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
 
namespace DAL
{
    public class Database
    {
        private QLBHXDataContext dbo;
        private SqlConnection connection;

        public Database()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBHXConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            dbo = new QLBHXDataContext(connectionString);
        }

        public QLBHXDataContext DBO { get => dbo; }

        public SqlConnection Connection { get => connection; }

    }
}
