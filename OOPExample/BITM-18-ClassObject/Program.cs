using System;

namespace BITM_18_ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FitrstName = "Md";
            person1.MiddleName = "Mubasshir";
            person1.LastName = "Raihan";

            var person2Info= person1.GetFullName();

            Person person2 = new Person();
            person2.FitrstName = "Kazi";
            person2.MiddleName = "Bijoy";
            person2.LastName = "Uddin";

           //var person2Info= person2.GetReverseName();
            Console.WriteLine(person2Info);



        }
    }
}
