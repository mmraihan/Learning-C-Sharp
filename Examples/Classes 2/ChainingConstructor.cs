using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class ChainingConstructor
    {
        string companyName;
        public ChainingConstructor() : this ("BSRM Company")
        {
            Console.WriteLine("Default Constructor");
        }


        public ChainingConstructor( string compName)
        {
            companyName = compName;
            Console.WriteLine(compName );
        }
    }
}
