using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_SOLID_5_DIP_Solution
{
    interface IEmployeeDataAccess
    {
        Employee GetEmployeeDeatils(int id);
    }
}
