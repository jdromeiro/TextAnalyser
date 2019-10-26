using Domain.Model;
using Domain.Services.Common;
using Domain.Services.Sort;
using Domain.Services.Statistics;

namespace Domain.Services
{
    public class TextEngine : ITextEngine
    {
        private readonly IParagraphConverter paragraphConverter;
        private readonly ISortingStrategyFactory sortingStrategyFactory;
        private readonly IStatisticsAnalyser statisticsAnalyser;

        public TextEngine()
        {
            // TODO inject dependencies

            this.sortingStrategyFactory = new SortingStrategyFactory();
            this.statisticsAnalyser = new StatisticsAnalyser();
            this.paragraphConverter = new ParagraphConverter();
        }

        public TextStatistics GetStatistics(string text)
        {
            return this.statisticsAnalyser.CreateStatistics(text);
        }

        public string SortText(string text, TextSortOption textSortOption)
        {
            var paragraphs = this.paragraphConverter.ConvertToParagraphs(text);

            var sortingStrategy = this.sortingStrategyFactory.Create(textSortOption);

            var sortedParagraphs = sortingStrategy.Sort(paragraphs);

            return this.paragraphConverter.ConvertToString(sortedParagraphs);
        }
    }
}
