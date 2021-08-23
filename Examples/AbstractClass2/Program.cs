using System;

namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = GetDiscount();           
            discount.DiscountAmount = 50;
            int amount = discount.AmountAfterDiscount(500);
            Console.WriteLine(amount);
            // Discount d = new FixedAmountDiscount();

        }

        public static Discount GetDiscount()
        {
           string userInput=  Console.ReadLine();
            if (userInput == "Fixed")
            {
                //Discount d2 = new FixedAmountDiscount();
                //return d2;


                return new FixedAmountDiscount(); // ???
            }
            else
            {
                return new PercentageDiscount();
            }

        }

    }
}
