using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            cart.AddItem(new CartItem(new Product { Name = "Ram", Price = 4800, ImageFileName = "8gbTranscend.jpg" }));
            cart.AddItem(new CartItem(new Product { Name = "SSD", Price = 6400, ImageFileName = "256gbTranscend.jpg" }));
            cart.AddItem(new CartItem(new GiftCard { Name = "150 Coupon", Price = 1500, ImageFileName = "coupon1599.jpg" }));

            cart["Ram"].UpdateQuantity(5);
            

            foreach (var item in cart.Items)
            {
                Console.WriteLine($"Product Name: {item.Item.Name}, Quantity: {item.Quantity}");
            }

            Console.WriteLine($"Total Price = {cart.Total}");
       
        }
    }
}
