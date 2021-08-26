using System;

namespace _46_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
           var student = new Student<int>() { Name = "Raihan", Success=1 };

           var student2 = new Student<string>() { Name = "Raihan2", Success = "Passed" };

           var student3 = new Student<bool>() { Name = "Raihan3", Success = true };

           Print(student);
           Print(student2);
           Print(student3);
           
            Console.ReadKey();
        }
        public static void Print<T>(Student<T> stt)
        {
            Console.WriteLine($"Name: {stt.Name}, Success= {stt.Success} ");
        }



    }
}
