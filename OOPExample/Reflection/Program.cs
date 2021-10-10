using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            var studentClassInfo = typeof(Student);

            //string assembleyName = studentClassInfo.Assembly.FullName;
            //Console.WriteLine(assembleyName);

            //var methods = studentClassInfo.GetMethods();

            //foreach (var item in methods)
            //{
            //    Console.WriteLine(item);
            //}


            var properties = studentClassInfo.GetProperties(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Public);
            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
