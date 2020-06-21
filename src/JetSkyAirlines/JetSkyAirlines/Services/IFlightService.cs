using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public interface IFlightService : IDataService<Flight>
    {
        Task<bool> Delete(int id);
    }
}
