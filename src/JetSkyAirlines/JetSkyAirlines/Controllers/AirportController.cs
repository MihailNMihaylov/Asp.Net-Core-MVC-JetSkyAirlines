using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services;
using Microsoft.AspNetCore.Mvc;

namespace JetSkyAirlines.Controllers
{
    public class AirportController : Controller
    {
        private readonly IAirportService airports;

        public AirportController(IAirportService airports)
        {
            this.airports = airports;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAirportViewModel inputModel)
        {
            var airport = new Airport
            {
                Location = inputModel.Location
            };

            await this.airports.Save(airport);

            return Ok();
        }
    }
}
