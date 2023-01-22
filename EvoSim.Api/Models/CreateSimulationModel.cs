namespace EvoSim.Api.Models;

public sealed record CreateSimulationModel
{
    public required Guid ConfigId { get; init; }
}
