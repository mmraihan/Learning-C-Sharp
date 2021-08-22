using System;

namespace _22_CtorBaseSubclass
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();




            Console.WriteLine("----------------------");
            SavingAccount sv1 = new SavingAccount("112", "Raihan From Saving", 500);
            //sv1.InterestAmount = 500;
            //sv1.AccounNo = "SV-001";
            //sv1.CustomerName = "Md. Raihan";
            //sv1.Deposit(510);
            //sv1.Withdraw(6000);
            //double balance = sv1.Balance;
            //Console.WriteLine("Saving Account: " + sv1.Withdraw(6000));



            Console.WriteLine("----------------------");
            CheckingAccount chk1 = new CheckingAccount("113", "Raihan from Checking", 1);
            //chk1.ServiceCharge = 510;
            //chk1.AccounNo = "CH-001";
            //chk1.CustomerName = "Mr Messi";
            //var result = chk1.Deposit(5010);
            //var balance2 = chk1.Withdraw(6000);

            //Console.WriteLine("Checking Account: " + balance2);
        }
    }
}
