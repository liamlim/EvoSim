namespace EvoSim.Models.Simulation.Sections;

public sealed record BrainConfig
{
    /// <summary>
    /// The maximum number of connections between neurons in the brain of an entity
    /// </summary>
    public int MaxNeuralConnections { get; init; }

    /// <summary>
    /// The maximum number of internal neurons in the brain of an entity, used to process and integrate sensory information
    /// </summary>
    public int MaxInternalNeurons { get; init; }

    /// <summary>
    /// The maximum number of sensory neurons in the brain of an entity, used to receive input from the environment
    /// </summary>
    public int MaxSensoryNeurons { get; init; }

    /// <summary>
    /// The maximum number of effector neurons in the brain of an entity, used to control the actions of the entity
    /// </summary>
    public int MaxEffectorNeurons { get; init; }

    /// <summary>
    /// The rate at which mutations should occur in the genomes of the entities
    /// </summary>
    public decimal MutationRate { get; init; }
}
