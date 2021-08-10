using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
       public string name;
       public DateTime dateOfBirth;
       public double cgpa;
       public string address;

      public  double UpdateCgpa( double newCgpa)
        {
            cgpa = newCgpa;
            return cgpa;
        }
    }
}
