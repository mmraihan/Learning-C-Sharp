using System;

namespace _27_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            Course course = new Course("c", "c++", "c#");
            Course course2 = new Course("Network", "Math", "Math2");
            ;
            

            Department department = new Department("112", "c#");
            department.AddSyudent(student);
            department.AddSyudent(student2);
            department.AddSyudent(student2);
            department.AddCourse(course);
            department.AddCourse(course2);
            foreach (var item in department.courses())
            {
                Console.WriteLine(item.Name);
            }
           

          
            


           var result =department.GetBasicInformation();
            Console.WriteLine(result);

           
        }
    }
}
