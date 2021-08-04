using System;

using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    if (i % 2 == 0)

            //        Console.WriteLine(i);

            //}

            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0) ;

            //    Console.WriteLine(i);
            //    i++;

            //}

            while (true)
            {
                Console.Write("Type your Name: ");
               var input= Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

              
                break;
            }




        }
    }
}
