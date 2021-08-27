using System;
using System.Text;

namespace Class_12_StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a')
                {
                    
                    Console.WriteLine("a is found");
                }
         
            }

            StringBuilder stringBuilder = new StringBuilder();

            while (true)
            {
                var word = Console.ReadLine();
                if (word == "exit")
                    break;
                else
                {
                    stringBuilder.Append("<h1>").Append(word).Append("</h1>");
                   
                }

                Console.WriteLine(stringBuilder.ToString());
                break;

                
            }

            Console.ReadKey();
           

        }
    }
}
