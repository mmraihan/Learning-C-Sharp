using System;
using System.Collections.Generic;

namespace _30_Explicit_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetBasicInformation();

            Department department = new Department();
            

         

            IInformation information = student;
            information.GetBasicInformation();
            information = department;

            

            Console.ReadLine();
        }
    }
}
