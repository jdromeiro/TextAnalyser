using Domain.Model;

namespace Domain.Services
{
    internal interface ISortingStrategyFactory
    {
        ISortingStrategy Create(TextSortOption textSortOption);
    }
}
