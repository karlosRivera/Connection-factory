using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionManager
{
    public static class ConfigurationSettings
    {
        #region Local Variables
        static string __PartProcPath = string.Empty;
        static string __FittingPath = string.Empty;
        static string __WebPicPath = string.Empty;
        static string __FAQPath = string.Empty;
        static string __WCFServiceURI = string.Empty;
        static string __INIFile;
        static string __securityKey = "FFAD-GTXM-WPVR-ZTPI";
        static bool __PCPermittedToViewProcedures;
        static bool __UserPermittedToViewProcedures;
        static bool __OnlyForProcedurePC;
        static string __LogoutTime;
        static bool __BypassSMS;
        static bool __ByPassSecurityKey;
        #endregion

        #region Property Declarations
        public static string SecurityKeyAtORCS
        {
            get
            {
                //return RetrieveSecurityKeyfromORCS();
                return string.Empty;
            }
        }

        public static string SecurityKey
        {
            get
            {
                return __securityKey;
            }
        }

        public static string PartProcPath
        {
            get
            {
                return __PartProcPath;
            }
            set
            {
                __PartProcPath = value;
            }
        }

        public static string FittingPath
        {
            get
            {
                return __FittingPath;
            }
            set
            {
                __FittingPath = value;
            }
        }

        public static string WebPicPath
        {
            get
            {
                return __WebPicPath;
            }
            set
            {
                __WebPicPath = value;
            }
        }

        public static string FAQPath
        {
            get
            {
                return __FAQPath;
            }
            set
            {
                __FAQPath = value;
            }
        }

        public static string WCFServiceURI
        {
            get
            {
                return __WCFServiceURI;
            }
        }

        public static bool PCPermittedToViewProcedures
        {
            get
            {
                return __PCPermittedToViewProcedures;
            }
            set
            {
                __PCPermittedToViewProcedures = value;
            }
        }

        public static bool UserPermittedToViewProcedures
        {
            get
            {
                return __UserPermittedToViewProcedures;
            }
            set
            {
                __UserPermittedToViewProcedures = value;
            }
        }

        public static string LogoutTime
        {
            get
            {
                return __LogoutTime;
            }
            set
            {
                __LogoutTime = value;
            }
        }

        public static bool LogOutOnlyFromProcedurePCs
        {
            get
            {
                return __OnlyForProcedurePC;
            }
            set
            {
                __OnlyForProcedurePC = value;
            }
        }

        public static bool ByPassSecurityKey
        {
            get
            {
                return __ByPassSecurityKey;
            }
        }

        public static bool ByPassSMS
        {
            get
            {
                return __BypassSMS;
            }
        }

        #endregion

        public static void SetConfigParameters()
        {
            SqlDataReader drConfig = null ;
            try
            {
                SqlCommand cmd = new SqlCommand();
                drConfig = cmd.ExecuteReader();
            }
            catch
            {

            }

            //SqlConnection Con;
            //SqlCommand cmd;
            //SqlDataReader drConfig;
            //SqlParameter sqlParam;
            //Con = new SqlConnection("");
            //cmd = new SqlCommand();
            //cmd.CommandText = "spConfigurationSetting";
            //cmd.CommandType = CommandType.StoredProcedure;


            //sqlParam = new SqlParameter("@DMLType", 3);
            //cmd.Parameters.Add(sqlParam);

            try
            {
            //    Con.Open();
            //    cmd.Connection = Con;
            //    drConfig = cmd.ExecuteReader();
            //    if (drConfig.HasRows)
            //    {
            //        drConfig.Read();
            //        __PartProcPath = drConfig["PartProcPath"].ToString();
            //        __FittingPath = drConfig["FittingPath"].ToString();
            //        __WebPicPath = drConfig["WebPicPath"].ToString();
            //        __FAQPath = drConfig["FAQPath"].ToString();
            //        __OnlyForProcedurePC = (bool)drConfig["OnlyForProcEnablePC"];
            //        __LogoutTime = drConfig["LogOutTime"].ToString();
            //        __BypassSMS = (bool)drConfig["BypassSecuritySMS"];
            //        __ByPassSecurityKey = (bool)drConfig["BypasSecurityKey"];
            //        __WCFServiceURI = drConfig["WCFServiceURI"].ToString();

            //        DBCommon.PhoneServerUNC = drConfig["PhoneServerUNC"].ToString();
            //        CurrentCountry.PurolatorDrive = drConfig["PurolatorDrive"].ToString();
            //        CurrentCountry.PhoneNo = drConfig["PhoneNo"].ToString();
            //        CurrentCountry.UPSDrive = drConfig["UPSDrive"].ToString();
            //        CurrentCountry.IsSage = (bool)drConfig["IsSage"];
                    DBCommon.initDBCredentials(drConfig);
                //}
                //else
                //{
                //    __PartProcPath = string.Empty;
                //    __FittingPath = string.Empty;
                //    __WebPicPath = string.Empty;
                //    __FAQPath = string.Empty;
                //    __OnlyForProcedurePC = false;
                //    __LogoutTime = "00:08:50";
                //    __WCFServiceURI = string.Empty;

                //    DBCommon.PhoneServerUNC = string.Empty;
                //    CurrentCountry.PurolatorDrive = @"U:\";
                //    CurrentCountry.UPSDrive = @"U:\";
                //    CurrentCountry.IsSage = true;
                //}
                //drConfig.Dispose();
            }

            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                //Con.Close();
                //cmd.Dispose();
                //sqlParam = null;
            }
        }
    }
}
