using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConnectionManager.Credentials;
using ConnectionManager.Factory;

namespace ConnectionManager
{
    public sealed class SQLLocalConnection
    {
        SqlConnection sqlCon;

        public SQLLocalConnection()
        {
            string connectionString = DBConnectionFactory.GetDBConnectionString<DBConnectionString>(DBCommon.SQLCredentialLocal).ToString();
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
