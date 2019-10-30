namespace Domain.Services
{
    using Domain.Model;
    using Domain.Services.Common;
    using Domain.Services.Statistics;

    public class TextEngine : ITextEngine
    {
        private readonly IParagraphConverter paragraphConverter;
        private readonly ISortingStrategyFactory sortingStrategyFactory;
        private readonly IStatisticsAnalyser statisticsAnalyser;

        public TextEngine(
            IParagraphConverter paragraphConverter,
            ISortingStrategyFactory sortingStrategyFactory,
            IStatisticsAnalyser statisticsAnalyser
            )
        {
            this.paragraphConverter = paragraphConverter;
            this.sortingStrategyFactory = sortingStrategyFactory;
            this.statisticsAnalyser = statisticsAnalyser;
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
