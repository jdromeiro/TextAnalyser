namespace Domain.Services.DependencyInjection
{
    using Domain.Services.Common;
    using Domain.Services.Sort;
    using Domain.Services.Statistics;
    using Domain.Services.Statistics.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public static class DomainServicesDependencyInjection
    {
        public static IServiceCollection SetupDomainServices(this IServiceCollection services)
        {
            return services
                    .AddSingleton<IParagraphConverter, ParagraphConverter>()
                    .AddSingleton<ITextEngine, TextEngine>()
                    .AddSingleton<ISortingStrategyFactory, SortingStrategyFactory>()
                    .AddSingleton<IStatisticsAnalyser, StatisticsAnalyser>()
                    .AddSingleton<IStatisticCalculatorsBuilder, StatisticCalculatorsBuilder>();
        }
    }
}
