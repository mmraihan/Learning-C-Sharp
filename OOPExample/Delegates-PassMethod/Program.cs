using System;

namespace Delegates_PassMethod
{
    class Program
    {

        public delegate int CalculatorHandler(int fNumber, int sNumber);

        static void Main(string[] args)
        {
            //1.Declare a delegate
            // 2.Set a target method
            //3.Invoke a delegate

            CalculatorHandler calculatorHandler = Add;
            InvokeDelegate(calculatorHandler, 5, 5);

            CalculatorHandler calculatorHandler1 = Sub;
            InvokeDelegate(calculatorHandler1, 3, 2);
            

    
            
           
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }


        public static void InvokeDelegate(CalculatorHandler calculatorHandler, int fn, int sn)
            
        {
            int result = calculatorHandler.Invoke(fn, sn);
            Console.WriteLine("Output is "+ result);
        }



        

    }
}
