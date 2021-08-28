using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssoReltionship
{
    class Department
    {
        public string ShortName { get; set; }
        public string FullNAme { get; set; }

        public List<Student> Students { get; set; }


        public Department()
        {
            Students = new List<Student>();
        }
    }
}
