using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string FullName => FirstName + " " + MiddleName + " " + Surname;

        public string Egn { get; set; }

        public string Address { get; set; }

        public string Nationality { get; set; }

        public string PassportNum { get; set; }

        public string Gender { get; set; }


    }
}
