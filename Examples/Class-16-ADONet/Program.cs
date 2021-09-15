using System;
using System.Data.SqlClient;

namespace Class_16_ADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=.\\;Database=CSharpB8;Trusted_Connection=True";

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

           using SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "insert into students ([name], dateOfBirth, cgpa) values ('Hasan', '2/3/2002', 3.01) ";
            command.ExecuteNonQuery();

            //command.Dispose();

            //if (connection.State==System.Data.ConnectionState.Open)
            //{
            //    connection.Close();
            //}
            //connection.Dispose(); //Object Dispose

        }
    }
}
