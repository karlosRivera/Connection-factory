using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ConnectionManager.Credentials;
using ConnectionManager.Factory;

namespace ConnectionManager
{
    public enum ConnectionType
    {
        LocalSQLConnection,
        ORCSWEBSQLConnection,
        ReportConnection,
        SageConnection
    }

    public static class DBCommon
    {
        public enum DataConnection
        {

        }

        #region Local variables
        static Dictionary<string, string> CountryName;
        static Dictionary<string, string> SQLServers;
        static Dictionary<string, string> SQLDBs;
        static Dictionary<string, string> SQLDBUsers;
        static Dictionary<string, string> SQLDBUsersPasword;

        static SQLDBCredentials __SQLCredentialLocal;
        static SQLDBCredentials __SQLCredentialReport;
        static SQLDBCredentials __SQLCredentialORCS;
        static SAGEDBCredentials __SAGECredential;

        static string __PhoneServerUNC;
        #endregion

        #region Properties

        public static string PhoneServerUNC
        {
            get
            {
                return __PhoneServerUNC;
            }
            set
            {
                __PhoneServerUNC = value;
            }
        }

        public static SQLDBCredentials SQLCredentialLocal
        {
            get
            {
                return __SQLCredentialLocal;
            }
        }

        #region SQLCredentialReport
        public static SQLDBCredentials SQLCredentialReport
        {
            get
            {
                return __SQLCredentialReport;
            }
        }
        #endregion

        #region SQLCredentialORCS
        public static SQLDBCredentials SQLCredentialORCS
        {
            get
            {
                return __SQLCredentialORCS;
            }
        }
        #endregion

        #region SAGECredential
        public static SAGEDBCredentials SAGECredential
        {
            get
            {
                return __SAGECredential;
            }
        }
        #endregion
        #endregion

        #region Database Initialization
        public static void InitializeDBObject(DataTable CountryTable)
        {
            CountryName = new Dictionary<string, string>();
            SQLServers = new Dictionary<string, string>();
            SQLDBs = new Dictionary<string, string>();
            SQLDBUsers = new Dictionary<string, string>();
            SQLDBUsersPasword = new Dictionary<string, string>();

            foreach (DataRow drCountry in CountryTable.Rows)
            {
                CountryName.Add(drCountry["Code"].ToString(), drCountry["Name"].ToString());
                SQLServers.Add(drCountry["Code"].ToString(), drCountry["ServerName"].ToString());
                SQLDBs.Add(drCountry["Code"].ToString(), drCountry["DBName"].ToString());
                SQLDBUsers.Add(drCountry["Code"].ToString(), drCountry["DBLoginName"].ToString());
                SQLDBUsersPasword.Add(drCountry["Code"].ToString(), drCountry["DBLoginPWD"].ToString());
            }

            CurrentCountry.CountryName = CountryName[CurrentCountry.CountryCode];
            //IsSageCustomerFromSQLServer = false;
            __SQLCredentialLocal = new SQLDBCredentials(SQLServers[CurrentCountry.CountryCode], SQLDBs[CurrentCountry.CountryCode], SQLDBUsers[CurrentCountry.CountryCode], SQLDBUsersPasword[CurrentCountry.CountryCode]);
        }
        #endregion

        public static void initDBCredentials(SqlDataReader ForCredentials)
        {
            //__SageDSNs = ForCredentials["SageDSN"].ToString();
            //__SageUsers = ForCredentials["SageUser"].ToString();
            //__SageUserPasswords = ForCredentials["SagePWD"].ToString();
            __SQLCredentialLocal = new SQLDBCredentials("Myserver", "Mydb", "user", "pwd");
            __SQLCredentialReport = new SQLDBCredentials("Myserver", "Mydb","user","pwd");
            __SQLCredentialORCS = new SQLDBCredentials("Myserver", "Mydb", "user", "pwd");
            __SAGECredential = new SAGEDBCredentials("SageDSN", "SageUser", "SagePWD");
            __PhoneServerUNC = "PhoneServerUNC";

        }

        public static string GetQBPath()
        {
            SqlCommand cmd;
            SqlParameter param;
            SqlDataReader drSync;
            SqlConnection Con = (DBConnectionFactory.GetConnection<SQLLocalConnection>()).Connection;
            string sqlQry = "";
            string QBPath = "";
            Con.Open();
            //sqlQry = "SELECT Value FROM Config WHERE Key = 'QBDB'";
            cmd = new SqlCommand();
            cmd.CommandText = "spConfig";
            cmd.CommandType = CommandType.StoredProcedure;
            param = new SqlParameter("@DMLType", 1);
            cmd.Parameters.Add(param);
            //cmd = new SqlCommand(sqlQry, Con);
            try
            {
                drSync = cmd.ExecuteReader();
                if (drSync.HasRows)
                {
                    drSync.Read();
                    QBPath = drSync["Value"].ToString();
                    drSync.Dispose();
                }
                else
                    throw new Exception("Quick Book data path has not been set");
                return QBPath;
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
            finally
            {
                Con.Close();

                cmd.Dispose();
                sqlQry = string.Empty;

            }
        }
        //#region ExecuteSQL On current Connection
        //public static bool ExecuteSql(string strSql)
        //{
        //    bool flag = false;
        //    int i = 0;
        //    SqlConnection conn = new SqlConnection(Business.SQLDB.ConnectionString);
        //    SqlCommand command = conn.CreateCommand();
        //    command.CommandText = strSql;
        //    try
        //    {
        //        conn.Open();
        //        i = command.ExecuteNonQuery();
        //        conn.Close();
        //        flag = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        flag = false;
        //    }
        //    return flag;
        //}
        //#endregion
    }
}
