using System.Data.SqlClient;
namespace CourseProject2
{
    public class DataBase
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=LEON-PC\SQLEXPRESS; Inital Catalog=Course;Integrated Security");
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
