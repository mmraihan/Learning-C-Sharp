using System;

namespace _50_SOLID_1_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //WrongPrimeGenerator.Generat();

            IInputOutputProcessor io = new ConsoleInputOutput();
            var n =io.TakeInpu();
            var primes = PrimeGenerator.Generate(n);
            foreach (var prime in primes)
            {

                io.WriteOutput($"{prime} is a Prime Number");
            }


        }
}
}
