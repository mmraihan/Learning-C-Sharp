using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITM_18_ValueRefType
{
    class Person
    {
        public string FitrstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }


        public string GetFullName()
        {
            string FullName = $"{FitrstName} {MiddleName} {LastName}";
            return FullName;
        }
    }
}
