using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeByAI
{
  public  class Teacher
    {
        public string  Name { get; set; }
        public string  Gender { get; set; }
        public int Phone { get; set; }

        public Teacher()
        {

        }
        public Teacher(string name, string gender, int phone) //// These parameters receive value from Main Method
        {
            Name = name;
            Gender = gender;
            Phone = phone;
        }

        public void setInformation(string name, string gender, int phone) // These parameters receive value from Main Method
        {
            Name = name;
            Gender = gender;
            Phone = phone;
        }

        public void displayInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gebder: " + Gender);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("\n");

        }
    }
}
