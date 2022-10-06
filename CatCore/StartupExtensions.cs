using CatCore;

namespace Microsoft.Extensions.DependencyInjection;
public static class StartupExtensions {
    public static IServiceCollection AddCatCoreServices(this IServiceCollection services) {
        services.AddScoped<ICatCreator, CatCreator>();
        services.AddScoped<ICatFactory, CatFactory>();
        return services;
    }
}

