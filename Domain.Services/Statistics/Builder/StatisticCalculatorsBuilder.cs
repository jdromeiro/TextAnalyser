using System.Collections.Generic;
using Domain.Services.Statistics.Calculators;

namespace Domain.Services.Statistics.Builder
{
    internal class StatisticCalculatorsBuilder : IStatisticCalculatorsBuilder
    {
        private List<IStatisticCalculator> statisticsStrategies;

        public StatisticCalculatorsBuilder()
        {
            this.statisticsStrategies = new List<IStatisticCalculator>();
        }

        public IEnumerable<IStatisticCalculator> Build()
        {
            return statisticsStrategies;
        }

        public IStatisticCalculatorsBuilder WithHyphensCount()
        {
            statisticsStrategies.Add(new HyphenCount());

            return this;
        }

        public IStatisticCalculatorsBuilder WithSpacesCount()
        {
            statisticsStrategies.Add(new SpaceCount());

            return this;
        }

        public IStatisticCalculatorsBuilder WithWordsCount()
        {
            statisticsStrategies.Add(new WordCount());

            return this;
        }
    }
}
