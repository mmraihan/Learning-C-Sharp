using System;
using System.Collections.Generic;

namespace BITM_19_LamdaExpresion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Raihan", "Hasan", "Riad" };

            string found=names.Find(name => name.StartsWith("Ra"));
            Console.WriteLine(found);

            List<double> values = new List<double>() { 4, 6, 8, 1, 6, 9, 33, 44, 55, 66, 7 };

            double aNumber = values.Find(number => number >= 10);
            Console.WriteLine(aNumber);

            double a = 10;
            List<Book> books = new List<Book>()

            {

                new Book{Name="C-Sharp", Author="Raihan", Published=new DateTime(2010,1,1)},
                new Book{Name="C-Sharp2", Author="Raihan2", Published=new DateTime(2010,1,1)},
                new Book{Name="C-Sharp3", Author="Raihan3", Published=new DateTime(2010,1,1)},
            };

            var selectedBooks = books.FindAll(b => b.Published > (new DateTime(2001, 2, 2)));

            foreach (var item in selectedBooks)
            {
                Console.WriteLine(item.Author);
            }



            
        
           
        }
    }
}
