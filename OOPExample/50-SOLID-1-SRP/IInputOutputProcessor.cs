using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_SOLID_1_SRP
{
    interface IInputOutputProcessor
    {
        void WriteOutput(string message);
        int TakeInpu();
    }
}
