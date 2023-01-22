namespace EvoSim.Models.Simulation.Sections;

public sealed record GenerationConfig
{
    /// <summary>
    /// The rate of at which entities survive and are able to reproduce each generation
    /// </summary>
    public required decimal SurvivalRate { get; init; }

    /// <summary>
    /// The number of ticks per generation
    /// </summary>
    public required int TickCount { get; init; }
}
