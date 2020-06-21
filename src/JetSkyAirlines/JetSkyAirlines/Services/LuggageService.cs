using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public class LuggageService : DataService<Luggage>, ILuggageService
    {
        public LuggageService(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<bool> Delete(int id)
        {
            var luggage = await this.Data.Luggages.FindAsync(id);

            if (luggage == null)
            {
                return false;
            }

            this.Data.Luggages.Remove(luggage);

            await this.Data.SaveChangesAsync();

            return true;
        }
    }
}
