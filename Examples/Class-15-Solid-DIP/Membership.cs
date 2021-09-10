using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15_Solid_DIP
{
    class Membership
    {
        private IHtmlEmailProvider _htmlEmailProvider;

        public Membership(IHtmlEmailProvider htmlEmailProvider)
        {
            _htmlEmailProvider = htmlEmailProvider;
        }

        public void CreateAccount(string username, string password)
        {
            _htmlEmailProvider.SendHtmlEmail("Hello", "Welcome", "raihan@gmail.com");
        }
    }
}
