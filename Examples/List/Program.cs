using System;
using System.Collections;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };

           // arList.Remove(null); //Removes first occurance of null
            //arList.RemoveAt(4); //Removes element at index 4
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            
            for (int i = 0; i < arList.Count; i++)
            {
                Console.WriteLine(arList[i]);
            }
            
        }
    }
}
