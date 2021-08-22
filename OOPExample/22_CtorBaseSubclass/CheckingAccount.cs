using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_CtorBaseSubclass
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNo, string customerName, double serviceCharge) : base (accountNo, customerName)
        {
            
            ServiceCharge = serviceCharge;
        }
        public double ServiceCharge { get; set; }


    }
}
