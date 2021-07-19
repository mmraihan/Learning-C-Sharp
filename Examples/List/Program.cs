using System;

using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1)
            ;
            numbers.AddRange(new int[3] { 5, 6, 7 }); // Tips: Ienumarable  add list or array

        


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==1)
                {
                    numbers.Remove(numbers[i]);
                }                       
            }

            foreach (var item2 in numbers)
                Console.WriteLine(item2);
        }
    }
}
