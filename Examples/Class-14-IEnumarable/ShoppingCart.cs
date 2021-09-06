using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_IEnumarable
{
    class ShoppingCart : IEnumerable
    {

        ///Data/Products/Item
        ///

        public double TotalAmount { get; set; }
        public int ItemCount { get; set; }


        public void AddItem(object item)
        {

        }
        public void RemoveItem(object item)
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
}
