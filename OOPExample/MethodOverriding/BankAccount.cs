using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class BankAccount
    {
        public string AccounNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }



        public string Deposit(double amount)
        {
            Balance = Balance + amount;
            return "Deposited";
        }

        public virtual  string Withdraw(double amount)
        {
           
               Balance = Balance - amount;
               return "Withdrawn";
          
            

         }
    }
}
