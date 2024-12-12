using MyPianoList.Domain;

namespace MyPianoList.Infrastructure.Interfaces
{
    public interface IPianoSheetTagRepository : IRepository<PianoSheetTag>
    {
        Task SetPianoSheetTags(int pianoSheetId, IEnumerable<int> tagIds);
    }
}