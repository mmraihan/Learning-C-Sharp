using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass0ciation_Relationship_2
{
    class Department
    {
        public Department()
        {
            Courses = new List<Course>();
        }


        public string Code { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; } //= new List<Course>();

        public string GetDepInfo()
        {
            string info = $"Department Code: {Code}; Department Name: {Name} \n";

            foreach (var item in Courses)
            {
                info += item.GetInfo()+"\n";
            }
            return info;
        }

        
    }
}
