using System;

namespace Class_12_ParamiterModifier
{
    class Program
    {
        static void Main(string[] args)
        {


            var result = sum("Mridul", 12, 3, 4);
            Console.WriteLine(result.GetName());
            foreach (var item in result.GetAllNums())
            {
                Console.WriteLine(item);
            }
            
        }

        public static Store sum(string name, params int [] nums)
        {

            Store store = new Store();
            store.name = name;
            store.SetAllNumbers(nums);
            return store;
           
        }

    }
}
