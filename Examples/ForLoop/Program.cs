using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] nameList;
            //nameList = new string[6];
            //nameList[0] = "A";
            //nameList[1] = "A";
            //nameList[2] = "A";
            //nameList[3] = "A";
            //nameList[4] = "A";

            //Console.WriteLine(nameList[1]);

            int sum = Add(1, 3);
            Console.WriteLine(sum);

        }

        static int Add(int firstNum, int second)
        {
            var resul = firstNum + second;
            return resul;
        }


        public static int RemoveDuplicates(int[] nums)
        {

        }
    }
}
