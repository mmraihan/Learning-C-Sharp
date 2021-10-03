using System;
using System.Linq.Expressions;

namespace Class_19_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> exp = (int a, int b) => a + b; //Assign Lamda method

            Func<int, int, int> f = exp.Compile();
            int result = f(2, 3);
            Console.WriteLine(result);
         
           
        }
    } 
}
