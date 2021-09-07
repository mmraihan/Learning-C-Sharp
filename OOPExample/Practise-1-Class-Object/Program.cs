using System;

namespace Practise_1_Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            a = 3;
            int b = a;
            Console.WriteLine(b);
           

            

            Person person = new Person("Md.", "Raihan", 23);
            person.FirstName = "Md2";
            person.GetPersonInformation();

            person.GetPersonInformation("Md3", "Raihan2", 23);
            person.GetPersonInformation();

            Console.ReadKey();
        }
    }
}
