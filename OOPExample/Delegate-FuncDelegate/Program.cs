using System;

namespace Delegate_FuncDelegate
{ 
    class Program
    {
        //Func Must be declared with Return Type.

        //public delegate TResult Func<in T, out TResult>(T param); //With Declaration
        static void Main(string[] args)
        {
            #region Without Lamda Method
            /* Func<int, int, int> CalculatorHandler = Add;
             int result = CalculatorHandler(3, 3);
             Console.WriteLine("Func-Dlegate: " + result);
            */
            #endregion

            #region  With Anonymous Method 

            Func<int, int,int> CalculatorHandler2 = (int num1, int num2) => num1 + num2;
            int result=CalculatorHandler2(5, 5);
            Console.WriteLine(result);

            #endregion

             #region  Anonymous Method with only Return Type

            Func<int> Handler= ()=>2;
            //CW ?????
           
            
           
            #endregion

            Console.ReadKey();
        }

       /* static int Add(int num, int num2)
        {
            return num + num2;
        }
       */
    }
}
