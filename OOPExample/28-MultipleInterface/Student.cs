using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_MultipleInterface
{
    public class Student : IInformation,IIprinter
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Email { get; set; }

        public string GetBasicInformation()
        {
            return $"Reg No: {RegNo}, Name:{Name}, Roll No: {Roll}, Email: {Email} ";
        }

        public void Pint()
        {
            throw new NotImplementedException();
        }

        public void SetIpAddress(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
