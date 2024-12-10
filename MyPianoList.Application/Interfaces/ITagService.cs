using MyPianoList.Domain;

namespace MyPianoList.Application.Interfaces
{
    public interface ITagService
    {
        IEnumerable<Tag> GetAll();
        Task<Tag> GetByIdAsync(int id);
        Task CreateAsync(Tag tag);
        Task<Tag> UpdateAsync(int id, Tag tag);
        Task RemoveByIdAsync(int id);
    }
}