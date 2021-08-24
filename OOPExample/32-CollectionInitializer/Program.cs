using System;
using System.Collections.Generic;

namespace _32_CollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student() { Name = "Raihan1", Id = 1, Age = 24 };
            //Student student2 = new Student() { Name = "Raihan2", Id = 2, Age = 24 };
            //Student student3 = new Student() { Name = "Raihan3", Id = 3, Age = 24 };
            //Student student4 = new Student() { Name = "Raihan4", Id = 4, Age = 24 };


            //List<Student> studentList = new List<Student>();
            //studentList.Add(student1);

            List<Student> studentList = new List<Student>()
            {
                new Student(){Name="Raihan", Id=1, Age=24},
                new Student(){Name="Raihan2", Id=2, Age=24},
                new Student(){Name="Raihan3", Id=3, Age=24},
            };
            Console.WriteLine();


        }

    }
}
