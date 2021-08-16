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

            Console.WriteLine("--------------- Method Calll with Return Value---------------");
            ReturningValue returningValue = new ReturningValue();
            var result =returningValue.square(5); //5 Return Kore abar 25 store hobe result e
            Console.WriteLine(result);


            Console.WriteLine("--------------- Static Variable--------------");

            StaticVariable staticVariable = new StaticVariable("Raiha From Static", 112);
            staticVariable.disPlayInfo();

            StaticVariable staticVariable2 = new StaticVariable("Raiha2 From Static", 113);
            staticVariable2.disPlayInfo();


        }
    }
}
