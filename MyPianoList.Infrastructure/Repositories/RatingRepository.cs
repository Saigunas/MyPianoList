using Microsoft.EntityFrameworkCore;
using MyPianoList.Domain;
using MyPianoList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Infrastructure.Repositories
{
    public class RatingRepository : Repository<Rating>, IRatingRepository
    {
        private readonly ApplicationDbContext _context;
        public RatingRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task<double> GetTotalLikeDislikeRatioAsync()
        {
            return await (from rating in _context.Rating
                          group rating by rating.PianoSheetId into sheetRatings
                          select sheetRatings.Average(r => r.RatingValue == RatingType.Like ? 1 : -1))
                         .AverageAsync();
        }

        public async Task<double> GetMaxLikeDislikeRatioAsync()
        {
            return await (from rating in _context.Rating
                          group rating by rating.PianoSheetId into sheetRatings
                          select sheetRatings.Average(r => r.RatingValue == RatingType.Like ? 1 : -1))
                         .MaxAsync();
        }

    }
}
