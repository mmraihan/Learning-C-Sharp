using System;

namespace Class_12_NullableAndAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
             
            int? x = null;
            if (x==null)
            {
                Console.WriteLine("X is Null");
            }
            x = 8;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }

           Program.Print();
            
            
            
        }
        static void Print()
        {
            dynamic item = new { Name = "Raihan", Age = 24 };
            Console.WriteLine(item.Name);
        }
    }
}
