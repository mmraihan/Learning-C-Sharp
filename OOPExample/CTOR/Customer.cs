using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTOR
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders;

        public Customer()
        {
           Orders = new List<Order>();
        }
        public Customer(int id) :this()
        {
            Id = id;
        }
        public Customer(int id, string name) :this(id)
        {
            
            Name = name;
        }
    }
}
