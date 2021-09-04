using System;
using System.Collections.Generic;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student() { Id = 01, FirstName = "Md.", LastName = "Mubasshir" };
            Student student2 = new Student() { Id = 02, FirstName = "Md.", LastName = "Raihan" };
            Student student3 = new Student() { Id = 03, FirstName = "Md.", LastName = "Maruf" };


            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(student1);
            listOfStudents.Add(student2);
            listOfStudents.Add(student3);

            listOfStudents.Add(new Student { Id = 04, FirstName = "Kazi", LastName="Ibrahim" });
            listOfStudents.Add(new Student { Id = 05, FirstName = "Akil", LastName="Chy" });
            listOfStudents.Add(new Student { Id = 06, FirstName = "Kazi", LastName="Tanjib" });
           



            foreach (var item in listOfStudents)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.FirstName} {item.LastName}");
            }



            




        }
    }
}
