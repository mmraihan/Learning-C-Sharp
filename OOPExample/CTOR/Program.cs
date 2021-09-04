using System;
using System.Collections.Generic;

namespace CTOR
{
    class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer(1,"John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Order order = new Order();
           
            customer.Orders.Add(order);

           
        }
    }
}
