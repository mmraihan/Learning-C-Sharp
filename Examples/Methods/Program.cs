using System;

namespace Methods
{
    public class Program
    {
        // Method with Argument and return Value
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1>num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        // Method with No Argument and No return Value

        void PrintMessage()
        {
            Console.WriteLine("Hello world");
        }

        // Method with  Argument and No return Value

        void Sum(int num1, int num2)
        {
            var result = num1 + num2;
            Console.WriteLine("Result of Sum: " +result);
        }

        // Method with No Argument But return Value

         int Factorial()
        {
            int num = 5;
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                //fact = fact *i;
                fact *= i;
            }
            return fact;
        }

        static void Main(string[] args)
        {

            Program maxValue = new Program();
            var result= maxValue.FindMax(10, 20);
            
            Console.WriteLine("Max Value: " + result);


            maxValue.PrintMessage();

            maxValue.Sum(20, 30);

           var factorialResult= maxValue.Factorial();
            Console.WriteLine("Factorial is: "+factorialResult);

        
         }
    }
}
