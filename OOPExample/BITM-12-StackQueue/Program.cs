using System;
using System.Collections;
using System.Collections.Generic;

namespace BITM_12_StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> myStack = new Stack<String>();
            myStack.Push("Raihan");
            myStack.Push("Raihan2");
            myStack.Push("Raihan3");
            myStack.Push("Raihan4");
            foreach (var item in myStack) 
            {
                Console.WriteLine(item); //LIF0
            }


            Queue<String> myQueue = new Queue<string>();
            myQueue.Enqueue("Q");
            myQueue.Enqueue("Q");
            myQueue.Enqueue("Q");
            myQueue.Enqueue("Q");

            Console.WriteLine(myQueue.Count); //FIFO


                
        }
    }
}
