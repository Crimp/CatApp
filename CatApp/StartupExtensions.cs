using CatApp;

namespace Microsoft.Extensions.DependencyInjection;
public static class StartupExtensions {
    public static IServiceCollection AddCatServices(this IServiceCollection services) {
        services.AddCatCoreServices();
        services.AddCatShelterServices();

        services.AddScoped<CatCustomizer>();
        return services;
    }
}

