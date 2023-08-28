using Microsoft.Extensions.DependencyInjection;

namespace SumOfOddService
{
    public static class Bootstraper
    {
        public static IServiceCollection AddSumOfOddService(this IServiceCollection services)
        {
            services
                .AddTransient<ISumOfOddService, SumOfOddServiceClass>();

            return services;
        } 
    }
}
