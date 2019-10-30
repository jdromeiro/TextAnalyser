namespace Domain.Services.Statistics.Calculators
{
    using Domain.Model;

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
