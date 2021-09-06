using System;

namespace Class_14_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Raihan";
            Console.WriteLine(cookie["name"]);

        }
    }
}
