using System;

namespace _31_ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student() { Id = 1, Name = "Raihan", Address = "CTG" };
            Console.WriteLine(student.Address);
        }
    }
}
