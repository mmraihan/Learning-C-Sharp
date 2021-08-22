using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CtorBaseSubclass
{
    class SavingAccount : BankAccount
    {
        public SavingAccount(string accountNo, string customerName, double interestAmount) : base(accountNo, customerName)
        {
            
            InterestAmount = interestAmount;
          
        }
        public double InterestAmount { get; set; }

        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                return base.Withdraw(amount);
            }
            return "Insufficient Balane";

        }
    }
}
