using JetSkyAirlines.Data;
using JetSkyAirlines.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JetSkyAirlines.Services
{
    public class FeedbackService : DataService<Feedback>, IFeedbackService
    {
        public FeedbackService(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<bool> Delete(int id)
        {

            var feedback = await this.Data.Feedbacks.FindAsync(id);

            if (feedback == null)
            {
                return false;
            }

            this.Data.Feedbacks.Remove(feedback);

            await this.Data.SaveChangesAsync();

            return true;
        }
    }
}
