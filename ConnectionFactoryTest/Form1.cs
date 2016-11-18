using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionManager;
using ConnectionManager.Factory;
using ConnectionManager.Credentials;

namespace ConnectionFactoryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ConnectionManager.ConfigurationSettings.SetConfigParameters();

            SqlConnection conn = (SqlConnection) ConnectionManager.Factory.DBConnectionFactory.GetDBConnection(ConnectionType.LocalSQLConnection);
            string connectionString = DBConnectionFactory.GetDBConnectionString<DBConnectionString>(DBCommon.SQLCredentialLocal).ToString();

            SqlConnection conn1 = (SqlConnection) ConnectionManager.Factory.DBConnectionFactory.GetGenericConnection<SQLLocalConnection>(ConnectionType.LocalSQLConnection);

            //string connectionString = ConnectionManager.GetDBConnectionString<SQLConnectionstring>(DBCommon.LocalSQLConnection).ToString();
            //sqlCon = new SqlConnection(connectionString);

        }
    }
}
