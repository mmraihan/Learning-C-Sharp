using System;
using System.Collections.Generic;

namespace ExtraPractise
{
    class Program
    {
        static void Main(string[] args)
        {



            var evenNums = new[] { 5,6,1,4,2,3,6,8};

            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Sorted Array");


            Array.Sort(evenNums);

            foreach (var item in evenNums)
            {
                Console.WriteLine(item);
            }

          








        }
    }
}
