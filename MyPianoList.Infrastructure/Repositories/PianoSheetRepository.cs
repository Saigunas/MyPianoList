using Microsoft.EntityFrameworkCore;
using MyPianoList.Domain;
using MyPianoList.Infrastructure.DTOs;
using MyPianoList.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Infrastructure.Repositories
{
    public class PianoSheetRepository : Repository<PianoSheet>, IPianoSheetRepository
    {
        private readonly ApplicationDbContext _context;
        public PianoSheetRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<PianoSheetDetailsDto>> GetPianoSheetsWithDetailsAsync(string userId)
        {
            // Eager loading
            return await _context.PianoSheet
                .Include(sheet => sheet.PianoSheetTags)
                    .ThenInclude(tag => tag.Tag)
                .Include(sheet => sheet.Ratings)
                .Include(sheet => sheet.Statuses)
                .Select(sheet => new PianoSheetDetailsDto
                {
                    Id = sheet.Id,
                    Title = sheet.Title,
                    Tags = sheet.PianoSheetTags.Select(tag => tag.Tag.TagName).ToList(),
                    CurrentRating = sheet.Ratings.Any()
                        ? sheet.Ratings.Sum(r => r.RatingValue == RatingType.Like ? 1 : -1)
                        : 0, // Sum of all user ratings (Like = +1, Dislike = -1)
                    UserRating = sheet.Ratings
                        .Where(rating => rating.UserId == userId)
                        .First(),
                    UserStatus = sheet.Statuses
                        .Where(status => status.UserId == userId)
                        .First()
                })
                .ToListAsync();
        }

        public async Task<PianoSheet?> GetByIdWithTagsAsync(int id)
        {
            return await _context.PianoSheet
                .Include(p => p.PianoSheetTags)
                    .ThenInclude(pst => pst.Tag)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

    }
}
