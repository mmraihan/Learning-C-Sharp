using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_19_LINQ_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id=1,Name="Raihan", CategoryId=1},
                new Student(){Id=2,Name="Raihan2", CategoryId=1},
                new Student(){Id=3,Name="Raihan3", CategoryId=2},
                new Student(){Id=4,Name="Raihan4", CategoryId=2},
                new Student(){Id=5,Name="Raihan5", CategoryId=3},
            };

            var catagories = new List<Category>()
            {
                new Category(){Id=1, Name="Monitor"},
                new Category(){Id=2, Name="Discipline"},
                new Category(){Id=3, Name="Nothing"},
            };

            #region Method Syntax

            var methodSyntax = catagories.GroupJoin(students, cat => cat.Id, std => std.CategoryId,
                (cat, std) => new { cat, std }
                );

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.cat.Name + "==>");

                foreach (var c in item.std)
                {
                    Console.WriteLine(c.Name);
                }
            }

            #endregion


        }
    }
}
