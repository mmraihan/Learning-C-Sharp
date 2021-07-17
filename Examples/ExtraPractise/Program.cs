using System;
using System.Collections.Generic;

namespace ExtraPractise
{
    class Program
    {
        static void Main(string[] args)

        {
            var studentNames = new[] { "Tanvir", "Mridhul", "Zakaria" };

            string[][] jaggedArray = new string[3][];

            //size of string array
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            //Initialize Data
            jaggedArray[0][0] = "BSc";
            jaggedArray[0][1] = "MSc";
            jaggedArray[0][2] = "PHD";

            jaggedArray[1][0] = "Bsc";

            jaggedArray[2][0] = "BSc";
            jaggedArray[2][1] = "MSc";

            
            // Accessing Data

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine(studentNames[i]);
                Console.WriteLine("-------------");

                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }
          


        }
    }
}
