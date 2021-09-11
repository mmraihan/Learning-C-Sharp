using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Solution
{
    interface IGetEmployeeDetails
    {
        public Employee GetEmployeeInformation(int id);
    }
}
