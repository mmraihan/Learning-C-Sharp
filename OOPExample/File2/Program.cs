using System;
using System.IO;

namespace File2
{
    class Program
    {
        static void Main(string[] args)
        {
            // if @ then put pnly 2 backward (\) slash
            //if  @ does not contain  then put pnly 1 backward (\) slash
            
            var filePath = @"C:\Development\Dev Skill\C# Practise\C-Sharp-Learning-\OOPExample\File2\bin\Debug\net5.0\AdditionalFile\Welcome.txt";

            var fileText = File.ReadAllText(filePath);



            Console.WriteLine(Directory.GetParent("Welcome.txt"));
          
            
          


            

            //Console.WriteLine(fileText);
            Console.ReadKey();
        }
        
    }
}
