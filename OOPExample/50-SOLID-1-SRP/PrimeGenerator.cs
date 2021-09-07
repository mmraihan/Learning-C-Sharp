using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_SOLID_1_SRP
{
    class PrimeGenerator
    {
        public static List<int> Generate(int n)
        {
            var prmes = new List<int>();

            for (int i = 2; i <= n; i++)
            {

                bool flag = false;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                     
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                    prmes.Add(i);
  
            }
            return prmes;

        }
    }
}
