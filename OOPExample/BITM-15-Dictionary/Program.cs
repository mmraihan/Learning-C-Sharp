using System;
using System.Collections.Generic;

namespace BITM_15_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, double > myInfo = new Dictionary<string, double>();
            myInfo.Add("Raihan", 1);
            myInfo.Add("Raihan2", 2);
            myInfo.Add("Raihan3", 3);
            double myId = myInfo["Raihan"];


            Console.WriteLine(myInfo.ContainsValue(4));

            //foreach (var item in myInfo)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (KeyValuePair <string, double> aPair in myInfo)
            //{
            //    Console.WriteLine(aPair.Key+ " " +aPair.Value);
            //}

            
            // myInfo.TryGetValue("Raihan", out str);
            //Console.WriteLine(str);



            
        }
    }
}
