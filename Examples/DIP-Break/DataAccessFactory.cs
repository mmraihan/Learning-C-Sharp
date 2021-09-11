using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Break
{
    class DataAccessFactory
    {
        public static EmployeeDataAccess EmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
