using System;

namespace Methods
{
    public class Calculator
    {

        int num1 = 10;
        int num2 = 20;
        int result;

        void Add()
        {
            result = num1 + num2;
            DisplayResult();
        }

        void Subtract()
        {
            result = num1 - num2;
            DisplayResult();
        }
        void DisplayResult()
        {
            Console.WriteLine(result);
        }


        static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.Add();
            obj.Subtract();
        

        }
    }
}
