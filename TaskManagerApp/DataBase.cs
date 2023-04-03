using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TaskManagerApp
{
    public class DataBase
    {
        SqlConnection connection = new SqlConnection(@"Data Source = HonkAppDataBase.mssql.somee.com;" + "Initial Catalog=HonkAppDataBase;" + "User id=	cargoesbrr_SQLLogin_1;" + "Password=nchbzqmryy;");
        public void openConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        public void closeConnetion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
