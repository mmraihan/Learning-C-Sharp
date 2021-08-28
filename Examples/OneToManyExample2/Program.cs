using System;

namespace OneToManyExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Code = "111";
            course1.Title = "Basic C#";
            course1.Credit = 3.00;

            Course course2 = new Course();
            course2.Code = "112";
            course2.Title = "Intermediate C#";
            course2.Credit = 3.00;

            Course course3 = new Course();
            course3.Code = "112";
            course3.Title = "Advance C#";
            course3.Credit = 3.00;


            Department department = new Department();
            department.Code = "CSE-211";
            department.Name = "CSE";
            department.Courses.Add(course1);
            department.Courses.Add(course2);
            department.Courses.Add(course3);


            var result=department.GetDepartmentInfo();

            Console.WriteLine(result);
        }
    }
}
