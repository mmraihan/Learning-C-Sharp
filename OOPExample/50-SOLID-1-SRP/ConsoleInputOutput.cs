using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_SOLID_1_SRP
{
    class ConsoleInputOutput : IInputOutputProcessor
    {
        public int TakeInpu()
        {
            return int.Parse(Console.ReadLine());
        }

        public void WriteOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
