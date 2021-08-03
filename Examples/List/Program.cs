using System;

using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            Console.WriteLine(i++); 
            

           int b = 3;
          
            Console.WriteLine(++b);

            Console.WriteLine(5*2);

            Console.WriteLine(10%4);


            int x = 5;
            x += 2;
            Console.WriteLine(x);

            x -= 3;
            Console.WriteLine(x);

            x *= 2;
            Console.WriteLine(x);

            x /= 5;
                Console.WriteLine(x);
            x %= 2;
            Console.WriteLine(x);


            uint t = 0b_00000_11111;
            uint c= ~t;
            Console.WriteLine(Convert.ToString(c, toBase:2));

            



        }
    }
}
