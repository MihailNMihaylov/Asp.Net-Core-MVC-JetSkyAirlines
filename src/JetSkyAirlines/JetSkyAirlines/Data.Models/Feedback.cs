using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int ApplicationUsedId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }
    }
}
