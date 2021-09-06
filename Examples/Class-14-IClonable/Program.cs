using System;

namespace Class_14_IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            ShoppingCart cart2 = cart; //Only reference copied

            ShoppingCart cart3 = (ShoppingCart)cart.Clone(); // New object value copied
        }
    }
}
 