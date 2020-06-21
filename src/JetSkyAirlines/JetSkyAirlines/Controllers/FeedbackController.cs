using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetSkyAirlines.Data.Models;
using JetSkyAirlines.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JetSkyAirlines.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IFeedbackService feedbacks;
        public FeedbackController(UserManager<ApplicationUser> userManager, IFeedbackService feedbacks)
        {
            this._userManager = userManager;
            this.feedbacks = feedbacks;

        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFeedbackViewModel inputModel)
        {
            var currentUser = await this._userManager.GetUserAsync(HttpContext.User);

            var feedback = new Feedback
            {
                Content = inputModel.Content,
                ApplicationUsedId = currentUser.Id,
                FlightId = inputModel.FlightId

            };

            await this.feedbacks.Save(feedback);

            return Ok();
        }
    }
}
