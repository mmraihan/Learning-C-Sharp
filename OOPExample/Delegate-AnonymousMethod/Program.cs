using System;

namespace Delegate_AnonymousMethod
{
    class Program
    {
        public delegate int CalculatorHandler(int firstNumber, int econdNumber);
        static void Main(string[] args)


        {
            #region Approach-1
            /* CalculatorHandler calculatorHandler = delegate (int firstNum, int secondNum)
             {
                 return firstNum + secondNum;
             }; */
            #endregion


            #region Approach-2
            //CalculatorHandler calculatorHandler = (int firstNum, int secondNum) => firstNum + secondNum;

            //----------Lamda Statement------------------

            //CalculatorHandler calculatorHandler = (x,y) => { return x + y; };    // 2 Parameters
            //CalculatorHandler calculatorHandler = x => { return x; };    // 1 Parameters

            //--------Lamda Expression------------------
            CalculatorHandler calculatorHandler = (x, y) => x + y; 
            #endregion


            var result = calculatorHandler(10, 2);
          Console.WriteLine($"Result by Anonymous Method= {result}");
         
        }

        static int Add (int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

       
    }
}
