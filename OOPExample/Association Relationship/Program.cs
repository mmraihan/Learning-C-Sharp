using System;

namespace Association_Relationship
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.HouseNo = "26";
            address.RoadNo = "2";
            address.Area = "South Khulshi";

            Person person1 = new Person();
            person1.PresentAddress = address;

            string houseNo = person1.PresentAddress.HouseNo;

            Console.WriteLine(houseNo);
            
            person1.FirstName = "Md";
                

        }
    }
}
