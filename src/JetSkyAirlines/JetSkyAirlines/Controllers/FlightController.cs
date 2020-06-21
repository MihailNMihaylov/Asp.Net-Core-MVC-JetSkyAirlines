using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services;
using Microsoft.AspNetCore.Mvc;

namespace JetSkyAirlines.Controllers
{
    public class FlightController : Controller
    {
        private readonly IFlightService flights;

        public FlightController(IFlightService flights)
        {
            this.flights = flights;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFlightViewModel inputModel)
        {
            var flight = new Flight
            {
                FromAirport = inputModel.FromAirport,
                ToAirport = inputModel.ToAirport,
                Airplane = inputModel.AirplaneId
            };

            await this.flights.Save(flight);

            return Ok();
        }
    }
}
