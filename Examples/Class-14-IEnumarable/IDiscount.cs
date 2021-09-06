using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_IEnumarable
{
    interface IDiscount
    {
        double CalcullateAmount(double original);

        public double GetAmount()
        {
            return 0;
        }
    }
}
