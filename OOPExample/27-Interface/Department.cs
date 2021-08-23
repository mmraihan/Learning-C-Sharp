using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Interface
{
   public class Department : IInformation
    {


        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        public string Code { get; set; }
        public string Name { get; set; }

        

        public Department(string code, string name)
        {
            Code = code;
            Name = name;
 
        }
        public void AddSyudent( Student student)
        {
            Students.Add(student);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public string GetBasicInformation()
        {
            

            return $"Code: {Code}, Name: {Name}, Total Student: {Students.Count} Total Course: {Courses.Count}";
        }

        public List<Course> courses()
        {
            return Courses;
        }

        
    }
}
