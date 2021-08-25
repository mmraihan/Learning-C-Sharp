using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11
{
    public class Bottle : IContainer, IColorable, IClosable
    {
        public double Capacity { get; set; }
        public string Color { get; set; }
        private double contentAmount;
        private bool isOpen;

        public void AddContent(double amount)
        {
            contentAmount += amount;

            Console.WriteLine(contentAmount);
        }

        public void Close()
        {
            isOpen = false;
        }

        public void Open()
        {
            isOpen = true;
            Console.WriteLine("Base Bottle");
        }

        public void RemoveContent(double amount)
        {
            contentAmount -= amount;
        }
    }
}
