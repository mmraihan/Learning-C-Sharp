using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
   public interface IPurchasable
    {
       string Name { get; set; }
       double Price { get; set; }
       string ImageFileName { get; set; }

    }
}
