using System;

namespace Exception_Multiple
{
    class Program
    {
        // All Catch Blocks Must be ordered from most specific to most general
        //At a time only one exception is occurred as well as executed also.

        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

                string at = null;
                Console.WriteLine(at.Length);

                int[] arr = new int[2];
                arr[0] = 11;
                arr[1] = 18;
                arr[2] = 12;

            }
             
            catch (DivideByZeroException ex)
            {
               
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)  //Parent class sould be placed in last.
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
