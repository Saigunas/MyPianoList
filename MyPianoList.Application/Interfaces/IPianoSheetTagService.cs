using MyPianoList.Domain;

namespace MyPianoList.Application.Interfaces
{
    public interface IPianoSheetTagService
    {
        IEnumerable<PianoSheetTag> GetAll();
        Task<PianoSheetTag> GetByIdAsync(int id);
        Task CreateAsync(PianoSheetTag pianoSheetTag);
        Task<PianoSheetTag> UpdateAsync(int id, PianoSheetTag pianoSheetTag);
        Task RemoveByIdAsync(int id);
    }
}