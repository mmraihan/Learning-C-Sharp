using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Interface_2
{
  public class Department : IInformation
    {
        public string Code { get; set; }
        public string Name { get; set; }

        List<Student> students = new List<Student>();

        List<Course> courses = new List<Course>();



        public Department()
        {
            students = new List<Student>();
            courses = new List<Course>();
        }

        public string GetBasicInformation()
        {
            return $"Code: {Code} Name: {Name} Total Student: {students.Count}";
        }
    }
}
