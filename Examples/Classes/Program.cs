using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); /// Student()= Constructor , Special kind of method
            student.Name = "Raihan";
            student.DateOfBirth = new DateTime(1995, 5, 10);
            student.Cgpa = 3.02;
            student.Address = "Bangladesh";
            student.Cgpa = 3.08;
            Console.WriteLine("Raihan's CGPA: " + student.Cgpa);
            Console.WriteLine("Raihan's Date of Birth" + student.DateOfBirth);

            Console.WriteLine("-------------------------------------------------");

            Student student2 = new Student();
            student2.Name = "Riya";
            student2.Cgpa = 3.57;
            student2.Cgpa = 3.82;
            student2.Cgpa += 0.1;
            Console.WriteLine("Riya's CGPA: " + student2.Cgpa);

        }
    }
}