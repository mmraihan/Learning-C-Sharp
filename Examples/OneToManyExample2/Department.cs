using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyExample2
{
    class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();

        public string GetDepartmentInfo()
        {
            string info = $"Code: {Code}, Name: {Name} \n";
            foreach (var item in Courses)
            {
                info = info + item.GetInfo();
            }
            return info;
        }
        
    }
}
