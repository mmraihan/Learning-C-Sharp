using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Abstract
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNo, string customerName, double serviceCharge) : base(accountNo, customerName)
        {

            ServiceCharge = serviceCharge;
        }
        public double ServiceCharge { get; set; }

        public override void Transfer(string from, string to, double amount)
        {
           // tODO
        }
    }
}
