using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Id = 101;
            person.Name = "Raihan";
            person.Address = "Ctg";
            var info=person.GetInfo();
            Console.WriteLine(info);
          


            string firstName = "Muba";
            firstName.GetBasicInfo();
            
            Console.ReadKey();
        }
    }
}
