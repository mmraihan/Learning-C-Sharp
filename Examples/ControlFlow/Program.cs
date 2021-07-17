using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////if else
            //int hour = 10;

            //if (hour>0 && hour<12)
            //{
            //    Console.WriteLine("Its Morning");
            //}
            //else if (hour>12 && hour<18)
            //{
            //    Console.WriteLine("AfterNoon");
            //}
            //else
            //{
            //    Console.WriteLine("Evening");
            //}


            ///////////////////////////////////////////////////////////// if else
            bool isCustomer = true;

            //float price;
            //if (isCustomer)
            //    price = 19.00f;
            //else
            //    price = 222.2f;

            //Console.WriteLine(price);

            float price = (isCustomer) ? 19.0f : 26.77f;

            Console.WriteLine(price);
                
                
         
        }
    }
}
