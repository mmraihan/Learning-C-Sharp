using System;

namespace Class_12_ParamiterModifierRefInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Sum( 1, 2);
            Console.WriteLine(result);

            int x = 5;
            int y = 10;
            TestingParameterNodifiers(ref x,ref y);
        }

        public static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return sum;  
        }

        static void TestingParameterNodifiers(ref int a, ref int b) //Parameter can update
        {
            a = 20;
            b = 30;
        }
        static void TestingParameterNodifiers2(in int a, ref int b) // Cant change parameter
        {
            //a = 20;
            //b = 30; Error
        }

        static void TestingParameterNodifiers3(out int a, ref int b) // Value must be set
        {
            a = 50;
            b = 40;
        }

    }
}
