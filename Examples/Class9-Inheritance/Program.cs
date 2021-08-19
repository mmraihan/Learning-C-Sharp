using CommonCode;
using System;

namespace Class9_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Raihan", "Ctg", DateTime.Now);
            var result = student.GenerateId();
            Console.WriteLine(student.Name);
            Console.WriteLine(result);


            Teacher teacher = new Teacher();
            teacher.GenerateId();


            Course course = new Course(); // Class library reference add
            var x =  course.Fees = 22;
           
            Console.WriteLine(x);

        }
    }
}
