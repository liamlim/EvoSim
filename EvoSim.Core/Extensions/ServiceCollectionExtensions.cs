using EvoSim.Core.Providers;

using Microsoft.Extensions.DependencyInjection;

namespace EvoSim.Core;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<ISimulationProvider, SimulationProvider>();

        return services;
    }
}
