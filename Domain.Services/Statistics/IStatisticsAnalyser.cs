using Domain.Model;

namespace Domain.Services.Statistics
{
    internal interface IStatisticsAnalyser
    {
        TextStatistics CreateStatistics(string text);
    }
}
