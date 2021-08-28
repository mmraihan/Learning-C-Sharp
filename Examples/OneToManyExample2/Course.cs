using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyExample2
{
    class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }

        public string GetInfo()
        {
            return $"Code: {Code}, Title: {Title}, Credit: { Credit}";
        }
    }
}
