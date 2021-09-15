using System;
using System.Data.SqlClient;

namespace Class_16_ADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString= "Server=.\\;Database=CSharpBarhch8;Trusted_Connection=True";

            var insertSql = "insert into students ([name], dateOfBirth, cgpa) values ('Mahadi', '2/3/2002', 3.01) ";
            var deleteSql = "delete from students where name='Mahadi'";

            ExecuteNonQuery(connectionString,deleteSql);

        }

        public static void ExecuteNonQuery(string connectionString, string sql)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            using SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            command.ExecuteNonQuery();

            //command.Dispose();

            //if (connection.State==System.Data.ConnectionState.Open)
            //{
            //    connection.Close();
            //}
            //connection.Dispose(); //Object Dispose
            //1.24 Mins.
        }

    }
}
