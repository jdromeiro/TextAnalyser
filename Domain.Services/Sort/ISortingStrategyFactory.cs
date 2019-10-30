using Domain.Model;

namespace Domain.Services
{
    public interface ISortingStrategyFactory
    {
        ISortingStrategy Create(TextSortOption textSortOption);
    }
}
