using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JetSkyAirlines.Controllers
{
    public class LuggageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILuggageService luggages;

        public LuggageController(UserManager<ApplicationUser> userManager, ILuggageService luggages)
        {
            this._userManager = userManager;
            this.luggages = luggages;
            
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLuggageViewModel inputModel)
        {
            var currentUser = await this._userManager.GetUserAsync(HttpContext.User);

            var luggage = new Luggage
            {
                Weights = inputModel.Weight,
                ApplicationUserId = currentUser.Id
                    
            };

            await this.luggages.Save(luggage);

            return Ok();
        }
    }
}
