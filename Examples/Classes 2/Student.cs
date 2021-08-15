using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    public class Student
    {
 
        private double cgpa;
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

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
  
        public Student() //Empty Constructor
        {
            Name = string.Empty;
            Cgpa = 0;
            Address = string.Empty;
            DateOfBirth = DateTime.MinValue;

        }

        public Student(string name, string address, DateTime dateOfBirth) //Parameterized Constructor
        {
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
        }



        //////////////////////////////////// Method Overloading///////////////////////////////////////
        public void UpdateDetails(string name)
        {
            Name = name;
            Console.WriteLine(Name);
        }

        public void UpdateDetails(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public void UpdateDetails(string name, string address)
        {
            Name = name;
            Address = address;
        }

        ~Student() //Finalizer/ Destructor
        {

        }

    }
}
