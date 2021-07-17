using System;
using System.Collections.Generic;

namespace ExtraPractise
{
    class Program
    {
        static void Main(string[] args)
        {



            var evenNums = new[] { 2,3,6,8};


            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]); // read values of array elements

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10; //increase the value of each element by 10

            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

       





        }
    }
}
