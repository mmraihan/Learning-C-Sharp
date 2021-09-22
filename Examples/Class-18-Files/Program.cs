using System;
using System.IO;

namespace Class_18_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //realtive path vs absolute path
            var fileText = File.ReadAllText("herText.txt"); //Relative path= Current Directory = where exe file is located

            var fileAbsolute = File.ReadAllText("C:\\Users\\Raihan\\Desktop\\New folder (2)\\myMtext2.txt"); //absolute path.

            var fileAgainst = File.ReadAllText("TestFile\\test2.txt"); // Basckslashh=\\ 
            var fileAgainst2 = File.ReadAllText("TestFile/test2.txt"); // or foeward slash=/ only 1
            Console.WriteLine(fileAgainst2);




            

        }
    }
}
