using System;

namespace OneToManyAssoReltionship
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Raihan";
            student1.RegNo = "111";
            student1.Email = "r@g.com";


            Student student2 = new Student();
            student2.Name = "Raihan3";
            student2.RegNo = "112";
            student2.Email = "r2@g.com";

            Student student3 = new Student();
            student3.Name = "Raihan3";
            student3.RegNo = "113";
            student3.Email = "r3@g.com";


            Department department = new Department();
            department.ShortName = "CSE";
            department.FullNAme = "Com Sci Engi";

            department.Students.Add(student1);
            department.Students.Add(student2);
            department.Students.Add(student3);

            foreach (var item in department.Students)
            {
                Console.WriteLine($"Name: {item.Name}, Reg No: {item.RegNo}, Email: {item.Email}");
            }
            Console.ReadKey();


        }
    }
}
