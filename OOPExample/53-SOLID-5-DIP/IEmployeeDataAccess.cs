using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_SOLID_5_DIP
{
    interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }
}
