using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssoReltionship
{
    class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public PresentAddress StudentPresentAddress { get; set; }
    }
}
