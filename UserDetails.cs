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
        public Match FirstName(string firstname, string pattern)
        {
            this.firstName = firstname;
            return Regex.Match(firstName, pattern);

        }
    }
}
