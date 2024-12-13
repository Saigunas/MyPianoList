using MyPianoList.Domain;

namespace MyPianoList.Infrastructure.Interfaces
{
    public interface IRatingRepository : IRepository<Rating>
    {
        Task<double> GetTotalLikeDislikeRatioAsync();
        Task<double> GetMaxLikeDislikeRatioAsync();
    }
}