using System.Collections.Generic;
using Domain.Model;
using Domain.Services.Statistics.Builder;

namespace Domain.Services.Statistics
{
    internal class StatisticsAnalyser : IStatisticsAnalyser
    {
        private readonly IStatisticCalculatorsBuilder statisticCalculatorsBuilder;

        public StatisticsAnalyser()
        {
            // TODO inject dependency
            this.statisticCalculatorsBuilder = new StatisticCalculatorsBuilder();
        }

        public TextStatistics CreateStatistics(string text)
        {
            var statistics = new List<Statistic>();

            var calculators = this.statisticCalculatorsBuilder
                .WithWordsCount()
                .WithSpacesCount()
                .WithHyphensCount()
                .Build();

            foreach (var calculator in calculators)
            {
                statistics.Add(calculator.GenerateStatistic(text));
            }

            return new TextStatistics()
            {
                Statistics = statistics
            };
        }
    }
}
