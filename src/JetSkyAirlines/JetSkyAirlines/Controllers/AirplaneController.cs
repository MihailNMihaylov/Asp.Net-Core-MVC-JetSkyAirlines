using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Controllers
{
    public class AirplaneController : Controller
    {
         private readonly IAirplaneService airplanes;

        public AirplaneController(IAirplaneService airplanes)
        {
            this.airplanes = airplanes;
        }



        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAirplaneViewModel inputModel)
        {
            var airplane = new Airplane
            {
                Model = inputModel.Model,
                Capacity = inputModel.Capacity
            };

            await this.airplanes.Save(airplane);

            return Ok();
        }

    }
}
