using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class GiftCard : IPurchasable
    {
        public string Name { get ; set ; }
        public double Price { get; set; }
        public string ImageFileName { get; set; }
        public string EmailAddress { get; set; }
    }
}
