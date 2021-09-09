using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_SOLID_5_DIP
{
   public  class EmployeeBusinessLogicLayer //High Level Modules, Details Getting Actual Data
    {
        EmployeeDataAccess _employeeDataAccess;
        public EmployeeBusinessLogicLayer()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id)
        {
            return _employeeDataAccess.GetEmployeeDetails(01);
        }
    }
}
