using System;
using System.Collections.Generic;

namespace _0_ExtraPractise
{
    class Program
    {
        //1.Declare a delegate
        // 2.Set a target method
        //3.Invoke a delegate
        public delegate int CalculatorHandler(int fN, int sN);
        static void Main(string[] args)
        {
            #region Topic-1
            //Person person1 = new Person() { FirstName = "Mubasshir", LasttName = "Raihan" };

            //var result = person1.GetFullName();
            //Console.WriteLine(result);

            //Person person3 = person1;


            //person3.FirstName = "Md";

            //var result2=  person3.GetFullName();
            //var result3 = person1.GetFullName();


            //Console.WriteLine(result2);
            //Console.WriteLine(result3);

            /* Item item1 = new Item() { Id = 11, Name = "Muba" };
            Item item2 = new Item() { Id = 12, Name = "Muba2" };
            Item item3 = new Item() { Id = 13, Name = "Muba3" };
            Item item4 = new Item() { Id = 14, Name = "Muba4" };


            List<Item> itemList = new List<Item>();


            itemList.Add(new Item() { Id = 1, Name = "Raihan" });
            itemList.Add(new Item() { Id = 2, Name = "Raihan2" });
            itemList.Add(new Item() { Id = 3, Name = "Raihan3" });

            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);


            foreach (Item i in itemList)
            {
                Console.WriteLine($"Id: {i.Id}, NameL: {i.Name}");
            }


            Console.WriteLine("--------------------------For Loop");

            int[] numbers = new int[10];

            for (
                int i = 1; i < 10; i++)
            {
                numbers[i - 1] = i;
            }

            for (int i = 0; i < 10; i++)
            {
                int aNumber = numbers[i];
                if (aNumber % 2 == 0)
                {
                    Console.WriteLine(aNumber);
                }
            }


            Console.ReadKey(); */
            #endregion

            CalculatorHandler calculatorHandler = Add;
            InvokeDelegate(calculatorHandler, 3, 3);

        }


        public static int Add(int fN, int sN)
        {
            return fN + sN;
        }

        public static void InvokeDelegate(CalculatorHandler calculatorHandler, int fn , int sn)
        {
         int result=   calculatorHandler.Invoke(fn, sn);
            Console.WriteLine(result);
        }

        



    }
}
