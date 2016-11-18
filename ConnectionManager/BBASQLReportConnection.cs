using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConnectionManager.Credentials;
using ConnectionManager.Factory;

namespace ConnectionManager
{
    public sealed class SQLReportConnection
    {
        SqlConnection sqlCon;

        public SQLReportConnection()
        {
            string connectionString = DBConnectionFactory.GetDBConnectionString<DBConnectionString>(DBCommon.SQLCredentialReport).ToString();
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
