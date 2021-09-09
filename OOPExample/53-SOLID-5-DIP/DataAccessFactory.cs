using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_SOLID_5_DIP
{
    class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
