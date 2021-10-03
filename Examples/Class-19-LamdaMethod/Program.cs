using System;

namespace Class_19_LamdaMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(50, 60));  

            Sum("Hello from Lamda Method");
        }


        #region Normal Method (Without Lamda)
        /*
       public static int Sum(int a, int b)
       {
           return a + b;
       }
       */
        #endregion

        #region Lamda Method 
        public static int Sum(int a, int b) => a + b; // Single statement only

        

        #endregion


        #region Lamda Method Without Return Type
        public static void Sum(string meaasage) => Console.WriteLine(meaasage); 

        #endregion

    }
}
