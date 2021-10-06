using System;

namespace Exception_WaysOfException
{

    //Our throw and default catch
    //Our throw and our catch
    class Program
    {
        static void Main(string[] args)
        {
            #region Our throw and default catch
            /* Console.WriteLine("Enter your age");
             int age = int.Parse(Console.ReadLine());
             if (age > 18)
             {
                 Console.WriteLine("You are elegible to vote....");
             }
             else
             {
                 throw new Exception("You are not eligible to vote....."); //Our throw and default catch
             }
             Console.ReadKey();
             */
            #endregion


            #region Our throw and our catch

            try
            {
                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                if (age > 18)
                {
                    Console.WriteLine("You are elegible to vote....");
                }
                else
                {
                    throw new Exception("You are not eligible to vote....."); 
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
       
            Console.ReadKey();
            #endregion


        }

    }
}
