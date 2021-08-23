using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class FixedAmountDiscount : Discount
    {
        public override int AmountAfterDiscount(int totalDiscount)
        {
            return totalDiscount - DiscountAmount;
        }

        public override int GetDiscountedAmount()
        {
            return base.GetDiscountedAmount();
        }
    }
}
