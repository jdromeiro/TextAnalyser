using System;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Statistics.Calculators
{
    internal class SpaceCount : CalculatorTemplate
    {
        public override StatisticType StatisticType => StatisticType.NumberOfSpaces;

        protected override int CalculateValue(string text)
        {
            return text.Count(Char.IsWhiteSpace);
        }
    }
}
