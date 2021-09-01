using System;

namespace Class_13_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Point <int, string>p1 = new Point<int, string>();
            p1.X = 10;
            p1.Y = "Hi";
            var result2 =p1.Sum(10, "20");
            Console.WriteLine(result2);


           string result = p1.X + p1.Y;
            Console.WriteLine(result);

        }
    }


    class Point<T, D>
    {
        public T X;
        public D Y;


        public string Sum(T X, D Y)
        {
            return X.ToString() + Y.ToString();
        }
    }

}
