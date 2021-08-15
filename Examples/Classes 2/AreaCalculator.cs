using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
   public static  class AreaCalculator
    {
        public static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius; 
        }

        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

    }
}
