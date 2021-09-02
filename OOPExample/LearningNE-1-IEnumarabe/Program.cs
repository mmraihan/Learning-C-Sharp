using System;
using System.Collections.Generic;

namespace LearningNE_1_IEnumarabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.Id = 1;
            std1.Name = "Raihan";
            std1.Standard = 001;

            Student std2 = new Student();
            std2.Id = 2;
            std2.Name = "Raihan2";
            std2.Standard = 002;

            Student std3 = new Student();
            std3.Id = 3;
            std3.Name = "Raihan3";
            std3.Standard = 003;




            List<Student> students = new List<Student>();
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);


            School students3 = new School();
            students3.Add(std1);
            students3.Add(std2);
            students3.Add(std3);


           




            foreach (Student item in students)
            {
                Console.WriteLine($"Student's ID: {item.Id}, Name: {item.Name}, Standard: {item.Standard}" );
            }

            Console.ReadKey();


        }
    }
}
