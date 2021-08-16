using System;

namespace AlternativeByAI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------Constructor Call------------");
            Teacher teacher = new Teacher("Raihan from CTOR", "Male", 0145);
            teacher.displayInformation();


            Console.WriteLine("--------------- Method Calll---------------");
            Teacher teacher1 = new Teacher();
            teacher1.setInformation("Raihan", "Male", 01676);
            teacher1.displayInformation();
        }
    }
}
