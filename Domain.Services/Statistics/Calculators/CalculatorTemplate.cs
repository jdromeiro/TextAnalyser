using Domain.Model;

namespace Domain.Services.Statistics.Calculators
{
    public abstract class CalculatorTemplate : IStatisticCalculator
    {
        public abstract StatisticType StatisticType { get; }

        public Statistic GenerateStatistic(string text)
        {
            return new Statistic()
            {
                Type = this.StatisticType,
                Value = this.CalculateValue(text)
            };
        }

        protected abstract int CalculateValue(string text);
    }
}
