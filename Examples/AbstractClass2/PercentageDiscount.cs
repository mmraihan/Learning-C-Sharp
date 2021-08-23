using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    class PercentageDiscount : Discount
    {
        public override int AmountAfterDiscount(int totalAmount)
        {
           return (int) (totalAmount - ((totalAmount * DiscountAmount) / 100));
        }
    }
}
