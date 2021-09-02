using System;

namespace Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Topic 1
            Address address = new Address();
            address.RoadNo = "2";
            address.District = "CTG";


            Person person1 = new Person();
            person1.FirstName = "Md.";
            person1.MiddleName = "Mubasshir";
            person1.LastName = "Raihan";
            person1.PresentAddress = address;

            string sName2= person1.FirstName;

            string district2 = person1.PresentAddress.HouseNo;


            string houseNo = person1.PresentAddress.HouseNo;
            string district = person1.PresentAddress.District;

            Console.WriteLine(person1.GetFullName());
            Console.WriteLine(person1.PresentAddress.HouseNo);
            Console.WriteLine(person1.PresentAddress.District);
            #endregion


            ////////////////////Set
            PresentAddress address1 = new PresentAddress();
            address1.ApartmentNo = "4A";
            address1.HouseNo = "78";
            address1.RoadNo = "01";

            Student student1 = new Student();
            student1.RegNo = "1342";
            student1.Name = "Raihan";
            student1.Email = "Examle@gmail.com"; 

            student1.StudentPresentAddress = address1;


            //////////////////////////Get
            string sName = student1.Name;
            PresentAddress stuPAddress = student1.StudentPresentAddress;

            string houseNO = student1.StudentPresentAddress.HouseNo;

        }
    }
}
