using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    public class Circle
    {
        public string  Name { get; set; }
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
