namespace EvoSim.Models.Simulation.Sections;

public sealed record WorldConfig
{
    /// <summary>
    /// The width of the virtual 2D world
    /// </summary>
    public int Width { get; init; }

    /// <summary>
    /// The height of the virtual 2D world
    /// </summary>
    public int Height { get; init; }

    /// <summary>
    /// The fixed number of entities living in the world
    /// </summary>
    public int EntityCount { get; init; }
}
