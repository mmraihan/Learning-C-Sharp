using System;

namespace Exception_IndexOutOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];

            try
            {
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 32;
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }

            }
           

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array's range is exceeded....");
                Console.WriteLine(ex.Message);             
            }
          

          
            Console.ReadKey();
                
        }
    }
}
