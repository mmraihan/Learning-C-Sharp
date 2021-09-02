using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNE_1_IEnumarabe
{
   public class School 
    {
        List<Student> students = new List<Student>();
      public void Add(Student s)
        {
            students.Add(s);
        }

       
    }
}
