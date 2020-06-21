using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class Airplane
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int Capacity { get; set; }

        public IEnumerable<ApplicationUser> Passengers { get; set; }


    }
}
