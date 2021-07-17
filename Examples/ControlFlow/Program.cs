using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {


            var Season = Esason.Autumn;
            switch (Season)
            {
                case Esason.Spring:
               
                case Esason.Summer:
                    Console.WriteLine("We have got promotion");
                    break;
                
                default:
                    Console.WriteLine("Dont");
                    break;
            }
        } 
         
        
    }
}
