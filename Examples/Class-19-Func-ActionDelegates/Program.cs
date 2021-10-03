using System;

namespace Class_19_Func_ActionDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = 10;

            #region Func


            Func<int, int, int> c = Formula; // first are parameters, Last one is return type. Which defines method signarure.
            ApplyFormula(c, x, y);

            #endregion


            #region Action
            Action<int, int> p = Formula2;
            ApplyFormula2(p, x, y);

            #endregion




        }

        #region Func  return Type
        static void ApplyFormula(Func<int, int, int> m, int a, int b)
        {
            Console.WriteLine(m(a, b));
        }

        static int Formula(int a, int b)
        {
            return a + b;
        }
        #endregion


        #region Action No Return Type


        static void ApplyFormula2(Action<int, int> r, int a, int b) ////////??????????????????
        {
            //Console.WriteLine;
        }

        static void Formula2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        #endregion
        
    }
}
