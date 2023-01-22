using EvoSim.Api.Models;
using EvoSim.Core;

using Microsoft.AspNetCore.Mvc;

namespace EvoSim.Api.Controllers;

[Route("db/simulation")]
public class DbSimulationController : ControllerBase
{
    private readonly ISimulationProvider _simulation;

    public DbSimulationController(ISimulationProvider simulation)
    {
        _simulation = simulation;
    }

    [HttpPost("")]
    public Guid CreateSimulation([FromBody] CreateSimulationModel model)
    {
        return _simulation.Create(model.ConfigId);
    }

    [HttpGet("{id}")]
    public SimulationModel GetSimulation(Guid id)
    {
        throw new NotImplementedException();
    }
}
