using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Break
{
    class EmployeeBusinessLogicLayer
    {
        EmployeeDataAccess _employeeDataAccess;

        public EmployeeBusinessLogicLayer()
        {
            _employeeDataAccess = DataAccessFactory.EmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetail(int id)
        {
           var result = _employeeDataAccess.GetEmployeeDetails(id);
            return result;

        }
  
    }
}
