using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Break
{
    class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee employee = new Employee()
            {
                Id = 01,
                Name = "Raihan",
                Department = "Engineering"
            };

            return employee;
        }
    }
}
