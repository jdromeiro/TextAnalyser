using Domain.Model;
using Domain.Services.Sort.Strategies;

namespace Domain.Services.Sort
{
    internal class SortingStrategyFactory : ISortingStrategyFactory
    {
        public ISortingStrategy Create(TextSortOption textSortOption)
        {
            switch (textSortOption)
            {
                case TextSortOption.ByAlphabeticOrder:
                    return new ByAlphabeticOrderSortingStrategy();

                case TextSortOption.ByReversedAlphabeticOrder:
                    return new ByReversedAlphabeticOrderSortingStrategy();

                case TextSortOption.ByReversedOrder:
                    return new ByReverseOrderStrategy();

                case TextSortOption.Unknown:
                default:
                    throw new TextEngineException("Unable to apply sorting strategy due to unknown sorting option");
            }
        }
    }
}
