using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); /// Student()= Constructor , Special kind of method
            student.name = "Raihan";
            student.dateOfBirth = new DateTime(1995, 5, 10);
            student.cgpa = 3.02;
            student.address = "Bangladesh";

            var cgpaResult= student.UpdateCgpa(3.08);

            Console.WriteLine("Raihan's CGPA: " + cgpaResult);
            Console.WriteLine(student.dateOfBirth);



            Student student2 = new Student();
            student2.name = "Riya";
            student2.cgpa = 3.57;
            student2.UpdateCgpa(3.92);
            Console.WriteLine("Riya's CGPA: " +student2.cgpa);
            
        }
    }
}
