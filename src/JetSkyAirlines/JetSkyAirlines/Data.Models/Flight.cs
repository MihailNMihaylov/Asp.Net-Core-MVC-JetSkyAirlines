﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Data.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public int FromAirport { get; set; }

        public int ToAirport { get; set; }

        public int Airplane { get; set; }
    }
}
