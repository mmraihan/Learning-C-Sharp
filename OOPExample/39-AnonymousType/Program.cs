using System;

namespace _39_AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            var student2 = new Student() { Id = 2 };

            var student = new
            {
                Id = 1,
                Name = "Raihan",
                RegNo = "129",
                Address = "Ctg",
                Email = "r@example.com",
            };
            Console.WriteLine(student2.Id);
            Console.WriteLine(student.Address);
            Console.ReadKey();
        }
    }
}
