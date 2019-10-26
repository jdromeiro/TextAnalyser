using System.Linq;
using Domain.Model;

namespace Domain.Services.Statistics.Strategies
{
    public class HyphenCountStrategy : IStatisticStrategy
    {
        public Statistic GenerateStatistic(string text)
        {
            return new Statistic()
            {
                Type = StatisticType.NumberOfHyphens,
                Value = this.CountHyphens(text)
            };
        }

        private int CountHyphens(string text)
        {
            return text.Count(x => x == '-');
        }
    }
}
