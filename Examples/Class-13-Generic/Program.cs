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

            Tree<string> tree = new Tree<string>();
            tree.AddNode("abc");
            tree.AddNode("abc2");
            tree.AddNode("abc3");

            tree.DeleteNode("abc2");
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
   
    class Tree<T> where T: class
    {
        private T[] nodes;
        private int index;
        public void AddNode(T node)
        {
            nodes[index++] = node;
        }

        public void DeleteNode(T node)
        {
            nodes[--index] = default(T);
        }

        public static class Printer<X>
        {
            public static void Print<T>(T item) where T : struct
            {
                T x = default(T);
                X a = default(X);
                Console.WriteLine(item.ToString());
            }
        }

    }

}
