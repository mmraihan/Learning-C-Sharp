using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Extension
    {
        public static string GetInfo(this Person person)
        {
            var info = $"Id: {person.Id}, Name: {person.Name}, Address: {person.Address}";
            return info;
        }

        public static void GetBasicInfo(this string info)
        {
            Console.WriteLine("I am from extension Method");
        }

    }
}
