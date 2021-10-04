using System;

namespace Exception_NullReference
{
    class Program
    {
        static void Main(string[] args)
        {
            string name =null;

            try
            {
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Name can not be zero");
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
