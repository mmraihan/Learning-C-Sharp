
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_SOLID_5_DIP_Solution
{
    class EmployeeDataAccess : IEmployeeDataAccess // Detaiols depend on Abstraction
    {
        public Employee GetEmployeeDeatils(int id)
        {
            Employee employee = new Employee()
            {
                Id = 02,
                NAme = "Raihan2",
                Department = "Engineering",
                Salary = 10000,
            };
            return employee;
        }
    }
}
