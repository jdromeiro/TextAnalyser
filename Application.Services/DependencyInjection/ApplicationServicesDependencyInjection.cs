using Application.Services.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services.DependencyInjection
{
    public static class ApplicationServicesDependencyInjection
    {
        public static IServiceCollection SetupApplicationServices(this IServiceCollection services)
        {
            return services
                    .AddSingleton<ITextApplicationService, TextApplicationService>()
                    .AddSingleton<ISortOptionMapper, SortOptionMapper>()
                    .AddSingleton<ITextStatisticsMapper, TextStatisticsMapper>();
        }
    }
}
