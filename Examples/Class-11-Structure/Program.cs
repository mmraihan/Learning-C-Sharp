using System;

namespace Class_11_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 22;
            point.Y = 23;


            Point point2 = point;
            point2.X = 2;
            point2.Y = 3;

            Console.WriteLine($"X: {point2.X} Y:{point2.Y} ");

            ///Structure e Empty CTOR thake
            ///Value type, can't Inherit 
        }
    }
}
