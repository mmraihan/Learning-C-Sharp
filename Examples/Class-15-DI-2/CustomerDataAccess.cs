using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_15_DI_2
{
    class CustomerDataAccess : ICustomerDataAccess
    {

        public CustomerDataAccess()
        {

        }
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
}
