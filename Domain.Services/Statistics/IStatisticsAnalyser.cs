namespace Domain.Services.Statistics
{
    using Domain.Model;

    public interface IStatisticsAnalyser
    {
        TextStatistics CreateStatistics(string text);
    }
}
