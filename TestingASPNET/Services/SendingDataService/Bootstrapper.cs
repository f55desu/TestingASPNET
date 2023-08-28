using Microsoft.Extensions.DependencyInjection;

namespace TestingASPNET.Services.SendingDataService;

public static class Bootstrapper
{
    public static IServiceCollection AddSendingDataService(this IServiceCollection services)
    {
        services
            .AddSingleton<ISendingDataService, SendingDataServiceClass>();

        return services;
    }
}