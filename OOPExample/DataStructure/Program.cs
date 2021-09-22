using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] basicSalary = new int[3];
            basicSalary[0] = 10;
            basicSalary[1] = 20;
            basicSalary[2] = 30;

         

            int[] allowance = new int[3];
            allowance[0] = 2;
            allowance[1] = 2;
            allowance[2] = 2;


            int[] totalSalary = new int[3];

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(totalSalary[i]= basicSalary[i] + allowance[i]);
            }
        }
    }
}
