using Domain.Model;

namespace Domain.Services.Statistics.Calculators
{
    internal class WordCount : CalculatorTemplate
    {
        public override StatisticType StatisticType => StatisticType.NumberOfWords;

        protected override int CalculateValue(string text)
        {
            return text.Split().Length;
        }
    }
}
