using System;

namespace Exception_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string a = null;
                //Console.WriteLine(a.Length);
                ///////////////////////---- 2------
                //int[] arr = new int[2];
                //arr[0] = 11;
                //arr[1] = 18;
                //arr[2] = 12;


            }
            catch (Exception ex) //General  (parent class )
            {             
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
