using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_Inheritance
{
    class Student : Person
    {

        private double cgpa;
      
        public readonly string studentId = "";
       

        public double Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                if (value >= 0)
                {
                    cgpa = value;
                }

            }

        }

        /////////////////////////Cnstructor Overoading//////////////////////////////////////////

        public Student() : this(string.Empty, "N/A", DateTime.MinValue) //Empty Constructor
        {
            
        }

        public Student(string name, string address, DateTime dateOfBirth) : base("SD")//Parameterized Constructor
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }



        
    }
}
