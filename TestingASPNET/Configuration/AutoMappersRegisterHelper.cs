namespace TestingASPNET.Configuration;

using System;
using System.Linq;

public static class AutoMappersRegisterHelper
{
    public static void Register(IServiceCollection services)
    {
        var assembliestemp = AppDomain.CurrentDomain.GetAssemblies();
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(s => s.FullName != null /* && s.FullName.ToLower().StartsWith("testingaspnet.") */);

        services.AddAutoMapper(assemblies);
    }
}