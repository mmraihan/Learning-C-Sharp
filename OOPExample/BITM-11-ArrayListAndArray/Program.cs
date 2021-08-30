using System;
using System.Collections;

namespace BITM_11_ArrayListAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(123);
            myArrayList.Add("Raihan");
            myArrayList.Add('A');

           var result= myArrayList.Count;
            Console.WriteLine(myArrayList.Contains(123));

            Console.WriteLine(result);

            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            string[] cars2 = new string[3];

            string[] cars3 = new string[] { "a", "b" };

            var cars4 = new []{ "a", "a" };


        }
    }
}
