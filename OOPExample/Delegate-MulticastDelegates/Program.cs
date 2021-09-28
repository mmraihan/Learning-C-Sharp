using System;

namespace Delegate_MulticastDelegates
{
    public delegate void PrintHandler(string name);
    class Program
    {
        static void Main(string[] args)
        {
            #region Approach-1
       
            PrintHandler printHandler5 = Hello;
            printHandler5 += GoodBye; //Set 2 target method ,Multiple method
            #endregion

            #region Approach2
            PrintHandler printHandler = Hello;
            PrintHandler printHandler1 = GoodBye;
            PrintHandler printHandler2 = printHandler + printHandler1;

            printHandler2 -= printHandler1; //Remove

            printHandler2.Invoke("Mubasshir");
            #endregion



            Console.ReadKey();
        }

        static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void GoodBye(string name)
        {
            Console.WriteLine("GoodBye "+ name);
        }
    }
}
