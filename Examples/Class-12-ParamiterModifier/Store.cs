using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_ParamiterModifier
{
    class Store
    {
        int[] numbers;
        public string name;

        public string GetName()
        {
            return name;
        }
        public  void SetAllNumbers(params int[] nums)
        {
            numbers = new int[nums.Length];
            numbers = nums;            
        }

        public int[] GetAllNums()
        {
            return numbers;
        }

    }
}
