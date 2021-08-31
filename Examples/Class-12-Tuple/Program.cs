using System;

namespace Class_12_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            //Students students= new Students();
            //var info= students.ReturnStudentInfo();
            //Console.WriteLine(info);

            Tuple<int, string, double> obj = new Tuple<int, string, double> ( 121, "Raihan", 30000 ); // Declar with object

            var emp2 = Tuple.Create(121, "Raihan2",6.2); //Decale with statci


            var emp = GetEmployeeDetaisl();
            Console.WriteLine($"EmpID{emp.Item1}, EmpName{emp.Item2}, EmpSalary{emp.Item3}");


           

        }

        public static Tuple<int,string,double> GetEmployeeDetaisl()
        {
            return new Tuple<int, string, double>(1, "Raihan3", 34);
        }

     

        }
    }

    public class Students 
    {
        //public string Name { get; set; }
        //public int Age { get; set; }

        //public string Grade { get; set; }


        //public (string, int, string) ReturnStudentInfo()
        //{
        //    return ("Raihan", 24, "A");
        //}
    }
