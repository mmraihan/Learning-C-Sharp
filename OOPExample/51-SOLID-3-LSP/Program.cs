using System;
using static _51_SOLID_3_LSP.Employee;

namespace _51_SOLID_3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");
            Employee empMike = new TemporaryEmployee(2, "Mike");
        }
    }
}
