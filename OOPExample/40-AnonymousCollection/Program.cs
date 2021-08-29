using System;
using System.Linq;

namespace _40_AnonymousCollection
{
    class Program
    { 
        static void Main(string[] args)
        {
            var studentList = new[]
            {
                new{Id=1, Name="Raihan", RegNo="120"},
                new{Id=2, Name="Raihan2", RegNo="121"},
                new{Id=3, Name="Raihan3", RegNo="123"},
                new{Id=3, Name="Aaihan3", RegNo="123"},
                new{Id=3, Name="Aaihan3", RegNo="123"},
            };

            for (int i = 0; i < studentList.Length; i++)
            {
                Console.WriteLine(studentList[i]);
            }

            var searchList = studentList.Where(c => c.Name.StartsWith('A')).ToList();
            var student5 = studentList.FirstOrDefault(c => c.Id == 2);

            foreach (var serach in searchList)
            {
                Console.WriteLine(serach.Name);
            }

            Console.WriteLine(student5);


            foreach (var item in studentList)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
 