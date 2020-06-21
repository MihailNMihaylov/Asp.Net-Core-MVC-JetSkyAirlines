using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public class AirplaneService : DataService<Airplane>, IAirplaneService
    {
        public AirplaneService(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<bool> Delete(int id)
        {
            var airplane = await this.Data.Airplanes.FindAsync(id);

            if (airplane == null)
            {
                return false;
            }

            this.Data.Airplanes.Remove(airplane);

            await this.Data.SaveChangesAsync();

            return true;
        }
    }
}
