using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeByAI
{
    class StaticVariable
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public static string UniName = "EDU"; // Static is related to class not in object


        public StaticVariable(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void disPlayInfo()
        {
            Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"University Name: {UniName}");
        }
    }

    
}
