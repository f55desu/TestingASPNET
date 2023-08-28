using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeService
{
    public static class Bootstraper
    {
        public static IServiceCollection AddPalindromeService(this IServiceCollection services)
        {
            services
                .AddTransient<IPalindromeService, PalindromeServiceClass>();

            return services;
        }
    }
}
