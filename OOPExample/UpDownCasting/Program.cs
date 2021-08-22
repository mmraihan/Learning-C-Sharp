using System;

namespace UpDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sv1 = new SavingAccount();
            sv1.InterestAmount = 500;
            sv1.AccounNo = "SV-001";
            sv1.CustomerName = "Md. Raihan";
            sv1.Deposit(1000);
            sv1.Withdraw(600);
            double balance = sv1.Balance;
            Console.WriteLine(balance);


            CheckingAccount chk1 = new CheckingAccount();
            chk1.ServiceCharge = 1000;
            chk1.AccounNo = "CH-001";
            chk1.CustomerName = "Alayna";
            chk1.Deposit(2000);
            chk1.Withdraw(300);
            var balance2 = chk1.Balance;
            Console.WriteLine(balance2);


            BankAccount b1 = new CheckingAccount();

            BankAccount b2 = chk1; // Up Casting

     

            SavingAccount sb2 = (SavingAccount)b1;
            var inamount= sb2.InterestAmount;
        
        }
    }
}
