using Microsoft.Extensions.DependencyInjection;

namespace SortingService
{
    public static class Bootstraper
    {
        public static IServiceCollection AddSortingService(this IServiceCollection services)
        {
            services
                .AddTransient<ISortingService, SortingServiceClass>();

            return services;
        }
    }
}
