using EvoSim.Db;
using EvoSim.Models.Simulation;

using Microsoft.AspNetCore.Mvc;

namespace EvoSim.Api.Controllers;

[Route("db/simulation-config")]
public class DbSimulationConfigController : ControllerBase
{
    private readonly ISimulationConfigDbManager _simulationConfig;

    public DbSimulationConfigController(ISimulationConfigDbManager simulationConfig)
    {
        _simulationConfig = simulationConfig;
    }

    [HttpPost("")]
    public void CreateSimulationConfig([FromBody] SimulationConfig model)
    {
        _simulationConfig.InsertOne(model);
    }

    [HttpDelete("{id}")]
    public void DeleteSimulationConfig(Guid id)
    {
        _simulationConfig.DeleteOne(id);
    }

    [HttpGet("{id}")]
    public void GetSimulationConfig(Guid id)
    {
        _simulationConfig.GetOne(id);
    }
}
