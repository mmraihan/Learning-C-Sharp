using System;

namespace DIP_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBusinessLogicLayer logicLayer = new EmployeeBusinessLogicLayer();
          
            
            var details = logicLayer.GetEmployeeDetail(01);


            Console.WriteLine(details);

        }
    }
}
