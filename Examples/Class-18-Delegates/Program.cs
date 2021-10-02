using System;

namespace Class_18_Delegates
{
    class Program
    {
        delegate int method(int x, int y);
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            method m = Formula;
            
           //int r = m(2, 2);

            ApplyFormula(m, 3, 2);
        }

        static void ApplyFormula(method m, int a, int b)
        {
            Console.WriteLine(m(a,b));
        }

        static int Formula(int a, int b)
        {
            return a + 10 + b - 5;
        }
    }
}
