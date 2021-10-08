using System;

namespace Delegates_TT
{
    class Program
    {
        public delegate void MyDelegate(string msg); // declare a delegate

        public delegate T add<T>(T param1, T param2);

       
        static void Main(string[] args)
        {



            #region Topic 1
            //Set Target methdod

            // MyDelegate del = new MyDelegate(MethodA);

            //MyDelegate del = MethodA;

            //Invoke/Call


            //del("Hello Tanjib ");
            #endregion

            #region Topic 2- Passing Delegate as a Parameter

            /*
                        MyDelegate myDelegate = ClassA.MethodA;
                        myDelegate("Hello Raihan");

                        myDelegate = ClassB.MethodB;
                        myDelegate("Hello Class Raihan");


                        myDelegate = (string msg) => Console.WriteLine("Called Lamda Expression: " + msg);
                        myDelegate("Hello From Lamda");

            */


            #endregion

            #region Topic-2 Passing Delegate as a Parameter


            MyDelegate delegate2 = ClassA.MethodA;
            InvokeDelegate(delegate2);


            #endregion

            #region Topic-3 Generic Delegate

            add<int> sum = Sum;
            Console.WriteLine(sum(10,20));


            add<string> con = Contact;

            var result=con("MM", "R");
            Console.WriteLine(result);

            #endregion

        }

        static void InvokeDelegate(MyDelegate del)
        {
            del("Hello Raihan , I am from passing deleagate");
        }

        //Target Method
        //static void MethodA (string msg)
        // {
        //     Console.WriteLine(msg);
        // }




        #region Target Method for generic


        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Contact(string str1, string str2)
        {
            return str1 + str2;
        }

        #endregion

    }

    class ClassA
    {
       public static void MethodA(string msg)
        {
            Console.WriteLine("Called CalssA.MethodA() with parameter: " + msg);
        }
    }

   public class ClassB
    {
       public static void MethodB(string msg)
        {
            Console.WriteLine("Called CalssB.MethodB() with parameter: " + msg);
        }
    }






}
