using Domain.Model;
using Domain.Services.Sort;
using Domain.Services.Statistics;

namespace Domain.Services
{
    public class TextEngine : ITextEngine
    {
        private readonly ISortingStrategyFactory sortingStrategyFactory;
        private readonly StatisticsAnalyser statisticsAnalyser;

        public TextEngine()
        {
            // TODO inject dependencies

            this.sortingStrategyFactory = new SortingStrategyFactory();
            this.statisticsAnalyser = new StatisticsAnalyser();
        }

        public TextStatistics GetStatistics(string text)
        {
            return this.statisticsAnalyser.CreateStatistics(text);
        }

        public string SortText(string text, TextSortOption textSortOption)
        {
            var sortingStrategy = this.sortingStrategyFactory.Create(textSortOption);

            return sortingStrategy.Sort(text);
        }
    }
}
