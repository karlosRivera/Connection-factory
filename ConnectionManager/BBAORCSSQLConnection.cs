using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectionManager.Factory;

namespace ConnectionManager
{
    public sealed class ORCSSQLConnection
    {
        SqlConnection sqlCon;


        public ORCSSQLConnection()
        {
            string connectionString = DBConnectionFactory.GetDBConnectionString<DBConnectionString>(DBCommon.SQLCredentialORCS).ToString();
            sqlCon = new SqlConnection(connectionString);
        }

        public SqlConnection Connection
        {
            get
            {
                return sqlCon;
            }
        }

    }
}
