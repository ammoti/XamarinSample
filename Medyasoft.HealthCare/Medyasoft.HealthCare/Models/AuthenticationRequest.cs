﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.Models
{
    public class AuthenticationRequest
    {
        public string Password { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}

