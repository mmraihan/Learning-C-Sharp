using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    class EmployeeDataAccess : IGetEmployeeDetails
    {
        public Employee GetEmployeeInformation(int id)
        {
            Employee employee = new Employee()
            {
                Id = 02,
                Name = "Raihan",
                Department = "SE",
            };
            return employee;

        }
    }
}
