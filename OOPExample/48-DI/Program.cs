using System;

namespace _48_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consumer obj = new Consumer();
            //obj.ConsumeThings();
            //Console.ReadKey();

            IMyDependency depObj = new Mydependency();
            Consumer obj = new Consumer(depObj);
            obj.ConsumeThings();
        }
    }
}
