using System;

namespace _54_SOLID_5_DIP_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
           
            EmployeeBusineesLogicLayer emp1 = new EmployeeBusineesLogicLayer();
            Employee result = emp1.GetEmployeeDetails2(02);
            Console.WriteLine(result);

        }
    }
}
