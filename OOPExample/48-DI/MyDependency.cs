using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_DI
{
   //public class MyDependency
   // {
   //     public MyDependency()
   //     {

   //     }
   //     public void WriteMessage(string message)
   //     {
   //         Console.WriteLine($"MyDependency.WriteMessage called.Message: {message}");
   //     }

   // }


    public interface IMyDependency
    {
        void writeMessage(string message);
    }


    public class Mydependency : IMyDependency
    {
        public Mydependency()
        {

        }
        public void writeMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called.Message: {message}");
        }
    }


    public class MyDependency2 : IMyDependency
    {
        public MyDependency2()
        {

        }
        public void writeMessage(string message)
        {
            Console.WriteLine($"MyDependency2.WriteMessage called.Message: {message}");
        }
    }
}
