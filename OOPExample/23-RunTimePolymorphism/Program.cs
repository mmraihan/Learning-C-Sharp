using System;
using System.Collections.Generic;

namespace _23_RunTimePolymorphism
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

            BankAccount b1 = new BankAccount();
            b1.AccounNo = "101";
            b1.CustomerName = "Raihan From Base Class";
            b1.Deposit(10010);

            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(b1);
            accounts.Add(sv1);
            accounts.Add(chk1);
            foreach (var item in accounts)
            {
                
                Console.WriteLine(item.Withdraw(10011));    
            }


            


            Console.ReadKey();
            
        }
    }
}
