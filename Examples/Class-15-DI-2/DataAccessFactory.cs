using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15_DI_2
{
    class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessoObj()
        {
            return new CustomerDataAccess();
        }
    }
}
