using System;

namespace _0_ExtraPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { FirstName = "Mubasshir", LasttName = "Raihan" };
            
            var result = person1.GetFullName();
            Console.WriteLine(result);

            Person person3 = person1;


            person3.FirstName = "Md";

            var result2=  person3.GetFullName();
            var result3 = person1.GetFullName();

            
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadKey();
        }
    }
}
