using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_SOLID_5_DIP_Solution
{
    class EmployeeBusineesLogicLayer //Both class Including DataAccesFactory classes depend on abstraction.
    {
        IEmployeeDataAccess _employeeDataAccess;

        public EmployeeBusineesLogicLayer()
        {
            _employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails2(int id)
        {
            return _employeeDataAccess.GetEmployeeDeatils(id);
        }
    }
}
