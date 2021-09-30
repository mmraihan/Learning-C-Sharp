using System;
using System.Linq;

namespace Class_19_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 42,23, 33, 43, 12, 9,6,4 };

            #region Without LINQ

            int[] filterd = new int[20];
            int count = 0;

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] % 2 == 0)
                {
                    filterd[count++] = ages[i];
                }
            }
            #endregion

            #region With LINQ SQL/Query Syntax

           var data= (from age in ages where age % 2 == 0 select age).ToArray();

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Method Syntax
            var data2 = ages.Where(x => x % 2 == 0).ToArray();

            foreach (var item in data2)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
