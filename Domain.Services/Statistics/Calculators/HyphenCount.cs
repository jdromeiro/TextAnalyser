using System.Linq;
using Domain.Model;

namespace Domain.Services.Statistics.Calculators
{
    internal class HyphenCount : CalculatorTemplate
    {
        public override StatisticType StatisticType => StatisticType.NumberOfHyphens;

        protected override int CalculateValue(string text)
        {
            return text.Count(x => x == '-');
        }
    }
}
