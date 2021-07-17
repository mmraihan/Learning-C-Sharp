using System;
using System.Collections.Generic;

namespace ExtraPractise
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array2D = new int[4, 3]
            {
                {1,2,3 },
                {3,4,4 },
                {5,6,3 },
                {7,8,5 }
            };

            int a = array2D.GetLength(0);
            int b = array2D.GetLength(1);
            for (int i = 0; i <a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    Console.Write(array2D[i,j]);
                }
            }

        }
    }
}
