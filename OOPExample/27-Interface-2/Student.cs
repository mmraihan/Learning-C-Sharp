using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Interface_2
{
   public class Student : IInformation
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Email { get; set; }

        public string GetBasicInformation()
        {
            return $"Reg No: {RegNo}, Name:{Name}, Roll No: {Roll}, Email: {Email} ";
        }
    }
}
