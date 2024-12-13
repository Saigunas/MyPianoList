using MyPianoList.Domain;

namespace MyPianoList.Application.Interfaces
{
    public interface IRatingService
    {
        Task CreateAsync(Rating rating);
        Task<Rating> UpdateAsync(int id, Rating rating);
        Task RemoveByIdAsync(int id);
        Task<double> GetTotalLikeDislikeRatioAsync();
        Task<double> GetMaxLikeDislikeRatioAsync();
    }
}