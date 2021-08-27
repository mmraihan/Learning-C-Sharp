using System;

namespace Class_12_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime(2021, 09, 27);
            DateTime now = new DateTime(2021, 09, 27, 18, 57, 00);

            DateTime currentDateTime = DateTime.Now;

            DateTime parseData = DateTime.Parse("8/27/21");

            Console.WriteLine(today);
            Console.WriteLine(now);
            Console.WriteLine(currentDateTime);
            Console.WriteLine(parseData);



            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.DayOfYear);
            var now2 = DateTime.Now;

            var tomorrw2 = now.AddDays(2);
            Console.WriteLine(tomorrw2);
            var tomorrow = now2.AddDays(3);
            Console.WriteLine(tomorrow);

            var yesterday = now2.AddDays(-1);

            Console.WriteLine(now.ToString("M"));

            Console.WriteLine("--------------------------------TimeSPan----------------------------");


            var timeSpan = new TimeSpan(1,2,3);
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

    
        }
    }
}
