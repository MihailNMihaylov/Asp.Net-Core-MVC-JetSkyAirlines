using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public Airport FromAirport { get; set; }

        public Airport ToAirport { get; set; }

        public Airplane Airplane { get; set; }
    }
}
