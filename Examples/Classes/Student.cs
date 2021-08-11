using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        #region Fild Shoulb Be Private and Property Should be Public : MS recommended

        //public string name;
        //public DateTime dateOfBirth;
        private double cgpa;
        //public string address; /// field
        #endregion 

        public string Name { get; set; }
        public DateTime DateOfBirth  { get; set; }

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
        
    }
}