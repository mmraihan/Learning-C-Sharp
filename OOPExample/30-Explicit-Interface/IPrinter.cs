using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Explicit_Interface
{
    interface Iprinter
    {
        void Pint();

        void SetIpAddress(string ip);

        string GetBasicInformation();
    }
}
