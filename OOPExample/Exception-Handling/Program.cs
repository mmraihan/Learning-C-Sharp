using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;  //Throw object
                Console.WriteLine("Division Result is: " + result);
            }
            catch (DivideByZeroException ex) // asiigned object in this reference
            {

                Console.WriteLine("You can not divide number by zero...");
                Console.WriteLine(ex.Message);
            }

              
               

                Console.WriteLine("Remaining statement 2");
                Console.WriteLine("Remaining statement 3");
                Console.ReadLine();   
        }
    }
}
