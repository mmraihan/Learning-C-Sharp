using System;
using System.Collections.Generic;

namespace _29_AbstractVsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetBasicInformation();

            Department department = new Department();
            department.GetBasicInformation();

            Course course = new Course("CSE112", "Intermediate C#", "3");
            var result = course.GetBasicInformation();
            Console.WriteLine(result);

            IInformation information = student;
            information = department;

            Iprinter iprinter = student;



            List<IInformation> information1 = new List<IInformation>();
            information1.Add(department);
            information1.Add(student);
            information1.Add(course);

            Console.ReadLine();
        }
    }
}
