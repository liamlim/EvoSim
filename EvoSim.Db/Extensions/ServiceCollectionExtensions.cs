using EvoSim.Db.Managers;

using Microsoft.Extensions.DependencyInjection;

namespace EvoSim.Db.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDbServices(this IServiceCollection services)
    {
        services.AddSingleton<ISimulationDbManager, SimulationDbManager>();
        services.AddSingleton<ISimulationConfigDbManager, SimulationConfigDbManager>();

        return services;
    }
}
