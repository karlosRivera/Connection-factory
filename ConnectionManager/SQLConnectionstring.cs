using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ConnectionManager.Properties;
using ConnectionManager.Credentials;

namespace ConnectionManager
{
    public class DBConnectionString
    {
        private string connectionString;

        public DBConnectionString(SQLDBCredentials SQLCredential)
        {
            if (SQLCredential == null || string.IsNullOrEmpty(SQLCredential.SQLServer) || string.IsNullOrEmpty(SQLCredential.SQLDBName) || string.IsNullOrEmpty(SQLCredential.UserName)) throw new ArgumentException(Resources.ExceptionNullInvalidCredentials, "connectionString");
            connectionString = string.Format("UID={0};PWD={1};Server={2};Database={3};connection timeout=300", new string[] { SQLCredential.UserName, SQLCredential.UserPassword, SQLCredential.SQLServer, SQLCredential.SQLDBName });
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentException(Resources.ExceptionNullOrEmptyString, "connectionString");
        }

        public override string ToString()
        {
            return connectionString;
        }
    }
}
