using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class FixedAmountDiscount : Discount
    {
        public override int AmountAfterDiscount(int totalAmount)
        {
            return totalAmount - DiscountAmount;
        }

       
    }
}
