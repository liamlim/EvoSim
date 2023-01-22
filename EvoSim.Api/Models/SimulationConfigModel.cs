namespace EvoSim.Api.Models;

public sealed record SimulationConfigModel
{
    public required Guid ConfigId { get; init; }
}
