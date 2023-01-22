namespace EvoSim.Api.Models;

public sealed record SimulationModel
{
    public required Guid SimulationId { get; init; }

    public required SimulationConfigModel Config { get; init; }
}
