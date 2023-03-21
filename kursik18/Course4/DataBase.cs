using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Course3
{
    public class DataBase
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=LEON-PC\SQLEXPRESS; Initial Catalog=coursach;Integrated Security=True");
        public void openConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlconnection;
        }
    }
}
