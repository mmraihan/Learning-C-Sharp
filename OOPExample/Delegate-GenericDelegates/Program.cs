using System;

namespace Delegate_GenericDelegates
{
    public delegate void PrintHandler<T>(T param); // Single Parameter

    public delegate void PrintHandler2<T, F>(T param, F param2); //Multiple Parameter

    public delegate T PrintHandler3<T, F>(T param, F param2); //Returnt Type T

    class Program
    {
        static void Main(string[] args)
        {
            #region Generic with SingleParameter
            PrintHandler<string> printHandler = Hello;
            printHandler += GoodBye;
            printHandler("Mubasshir");

            PrintHandler<int> printHandler1 = Test;
            printHandler1(2);
            #endregion

            Console.WriteLine("--------------------Multiple Parameter----------------------\n");

            #region Generic with MultipleParameter

            PrintHandler2<string, string> handler2 = Test2;
            handler2("Raihan", "Chittagong");
            #endregion

            Console.WriteLine("-------------------Return Type------------------------\n");
            #region Generic with Return type

            PrintHandler3<string, string> handler3 = Test3;

            var result = handler3("Mahin", "Agrabad");
            Console.WriteLine(result);
            #endregion


            Console.ReadKey();
        }

        static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void GoodBye(string name)
        {
            Console.WriteLine("GoodBye " + name);
        }
        
        static void Test(int number)
        {
            Console.WriteLine(number+number);
        }

        // Multiple Parameter//
        static void Test2(string name, string address)
        {
            Console.WriteLine($"Hello {name}, I am from {address}");
        }


        //Return Type

        static string Test3(string name, string address)
        {
            var result = $"Hi {name}, I am from{address}";
            return result;
        }
    }
}
