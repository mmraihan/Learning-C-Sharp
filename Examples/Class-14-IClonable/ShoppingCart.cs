using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_IClonable
{
    class ShoppingCart : ICloneable
    {
        public double TotalAmount { get; set; }
        public int ItemCount { get; set; }

        public object Clone()
        {

            ShoppingCart newItem = new ShoppingCart();
            newItem.ItemCount = ItemCount;
            newItem.TotalAmount = TotalAmount;
            return newItem;
        }
    }
}
