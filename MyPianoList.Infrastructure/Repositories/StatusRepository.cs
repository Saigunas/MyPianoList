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
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        private readonly ApplicationDbContext _context;
        public StatusRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
