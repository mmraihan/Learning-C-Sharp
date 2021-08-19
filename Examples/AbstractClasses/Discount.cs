using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
  public abstract class Discount
    {
        public int DiscountAmount { get; set; }

        public abstract int AmountAfterDiscount(int totalAmount);

        public virtual int GetAmountDiscount()
        {
            return 0; 
        }
        

         
    }
}
