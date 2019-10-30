namespace Domain.Services.Statistics
{
    using Domain.Model;

    internal interface IStatisticCalculator
    {
        Statistic GenerateStatistic(string text);
    }
}
