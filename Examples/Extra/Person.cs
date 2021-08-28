﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Address PresentAddress { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

    }
}
