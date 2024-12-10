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
        public PianoSheetTagRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
