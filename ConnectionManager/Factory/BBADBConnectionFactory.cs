using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConnectionManager.Credentials;

namespace ConnectionManager.Factory
{
    public class DBConnectionFactory
    {



        public static T GetDBConnectionString<T>(IDBCredentials DBCredentials)
        {
            return (T)Activator.CreateInstance(typeof(T), DBCredentials);
        }

        public static T GetConnection<T>() where T : new()
        {
            return new T();
        }

        
        public static T GetGenericConnection<T>(ConnectionType ConnectionFor)
        {
            if (ConnectionFor == ConnectionType.LocalSQLConnection)
                return (T)Convert.ChangeType((new SQLLocalConnection()).Connection, typeof(T));
            else if (ConnectionFor == ConnectionType.ORCSWEBSQLConnection)
                return (T)Convert.ChangeType((new ORCSSQLConnection()).Connection, typeof(T)); 
            else if (ConnectionFor == ConnectionType.ReportConnection)
                return (T)Convert.ChangeType((new SQLReportConnection()).Connection, typeof(T)); 
            else
                return (T)Convert.ChangeType((new SAGEConnection()).Connection, typeof(T));
        }
        

        //public static T GetGenericConnection<T>() where T : struct, IConvertible
        //{
        //    if (!typeof(T).IsEnum)
        //    {
        //        throw new ArgumentException("T must be an enumerated type");
        //    }
        //    else
        //    {
        //        Enum eAsEnum = (Enum)T;
        //    }
            
        //}

        //public static Nullable<T> GetQueryString<T>(string key) where T : struct, IConvertible
        //{
        //    T result = default(T);

        //    if (String.IsNullOrEmpty(HttpContext.Current.Request.QueryString[key]) == false)
        //    {
        //        string value = HttpContext.Current.Request.QueryString[key];

        //        try
        //        {
        //            result = (T)Convert.ChangeType(value, typeof(T));
        //        }
        //        catch
        //        {
        //            //Could not convert.  Pass back default value...
        //            result = default(T);
        //        }
        //    }

        //    return result;
        //}


        public static IDbConnection GetDBConnection(ConnectionType ConnectionFor)
        {
            if (ConnectionFor == ConnectionType.LocalSQLConnection)
                return (new SQLLocalConnection()).Connection;
            else if (ConnectionFor == ConnectionType.ORCSWEBSQLConnection)
                return (new ORCSSQLConnection()).Connection;
            else if (ConnectionFor == ConnectionType.ReportConnection)
                return (new SQLReportConnection()).Connection;
            else
                return (new SAGEConnection()).Connection;
        }



        public static Enum T { get; set; }
    }
}