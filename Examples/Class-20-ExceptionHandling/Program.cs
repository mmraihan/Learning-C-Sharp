using System;
using System.IO;
using System.Text;

namespace Class_20_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = null;
            var result=CalculateVowel(sentence);
            Console.WriteLine(result);

            WriteFile("kkk");
        }



        static int CalculateVowel(string text)
        {
            try
            {
                var count = 0;
                foreach (var c in text)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') ;
                    count++;
                }
                return count;
            }
           
            catch (NullReferenceException nex)
            {
                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was a problem-" + ex.Message);
                return 0;
            }
            finally
            {

            }
        }
        static void WriteFile(string text)
        {
            FileStream stream =null;
            try
            {
                string path = "";
                FileInfo fileInfo = new FileInfo(path);
                stream = fileInfo.Open(FileMode.Append);
                stream.Write(ASCIIEncoding.ASCII.GetBytes(text));
            }
            catch (FileNotFoundException foe)
            {
                Console.WriteLine("Could not find the file" + foe.Message);

            }

            catch (FileLoadException foe)
            {
                Console.WriteLine("Could not Load the file" + foe.Message);

            }

            catch(Exception ex)
            {
                Console.WriteLine("There is an error "+ ex.Message );
            }

            finally
            {
                stream?.Close();
            }
        }
    }
}
