﻿using System;
using System.Collections.Generic;

namespace ExtraPractise
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr2d = new int[3, 2]
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };

            Console.WriteLine(arr2d[0,0]); 
            Console.WriteLine(arr2d[0,1]); 
            Console.WriteLine(arr2d[1,0]); 
            Console.WriteLine(arr2d[1,1]); 
            Console.WriteLine(arr2d[2,0]); 
            Console.WriteLine(arr2d[2,1]); 

        }
    }
}
