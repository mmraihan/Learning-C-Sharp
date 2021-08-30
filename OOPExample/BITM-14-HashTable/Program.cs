using System;
using System.Collections;
using System.Collections.Generic;

namespace BITM_14_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Raihan", 32);
            hashtable.Add("Raihan2", 33);
            hashtable.Add("Raihan3", 34);
            hashtable["Raihan2"] = 100;


            double salary = Convert.ToDouble(hashtable["Raihan"]);
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key);
            //}
        }
    }
}
