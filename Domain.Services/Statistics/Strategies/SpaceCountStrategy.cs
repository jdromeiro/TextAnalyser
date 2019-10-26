using System;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Statistics.Strategies
{
    internal class SpaceCountStrategy : IStatisticStrategy
    {
        public Statistic GenerateStatistic(string text)
        {
            return new Statistic()
            {
                Type = StatisticType.NumberOfSpaces,
                Value = this.CountSpaces(text)
            };
        }

        private int CountSpaces(string text)
        {
            return text.Count(Char.IsWhiteSpace);
        }
    }
}
