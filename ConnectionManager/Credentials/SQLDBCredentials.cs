using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionManager.Credentials
{
    public class SQLDBCredentials : IDBCredentials
    {
        #region Local Variable Declarations
        string __ServerName, __DatabaseName, __UserName, __Password;
        #endregion

        #region Constructor
        public SQLDBCredentials(string ServerName, string DatabaseName, string UserName, string Password)
        {
            __ServerName = ServerName;
            __DatabaseName = DatabaseName;
            __UserName = UserName;
            __Password = Password;
        }
        #endregion

        #region Properties
        #region SQLServer
        public string SQLServer
        {
            get
            {
                return __ServerName;
            }
        }
        #endregion

        #region SQLDBName
        public string SQLDBName
        {
            get
            {
                return __DatabaseName;
            }
        }
        #endregion

        #region UserName
        public string UserName
        {
            get
            {
                return __UserName;
            }
        }
        #endregion

        #region UserPassword
        public string UserPassword
        {
            get
            {
                return __Password;
            }
        }
        #endregion
        #endregion
    }
}
