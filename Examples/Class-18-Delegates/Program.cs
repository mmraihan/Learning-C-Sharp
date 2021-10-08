using System;

namespace Class_18_Delegates
{
    class Program
    {
        delegate int method(int x, int y);
        static void Main(string[] args)
        {

            int x = 2;
            int y = 2;
            method m = Formula;
            //int r = m(x, y);
            ApplyFormula(m, x, y);
        }

        static void ApplyFormula(method c, int a, int b)
        {
            Console.WriteLine(c(a, b));
        }

        static int Formula(int a, int b)
        {
            return a +b;
        }
    }
}
