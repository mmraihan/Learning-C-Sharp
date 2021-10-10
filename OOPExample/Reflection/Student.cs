using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Student
    {
        public int Id { get; set; }
        public string NAme { get; set; }
        public string Address { get; set; }
        public string RegNo { get; set; }

        private string PhoneNumber { get; set; }  

        public string GetInfo()
        {
            return $"Id: {Id}, Name: {NAme}, Address: {Address}, RegNo: {RegNo}";
        }
    }
}
