using System;

namespace _47_Generic_2
{
    class Program
    {
        static void Main(string[] args)
        {

            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Chittagong");
            cities.AddOrUpdate(1, "Dhaka");
            cities.AddOrUpdate(2, "Makka");

            int[] nums = { 1, 2, 3, 4, 5 };

            updateArray(nums);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }



        }


        public static void updateArray(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i];
            }
        }
    }
}
