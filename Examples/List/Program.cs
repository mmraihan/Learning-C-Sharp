using System;

using System.Collections.Generic;

namespace List
{



    class Program
    {
        static void Main(string[] args)
        {

            int num = 123;
            int result = 0;
            int rem;
            while (num!=0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num / 10;

            }

            Console.WriteLine(result);

        }
    }

    
}
