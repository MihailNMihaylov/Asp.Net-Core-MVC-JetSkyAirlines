using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public interface ILuggageService : IDataService<Luggage>
    {
        Task<bool> Delete(int id);
    }
}
