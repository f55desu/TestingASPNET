using Microsoft.Extensions.DependencyInjection;

namespace TestingASPNET.Services.SendingDataService;

public static class Bootstraper
{
    public static IServiceCollection AddSendingDataService(this IServiceCollection services)
    {
        services.AddTransient<ISendingDataService, SendingDataServiceClass>();

        return services;
    }
}