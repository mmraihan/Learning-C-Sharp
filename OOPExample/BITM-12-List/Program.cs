using System;
using System.Collections.Generic;

namespace BITM_12_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Mridul");
            myList.Add("Mridul2");
            myList.Add("Mridul3");
            myList.Add("Mridul4");

            Console.WriteLine(myList.Count);

            List<string> newList = new List<string>();
            newList.Add("A");
            newList.Add("B");
            newList.Add("C");
            newList.Add("D");
            myList.AddRange(newList);

            foreach (var item in myList)
            {
                Console.WriteLine($"Total {item}");
            }


            Console.WriteLine(myList.Count);


        }
    }
}
