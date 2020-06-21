using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public class FlightService : DataService<Flight>, IFlightService
    {
        public FlightService(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<bool> Delete(int id)
        {

            var flight = await this.Data.Flights.FindAsync(id);

            if (flight == null)
            {
                return false;
            }

            this.Data.Flights.Remove(flight);

            await this.Data.SaveChangesAsync();

            return true;
        }
    }
}
