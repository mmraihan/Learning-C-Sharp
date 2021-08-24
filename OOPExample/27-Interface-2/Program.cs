using System;

namespace _27_Interface_2
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
            var result= course.GetBasicInformation();
            Console.WriteLine(result);
        }
    }
}
