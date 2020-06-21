using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class CreateFeedbackViewModel
    {
        public string Content { get; set; }

        public string ApplicationUserId { get; set; }

        public int FlightId { get; set; }
    }
}
