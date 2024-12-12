using MyPianoList.Domain;
using MyPianoList.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPianoList.Application.Interfaces
{
    public interface IPianoSheetService
    {
        IEnumerable<PianoSheet> GetAll();
        Task<List<PianoSheetDetailsDto>> GetAllWithDetails(string userId);
        Task<PianoSheet> GetByIdAsync(int id);
        Task CreateAsync(PianoSheet pianoSheet);
        Task<PianoSheet> UpdateAsync(int id, PianoSheet pianoSheet);
        Task RemoveByIdAsync(int id);
        Task<PianoSheet> GetByIdWithTagsAsync(int id);
        Task<PianoSheet> CreateAndSaveAsync(PianoSheet pianoSheet);
    }
}
