using System;


namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi");

            //int i = Console.Read();
            //Console.WriteLine(i);

            //string s = Console.ReadLine();
            //Console.WriteLine(s);

            string line = Console.ReadLine();

            string[] lineParts= line.Split(',');
            for (int i = 0; i < lineParts.Length; i++)
            {
                Console.Write(lineParts[i]);
            }




            
           // Console.ReadKey();
        }
    }
}
