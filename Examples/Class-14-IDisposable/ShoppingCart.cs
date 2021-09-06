using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_IDisposable
{
    class ShoppingCart : ICloneable , IDisposable, IEnumerable
    {
        public double TotalAmount { get; set; }
        public int ItemCount { get; set; }
        private ArrayList items = new ArrayList();
        
        

        public object Clone()
        {

            ShoppingCart newItem = new ShoppingCart();
            newItem.ItemCount = ItemCount;
            newItem.TotalAmount = TotalAmount;
            return newItem;
        }

        internal void AddItem(string v)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            items.Clear();
        }

        
    }
}
