namespace Infrastructure.IoC
{
    using Application.Services.DependencyInjection;
    using Domain.Services.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjectionBootstraper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services
                .SetupDomainServices()
                .SetupApplicationServices();
        }
    }
}
