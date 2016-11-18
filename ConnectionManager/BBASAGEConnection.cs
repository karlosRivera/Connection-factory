using System;
using System.Collections.Generic;
using System.Data.Odbc;
using ConnectionManager.Factory;

namespace ConnectionManager
{
    public sealed class SAGEConnection
    {
        OdbcConnection sageCon;

        public SAGEConnection()
        {
            string connectionString = DBConnectionFactory.GetDBConnectionString<DBConnectionString>(DBCommon.SAGECredential).ToString();
            sageCon = new OdbcConnection(connectionString);
        }

        public OdbcConnection Connection
        {
            get
            {
                return sageCon;
            }
        }

    }
}
