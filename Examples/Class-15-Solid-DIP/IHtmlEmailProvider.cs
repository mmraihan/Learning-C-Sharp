using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15_Solid_DIP
{
    interface IHtmlEmailProvider
    {
        
        void SendHtmlEmail(string subject, string body, string receiver);
    }
}
