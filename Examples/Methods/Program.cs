using System;

namespace Methods
{
    public class Program
    {

        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1>num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
       

        static void Main(string[] args)
        {

            Program maxValue = new Program();
            var result= maxValue.FindMax(10, 20);
            
            Console.WriteLine("Max Value: " + result);

        }
    }
}
