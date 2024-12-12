using MyPianoList.Domain;

namespace MyPianoList.Application.Interfaces
{
    public interface IStatusService
    {
        Task CreateAsync(Status status);
        Task<Status> UpdateAsync(int id, Status status);
        Task RemoveByIdAsync(int id);
    }
}