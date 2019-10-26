using Domain.Model;

namespace Domain.Services.Statistics.Strategies
{
    internal class WordCountCommand : IStatisticStrategy
    {
        public Statistic GenerateStatistic(string text)
        {
            return new Statistic()
            {
                Type = StatisticType.NumberOfWords,
                Value = this.CountWords(text)
            };
        }

        private int CountWords(string text)
        {
            return text.Split().Length;
        }
    }
}
