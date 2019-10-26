using System.Collections.Generic;
using Domain.Model;
using Domain.Services.Statistics.Buider;
using Domain.Services.Statistics.Builder;

namespace Domain.Services.Statistics
{
    internal class StatisticsAnalyser : IStatisticsAnalyser
    {
        private readonly IStatisticCommandsBuilder builder;

        public StatisticsAnalyser()
        {
            // TODO inject dependency
            this.builder = new StatisticCommandsBuilder();
        }

        public TextStatistics CreateStatistics(string text)
        {
            var statistics = new List<Statistic>();

            var statisticsCommands = this.builder
                .WithWordStatisticCommand()
                .WithSpacesStatisticCommand()
                .WithHyphensStatisticCommand()
                .Build();

            foreach (var command in statisticsCommands)
            {
                statistics.Add(command.GetStatistic(text));
            }

            return new TextStatistics()
            {
                Statistics = statistics
            };
        }
    }
}
