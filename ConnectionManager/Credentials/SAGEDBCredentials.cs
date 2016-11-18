using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionManager.Credentials
{
    public class SAGEDBCredentials : IDBCredentials
    {
        #region Local Variable Declarations
        string __DSNName, __SageUserID, __Password;
        #endregion

        #region Constructor
        public SAGEDBCredentials(string SageDSN, string UserName, string Password)
        {
            __DSNName = SageDSN;
            __SageUserID = UserName;
            __Password = Password;
        }
        #endregion

        #region Properties
        #region SAGEDSN
        public string SageDSN
        {
            get
            {
                return __DSNName;
            }
        }
        #endregion

        #region UserName
        public string UserName
        {
            get
            {
                return __SageUserID;
            }
        }
        #endregion

        #region userPassword
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
