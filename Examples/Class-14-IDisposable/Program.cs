using System;
using System.Collections;

namespace Class_14_IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {

            ShoppingCart cart = new ShoppingCart();

            foreach (var item in cart)
            {

            }

            ShoppingCart cart2 = (ShoppingCart)cart.Clone();
            using ShoppingCart cart3 = new ShoppingCart(); //Dispose call hoe already remove hoe jabe., Memory teke delete hoe jabe
            cart3.AddItem("Product");
            
            
        }
    }
}
