using System;
using System.Collections.Generic;

namespace Ass0ciation_Relationship_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.Title = "Compiler";
            course.Code = "112";
            course.Credit = 3.5;

            Course course2 = new Course();
            course2.Title = "C#";
            course2.Code = "112";
            course2.Credit = 3.5;

            Course course3 = new Course();
            course3.Title = "DLD";
            course3.Code = "112";
            course3.Credit = 3.5;




            ;

            //List<Course> courseList = new List<Course>();
            //courseLiost.Add(course);
            //courseLiost.Add(course2);
            //courseLiost.Add(course3);
          



            Department department = new Department();
            department.Name = "CSE";
            department.Code = "123";
            //department.Courses = courseList;

            department.Courses.Add(course);
            department.Courses.Add(course2);
            department.Courses.Add(course3);

            Console.WriteLine(department.GetDepInfo());

            Console.ReadLine();


        }
    }
}
