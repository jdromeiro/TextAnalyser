using Domain.Model;

namespace Domain.Services.Statistics
{
    internal interface IStatisticCalculator
    {
        Statistic GenerateStatistic(string text);
    }
}
