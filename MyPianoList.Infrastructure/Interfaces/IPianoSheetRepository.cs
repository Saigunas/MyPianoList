using MyPianoList.Domain;
using MyPianoList.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Infrastructure.Interfaces
{
    public interface IPianoSheetRepository : IRepository<PianoSheet>
    {
        Task<List<PianoSheetDetailsDto>> GetPianoSheetsWithDetailsAsync(string userId);
        Task<PianoSheet?> GetByIdWithTagsAsync(int id);
    }
}
