using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
   public class CartItem
    {
        public Product Item { get; private set; }
        public uint Quantity { get; private set; }


        public CartItem(Product item)
        {
            Item = item;
            Quantity = 1;
        }

        public void UpdateQuantity(uint quantity)
        {
            if (quantity==0)
            {
                throw new InvalidOperationException("Quantity can't be zero");
            }

            Quantity = quantity;
        }
    }
}
