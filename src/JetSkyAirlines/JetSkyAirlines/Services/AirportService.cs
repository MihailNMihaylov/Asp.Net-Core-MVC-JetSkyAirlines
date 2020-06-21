using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public class AirportService : DataService<Airport>, IAirportService
    {
        public AirportService(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<bool> Delete(int id)
        {

            var airport = await this.Data.Airports.FindAsync(id);

            if (airport == null)
            {
                return false;
            }

            this.Data.Airports.Remove(airport);

            await this.Data.SaveChangesAsync();

            return true;
        }
    }
}
