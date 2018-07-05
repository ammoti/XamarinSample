using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.Models
{
    public class AuthenticationResponse
    {
        public bool IsAuthenticated { get; set; }
        public User User { get; set; }
    }
}