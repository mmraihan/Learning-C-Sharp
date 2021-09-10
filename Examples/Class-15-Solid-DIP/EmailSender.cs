using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15_Solid_DIP
{
    class EmailSender : IHtmlEmailProvider
    {
        public void SendHtmlEmail(string subject, string body, string receiver, EmailTypes emailtype)
        {
            Console.WriteLine("Sending Email to: " + receiver);
        }

        public void SendHtmlEmail(string subject, string body, List<string> receiver, EmailTypes emailtype)
        {

        }

        public void SendHtmlEmail(string subject, string body, string receiver)
        {
            SendHtmlEmail(subject, body, receiver, EmailTypes.Html); 
        }
    }



    public enum EmailTypes
    {
        Html,
        Text,
        HtmlWithAttachMent6

    }
}
