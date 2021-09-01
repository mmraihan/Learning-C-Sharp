using System;
using System.Collections.Generic;

namespace ObjectAndCollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Md.";
            person1.LastName = "Raihan";

            Person person2 = new Person("Md.-2", "Raihan 2");

            Person person3 = new Person
            { 
              FirstName = "Md.-3", 
              LastName = "Raihan 3"
            };

            var names = new List<string>()
            {
               "Habib", "Habib2", "Habib3"
                 
            };
            names.Add("Habib");
            names.Add("Habib 2");
            names.Add("Habib 3");


            var persons = new List<Person>()
            {
                person1,
                person2,
                person3,
                new Person(){FirstName="Md. -4", LastName="Raihan 4"}
                
            };

            foreach (var item in persons)
            {
                Console.WriteLine(item.GetFullName());
            }

            Console.WriteLine("----------------------------Todays Code-----------------------");

            Person person4 = persons[3];

            

           
            Person human = new Person();
            human.FirstName = "Mr";
            human.LastName = "Tanjib";

          
           

            Person human2;


            human2 = human;
            human = null;



            Console.WriteLine(human.GetFullName());
            Console.WriteLine(human2.GetFullName()); 
           
            




        }
    }
}
