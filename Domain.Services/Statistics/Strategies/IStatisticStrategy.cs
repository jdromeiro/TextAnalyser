using Domain.Model;

namespace Domain.Services.Statistics.Strategies
{
    internal interface IStatisticStrategy
    {
        Statistic GenerateStatistic(string text);
    }
}
