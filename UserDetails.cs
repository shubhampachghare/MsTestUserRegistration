﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MsTestUserRegistration
{
    public class UserDetails
    {
        public String firstName;
        public String lastName;
        public String email;
        public String phoneNumber;
        public String password;
        public Match FirstName(string firstname, string pattern)
        {
            this.firstName = firstname;
            return Regex.Match(firstName, pattern);

        }
        public Match LastName(string lastname, string pattern)
        {
            this.lastName = lastname;

            return Regex.Match(lastName, pattern);

        }
        public Match Email(string email, string pattern)
        {
            this.email = email;


            return Regex.Match(email, pattern);

        }
        public Match PhoneNumber(string phonenumber, string pattern)
        {
            this.phoneNumber = phonenumber;
            return Regex.Match(phoneNumber, pattern);

        }
        public Match Password(string password, string pattern)
        {
            this.password = password;
            return Regex.Match(password, pattern);

        }



    }
}
