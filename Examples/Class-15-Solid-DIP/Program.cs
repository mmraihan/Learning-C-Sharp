using System;

namespace Class_15_Solid_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Membership membership = new Membership(new EmailSender());
            membership.CreateAccount("raihan","Ta");
        }
    }
}
