using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_SOLID_5_DIP
{
    public class EmployeeDataAccess //Low Level Modules
    {
        public Employee GetEmployeeDetails(int id)
        {

            Employee emp = new Employee()
            {
                Id = 01,
                NAme = "Raihan",
                Department = "Engineering",
                Salary = 450000

             };
            return emp;
            
        }

    }
}
