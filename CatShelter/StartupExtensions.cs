using CatCore;
using CatShelter;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection;
public static class StartupExtensions {
    public static IServiceCollection AddCatShelterServices(this IServiceCollection services) {
        return services;
    }
}

