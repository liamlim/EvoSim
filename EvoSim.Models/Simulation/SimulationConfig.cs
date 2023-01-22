using EvoSim.Models.Simulation.Sections;

namespace EvoSim.Models.Simulation;

public sealed record SimulationConfig
{
    /// <summary>
    /// Configuration for the virtual 2D world
    /// </summary>
    public required WorldConfig World { get; init; }

    /// <summary>
    /// Configuration for the brains of the entities
    /// </summary>
    public required BrainConfig Brain { get; init; }

    /// <summary>
    /// Configuration for the evolution process
    /// </summary>
    public required GenerationConfig Generation { get; init; }
}
