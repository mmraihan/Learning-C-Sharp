using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine((int)Days.Sunday);

        }

        public enum Days
        {
            Sunday=1,
            Monday=2,
            Tuesday=3
        }

        public static void UpdatePaymentStatus(Days days)
        {
            if (days==Days.Sunday)
            {
                Console.WriteLine("Sunday");
            }
           else if (days == Days.Monday)
            {
                
            }

            else
            {
               
            }
        }

    }
}
