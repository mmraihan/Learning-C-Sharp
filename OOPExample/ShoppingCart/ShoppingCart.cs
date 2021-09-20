using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        private List<CartItem> _items;

       public IReadOnlyCollection<CartItem> Items 
        {
         get

            {
                return new ReadOnlyCollection<CartItem>(_items);
            }
        }

        public CartItem this[string name]
        {
            get 
            {
                return _items.Where(x => x.Item.Name == name).FirstOrDefault();
            }
           
        }
        public ShoppingCart()
        {
            _items = new List<CartItem>();
        }

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }

        public void ClearCart()
        {
            _items.Clear();
        }

        public void RemoveItem(CartItem item)
        {
            _items.Remove(item);
        }


        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in _items)
                {
                    total = total + item.Item.Price * item.Quantity;
                }
                return total;
            }
            
        }

    }
}
