using System;
using System.IO;
using System.Text;

namespace Class_18_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //realtive path vs absolute path
             var fileText = File.ReadAllText("herText.txt"); //Relative path= Current Directory = where exe file is located

             var fileAbsolute = File.ReadAllText("C:\\Users\\Raihan\\Desktop\\New folder (2)\\myMtext2.txt"); //absolute path.

             var fileAgainst = File.ReadAllText("TestFile\\test2.txt"); // Basckslashh=\\ 
             var fileAgainst2 = File.ReadAllText("TestFile/test2.txt"); // or forward slash=/ only 1
             Console.WriteLine(fileAgainst2);


             var content = "I'm inserting some data for working with files";
             File.WriteAllText("TestFile/newFile.txt", content); //Write file

             var isExit=File.Exists("TestFile/newFile.txt");
             Console.WriteLine(isExit);


             string path = "TestFile/newFile2.txt";


             using (FileStream fs = File.Create(path)) 
             {
                 byte[] info = Encoding.Unicode.GetBytes("This is some text in the file");
                 fs.Write(info, 0, info.Length);
                 fs.Flush();
             }
            */

            ////////////////Directory//////////////////

            var files = Directory.GetFiles("TestFile"); //Getting file from Current Folder
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

           // Directory.CreateDirectory("TestNewDicrect"); //Crete new folder


            if (Directory.Exists("TestNewDicrect")) //Delete folder
            {
                Directory.Delete("TestNewDicrect");
            }
        }
    }
}
