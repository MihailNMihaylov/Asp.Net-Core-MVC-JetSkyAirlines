using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{

    public interface IAirplaneService : IDataService<Airplane>
    {

        Task<bool> Delete(int id);

    }
}
