using System;

namespace _49_DependencyInjection
{
    class Program
    {
        //Client Class: Depends on service class. Receiving object
        //Service Clss: Provides service to client class.,  the passed-in ('injected') object is called a service
        //Injector Class: Injects the service class object into the clien class



        static void Main(string[] args)
        {
            BusinessLogicService businessLogicService = new BusinessLogicService(new StudentService());
            businessLogicService = new BusinessLogicService(new TeaherService());
            Console.ReadKey();
        }




        public class BusinessLogicService // Client Class
        {
            private IService iService;

            public BusinessLogicService(IService _iService)
            {
                iService = _iService;
                iService.GetFirstName();
                iService.GetLastName();

            }
        }





        public interface IService
        {
            void GetFirstName();
            void GetLastName();
        }

        public class StudentService : IService //Service Class 1
        {
            public void GetFirstName()
            {
                Console.WriteLine("Student First Name");
            }

            public void GetLastName()
            {
                Console.WriteLine("Student Last Name");
            }
        }


        public class TeaherService : IService //Service Class 2
        {
            public void GetFirstName()
            {
                Console.WriteLine("Teacher First Name");
            }

            public void GetLastName()
            {
                Console.WriteLine("Teacher Last Name");
            }
        }
    }
}
