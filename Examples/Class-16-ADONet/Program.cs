using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Class_16_ADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var connectionString= "Server=.\\;Database=CSharpBarhch8;Trusted_Connection=True";

            var insertSql =$"insert into students ([name], dateOfBirth, cgpa) values (@NAME, '2/3/2002', 3.01) ";
            var deleteSql = "delete from students where name='Mahadi'";
            var selectSql = "select * from students";
           var data= ExecuteQuery(connectionString, selectSql, new List<SqlParameter>());

            foreach (var item in data)
            {
                Console.WriteLine($"Name: {item.Name}, Id: {item.Id}, Date Of Birth: {item.DateOfBirth}, CGPA: {item.CGPA} ");
            }
            Console.ReadKey();

            //ExecuteNonQuery(connectionString,insertSql, new List<SqlParameter> { new SqlParameter("@Name", name)});


        }

        public static void ExecuteNonQuery(string connectionString, string sql, List<SqlParameter> parameters )
        {
            

            using SqlCommand command = GetCommand(connectionString);
      
            command.CommandText = sql;
            command.Parameters.AddRange(parameters.ToArray());
            command.ExecuteNonQuery();

            //command.Dispose();

            //if (connection.State==System.Data.ConnectionState.Open)
            //{
            //    connection.Close();
            //}
            //connection.Dispose(); //Object Dispose
            //1.37 Mins.
        }

        public static List<Student> ExecuteQuery(string conectionString, string sql, List<SqlParameter> parameters)
        {
            using SqlCommand command = GetCommand(conectionString);

            command.CommandText = sql;
            command.Parameters.AddRange(parameters.ToArray());

            var students = new List<Student>();
            command.ExecuteNonQuery();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = (int)reader[0];
                var name = (string)reader[1];
                var dob = (DateTime)reader[2];
                var cgpa = (decimal)reader[3];
                students.Add(new Student()
                {
                    Id = id,
                    Name = name,
                    DateOfBirth = dob,
                    CGPA = cgpa
                }); 
            }
            return students;

        }


        private static SqlCommand GetCommand(string connectionString)
        {
             SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

           SqlCommand command = new SqlCommand();
            command.Connection = connection;

            return command;
        }


    }

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public decimal CGPA { get; set; }
    }

}
