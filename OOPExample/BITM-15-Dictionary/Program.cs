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

            foreach (KeyValuePair <string, double> aPair in myInfo)
            {
                Console.WriteLine(aPair.Key+ " " +aPair.Value);
            }
            
        }
    }
}
