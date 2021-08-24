using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Explicit_Interface
{
    public class Course : IInformation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }


        public Course(string code, string name, string credit)
        {
            Code = code;
            Name = name;
            Credit = credit;
        }

        public string GetBasicInformation()
        {
            return $"Code: {Code}, Name: {Name}, Credit: {Credit}";
        }
    }
}
