using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    class EmployeeBusinessLogic_Layer
    {
        IGetEmployeeDetails _getEmployeeDetails;
        public EmployeeBusinessLogic_Layer()
        {
            _getEmployeeDetails = DataAccessFactory.GetDataAccessFactoryObj();
        }

        public Employee GetInfo(int id)
        {
            return _getEmployeeDetails.GetEmployeeInformation(id);
        }
    }
}
