using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_SOLID_1_SRP
{
    public class WrongPrimeGenerator
    {
        public static void Generat()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {

                bool flag = false;
                for (int j = 2; j <=Math.Sqrt(i); j++)
                {
                    if (i%j==0)
                    {
                        Console.WriteLine($"{i} is Not Prime");
                        flag = true;
                        break;
                    }
                }

                if (flag==false)
                {
                    Console.WriteLine($"{i} is Prime"); 
                }
            }

        }

    }
}
