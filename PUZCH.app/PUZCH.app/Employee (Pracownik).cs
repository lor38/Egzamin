using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PUZCH.app
{
    internal class Employee__Pracownik_
    {
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; } // Employee's last name
        public string EmailAddress { get; set; } // Employee's email address

        public Employee__Pracownik_(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        


    }
}
