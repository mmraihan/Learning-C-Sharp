using System;

namespace StringAndCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Method
            string address = "Mirpur, Dhaka,Bangladesh.";

            Console.WriteLine("Contains k: "+ address.Contains('k'));

            Console.WriteLine(address.ToLower());
            Console.WriteLine(address.ToUpper());

            Console.WriteLine(address.StartsWith('d'));
            Console.WriteLine("End With SH: "+ address.EndsWith("SH", StringComparison.OrdinalIgnoreCase));

            int commaIndex = address.IndexOf(',');
            commaIndex = address.IndexOf(',', 7);
            Console.WriteLine("Comma Index: " + commaIndex);

            int indexOfAny = address.IndexOfAny(new char[] { ',', '.', ';' });
            int indexOfAny2 = address.IndexOfAny(new char[] { ',', '.', ';' }, 7,10);

            Console.WriteLine($"IndexOfAny: {indexOfAny}, IndexOfAny 2: {indexOfAny2} ");

            int pos = 0;
            while (pos>=0)
            {
                pos= address.IndexOfAny(new char[] { ',', '.', ';' }, pos+1);
                if (pos>=0)            
                Console.WriteLine(pos);
            }


             address=address.Insert(7, "--");

            Console.WriteLine(address);

            address = address.PadRight(50, '*');
            Console.WriteLine(address);

            address = address.Remove(2, 10);
            Console.WriteLine(address);

            address = "Mirpur, Dhaka";
            address = address.Replace('M', 'm');
            Console.WriteLine(address);
           
            string[] parts= address.Split(',');

            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            var trimedPart1=parts[1].Trim();
            Console.WriteLine(trimedPart1);


            address = "***** Mirpur2,Dhaka2";
            address= address.Trim('*', ' '); 

            Console.WriteLine(address);

            char[] letters = address.ToCharArray();

            var text = string.Empty;
            Console.WriteLine(text);
            text=string.Concat("Hello");
            Console.WriteLine(text);

           bool text2= string.IsNullOrEmpty(text);
            Console.WriteLine(text2);

            bool text3=string.IsNullOrWhiteSpace(text);
            Console.WriteLine(text3);

            Console.WriteLine(string.Join('q', parts));

            Console.WriteLine(char.ToUpper('c'));



            #endregion

            #region Character Methods










            #endregion
        }



    }
}
