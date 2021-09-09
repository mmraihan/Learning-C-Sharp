using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_SOLID_2_OCP
{
    class Circle : IShape
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double CalclateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
