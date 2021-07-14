using System;

namespace ExtraPractise
{
    class Program
    {
        static void Main(string[] args)
        {

            // Demo String

            var firstName = "MD.";
            var lastName = "Raihan";

            var fulllName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };

            var formattedName = string.Join(",", names);
            Console.WriteLine(formattedName);
        }
    }
}
