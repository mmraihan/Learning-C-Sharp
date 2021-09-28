using System;

namespace Delegate_ActionDelegate
{
    
    class Program
    {
        //Action Delegate has no return type.

        static void Main(string[] args)
        {
            #region Without Lamda Method
           /*
            Action<int, int> CalculatorHandler = Add;
            CalculatorHandler(5,6);
           */
            #endregion

            #region  With Anonymous Method (Lambda expression)

            Action<int, int> CalculatorHandler2 = (int num1, int num2) => Console.WriteLine(num1-num2);
            CalculatorHandler2(20, 10);
            #endregion

            #region  Anonymous Method with only One Parameter

            Action<int> Handler = (int x) => Console.WriteLine(x);
            Handler(3);

            #endregion
        }

        /*
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        */
    }

   
}
