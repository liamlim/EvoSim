using EvoSim.Db;

namespace EvoSim.Core.Providers;

internal sealed class SimulationProvider : ISimulationProvider
{
    private readonly ISimulationDbManager _db;

    public SimulationProvider(ISimulationDbManager db)
    {
        _db = db;
    }

    public Guid Create(Guid configId)
    {
        throw new NotImplementedException();
    }
}
