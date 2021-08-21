using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass0ciation_Relationship_2
{
    class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }

       public string GetInfo()
        {
            return $"Course Code: {Code},Title: {Title}  Credit: {Credit}";
        }
    }
}
