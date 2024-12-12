using MyPianoList.Domain;

namespace MyPianoList.Application.Interfaces
{
    public interface IPianoSheetTagService
    {
        Task SetPianoSheetTags(int pianoSheetId, IEnumerable<int> tagIds);
    }
}