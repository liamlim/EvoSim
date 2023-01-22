using EvoSim.Db.Models;
using EvoSim.Models.Simulation;

namespace EvoSim.Db;

public interface ISimulationConfigDbManager : IDbManager<SimulationConfig, DbSimulationConfig>
{
}
