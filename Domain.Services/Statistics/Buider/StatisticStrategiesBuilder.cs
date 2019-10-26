using System.Collections.Generic;
using Domain.Services.Statistics.Builder;
using Domain.Services.Statistics.Strategies;

namespace Domain.Services.Statistics.Buider
{
    internal class StatisticStrategiesBuilder : IStatisticStrategiesBuilder
    {
        private List<IStatisticStrategy> statisticsStrategies;

        public StatisticStrategiesBuilder()
        {
            this.statisticsStrategies = new List<IStatisticStrategy>();
        }

        public IEnumerable<IStatisticStrategy> Build()
        {
            return statisticsStrategies;
        }

        public IStatisticStrategiesBuilder WithHyphensStatisticStrategy()
        {
            statisticsStrategies.Add(new HyphenCountStrategy());

            return this;
        }

        public IStatisticStrategiesBuilder WithSpacesStatisticStrategy()
        {
            statisticsStrategies.Add(new SpaceCountStrategy());

            return this;
        }

        public IStatisticStrategiesBuilder WithWordStatisticStrategy()
        {
            statisticsStrategies.Add(new WordCountStrategy());

            return this;
        }
    }
}
