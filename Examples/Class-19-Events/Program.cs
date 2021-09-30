using System;

namespace Class_19_Events
{
    class Program
    {
        delegate void Receive(string receipent, string message); //Step-1
        static event Receive Subscribe; //Step-2

        //---------------------------------- Action Event--------------------
        //static event Action<string, string> Subscribe;

        static void Main(string[] args)
        {
            Subscribe += SMSSubscriber ; //Step-3 Adding method on Event

            Subscribe += EmailSubsCriber;
         
            Subscribe += MMSSubscribe;

            // Subscribe -= SMSSubscriber; (Remove SMS Subscriber)

            Subscribe.Invoke("Raihan", "Hello! From Ctg"); //Step-3 Invoke Events

            Console.ReadKey();
        }

        private static void MMSSubscribe(string receipent, string message)
        {
            Console.WriteLine($"Sendin MMS to: {receipent}, Message: {message}");
        }

        private static void EmailSubsCriber(string receipent, string message)
        {
            Console.WriteLine($"Sendin Email to: {receipent}, Message: {message}");
        }

        private static void SMSSubscriber(string receipent, string message)
        {
            Console.WriteLine($"Sending SMS to: {receipent}, Message: {message}");
        }
    }
}
