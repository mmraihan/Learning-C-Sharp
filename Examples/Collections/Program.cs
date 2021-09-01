using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList maals = new ArrayList();
            maals.Add("Tanjib");
            maals.Add(23);
            maals.Add(4.5);

            foreach (var item in maals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------------------");
            List<int> students = new List<int>();
            students.Add(12);
            students.Add(12);
            students.Add(12);
            students.Add(12);

            foreach (var i in students)
            {
                Console.WriteLine(i);
            }

        }
    }
}
