namespace EvoSim.Core;

public interface ISimulationProvider
{
    public Guid Create(Guid configId);
}
