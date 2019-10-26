using Domain.Model;

namespace Domain.Services.Statistics.Commands
{
    internal interface IStatisticsCommand
    {
        Statistic GetStatistic(string text);
    }
}
