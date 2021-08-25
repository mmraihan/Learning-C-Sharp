using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Structure
{
  public  struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public double CalculateDistance (Point anotherPoint)
        {
            throw new NotImplementedException();
        }
        
    }

}
