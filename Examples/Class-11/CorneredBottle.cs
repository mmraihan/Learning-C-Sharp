using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11
{
    class CorneredBottle : Bottle
    {
        public new void Open()
        {
            base.Open(); //////Note
           // Console.WriteLine("From Cornered Bottle");
        }
    }
}
