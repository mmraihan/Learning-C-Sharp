using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var fullName = person.GetFullName();
            Console.WriteLine(fullName);
        }
    }
}
