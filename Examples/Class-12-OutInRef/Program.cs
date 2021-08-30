using System;

namespace Class_12_OutInRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            TestingParameterModifiers(ref x, ref y);
            //Console.WriteLine($"X = {x}, Y = {y}");

            TestingParameterModifiers3(out x, out y);
            Console.WriteLine($"X = {x}, Y = {y}");
        }


        static void TestingParameterModifiers ( ref int a, ref int b)
        {
            a = 20;
            b = 30;
        }
        static void TestingParameterModifiers2(in int a, in int b)
        {
            //a = 33; // In parameter can not be changed
            //b = 44;
        }
        static void TestingParameterModifiers3(out int a, out int b)
        {
            a = 100;
            b = 200; // Mandatory out e value dewa
        }
    }
}
