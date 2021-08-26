using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Generic
{
   public class Student <T>
    {
        public string Name { get; set; }

        public T Success { get; set; }


        
    }
}
