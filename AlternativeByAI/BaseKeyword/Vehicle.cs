using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    public class Vehicle
    {
        public string Color { get; set; }
        public double Weight { get; set; }


        public Vehicle(string color, double weight )
        {
            Color = color;
            Weight = weight;
        }

        public void Attribute()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Weight: {Weight}");
           
        }
    }
}
