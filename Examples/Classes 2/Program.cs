using System;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class 7

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

            #endregion

            #region Class 8, Topic :1
            ////////////////////////// Constructor ///////////////////////////////////

            Console.WriteLine(".....................Constructor' Value................");
            Student student3 = new Student("Mubasshir", "Ctg", DateTime.Today);
            student.Name = "Raihan"; /// Field no Update
            Console.WriteLine(student3.Name);
            Console.WriteLine(student3.Address);
            Console.WriteLine(student3.Cgpa);
            Console.WriteLine(student3.DateOfBirth);

            ///////////// //Method OverLoading///////////////////////////
            ///
            Console.WriteLine("--------------- Method OverLoading------------------");

            Student student4 = new Student("Raihan4", "Ctg4", DateTime.Now);
            Console.WriteLine(student4.Name);
            student4.UpdateDetails("Mehod Raihan"); //Note Method Update 
            Console.WriteLine(student4.Name);




            ///////////// // Constructor Chaining///////////////////////////
            Console.WriteLine("---------------Constructor Chaining-------------------");

            ChainingConstructor chainingConstructor = new ChainingConstructor();

            #endregion

            #region Class 8 Topic: 2
            /////////////////////////////////////////// Static/////////////////////////////////
            Console.WriteLine("---------------------Static Method------------------------------------");

            var circleArea = AreaCalculator.GetCircleArea(2.2);
            Console.WriteLine("Circle Area: "+ circleArea);

            var rectangleArea = AreaCalculator.GetRectangleArea(10, 20);
            Console.WriteLine($"Rectangle Area: {rectangleArea}");


            /////////////////////////////////////////// NonStatic/////////////////////////////////
            Console.WriteLine("---------------------Non Static Method/ Normal Class------------------------------------");

            Circle circle = new Circle();
            circle.Radius = 10;
            var result =circle.GetArea();
            Console.WriteLine($"Non Static Method: {result}");



            #endregion 


        }
    }
}
