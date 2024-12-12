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
    public class PianoSheetTagRepository : Repository<PianoSheetTag>, IPianoSheetTagRepository
    {
        private readonly ApplicationDbContext _context;
        public PianoSheetTagRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task SetPianoSheetTags(int pianoSheetId, IEnumerable<int> tagIds)
        {
            var existingTags = await _context.PianoSheetTag
                .Where(pst => pst.PianoSheetId == pianoSheetId)
                .ToListAsync();

            // Remove any tags that are not in the selected tags
            var tagsToRemove = existingTags.Where(pst => !tagIds.Contains(pst.TagId)).ToList();
            _context.PianoSheetTag.RemoveRange(tagsToRemove);

            // Add new tags
            foreach (var tagId in tagIds)
            {
                if (!existingTags.Any(pst => pst.TagId == tagId))
                {
                    _context.PianoSheetTag.Add(new PianoSheetTag
                    {
                        PianoSheetId = pianoSheetId,
                        TagId = tagId
                    });
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
