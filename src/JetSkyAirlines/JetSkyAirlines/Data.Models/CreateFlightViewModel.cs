using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class CreateFlightViewModel
    {
        public int FromAirport { get; set; }

        public int ToAirport { get; set; }

        public int AirplaneId { get; set; }
    }
}
