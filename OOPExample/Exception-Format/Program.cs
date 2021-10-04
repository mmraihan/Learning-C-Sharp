using System;

namespace Exception_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();

            try
            {
                int num = int.Parse(number);
                Console.WriteLine("Number is " + num);
            }
            catch ( FormatException ex)
            {

                Console.WriteLine("You cant put strig");
                Console.WriteLine(ex.Message);
            }

        
           
            Console.ReadKey();
        }
    }
}
