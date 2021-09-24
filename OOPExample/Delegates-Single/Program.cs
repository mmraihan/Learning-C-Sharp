using System;

namespace Delegates_Single
{
    class Program
    {

        public delegate int CalculatorHandler(int fNumber, int sNumber);

        static void Main(string[] args)
        {

             //1.Declare a delegate
             // 2.Set a target method
             //3.Invoke a delegate

            //Invoke only one method

            Student student = new Student();

            CalculatorHandler calculatorHandler = Add; //Point
            // int result= calculatorHandler.Invoke(10, 40); //Invoke
            int result = calculatorHandler(2, 2);
            Console.WriteLine(result);
        }

        static int Add (int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
       
    }
}
