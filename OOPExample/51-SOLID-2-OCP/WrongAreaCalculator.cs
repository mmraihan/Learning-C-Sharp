using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_SOLID_2_OCP
{
    class WrongAreaCalculator
    {
        public static double CalculateArea(string option, int [] sizes)
        {

            if (option=="rectangle")
            {
                return sizes[0] * sizes[1];
            }

            else if (option == "circle")
            {
                return Math.PI * sizes[0] * sizes[1];
            }
            else if (option == "triangle") //Additional Requirements
            {
                
            }
            else if (option == "pentagon") //Additional Requirements
            {
                
            }

            return 0;


        }
    }
}
