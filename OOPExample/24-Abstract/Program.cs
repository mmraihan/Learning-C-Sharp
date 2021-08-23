using System;
using System.Collections.Generic;

namespace _24_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount("112", "Raihan From Saving", 500);
            sv1.Deposit(5010);

            

            Console.WriteLine("----------------------");


            CheckingAccount chk1 = new CheckingAccount("113", "Raihan from Checking", 1);
            chk1.Deposit(5010);
            chk1.Transfer("", "", 2);



            BankAccount b2 = sv1;
            b2.Transfer("", "", 2);
           

            Console.ReadKey();
        }
    }
}
