using System.Collections.Generic;
using Domain.Model;
using Domain.Services.Statistics.Buider;
using Domain.Services.Statistics.Builder;

namespace Domain.Services.Statistics
{
    internal class StatisticsAnalyser : IStatisticsAnalyser
    {
        private readonly IStatisticStrategiesBuilder builder;

        public StatisticsAnalyser()
        {
            // TODO inject dependency
            this.builder = new StatisticStrategiesBuilder();
        }

        public TextStatistics CreateStatistics(string text)
        {
            var statistics = new List<Statistic>();

            var statisticsStrategies = this.builder
                .WithWordStatisticStrategy()
                .WithSpacesStatisticStrategy()
                .WithHyphensStatisticStrategy()
                .Build();

            foreach (var strategy in statisticsStrategies)
            {
                statistics.Add(strategy.GenerateStatistic(text));
            }

            return new TextStatistics()
            {
                Statistics = statistics
            };
        }
    }
}
