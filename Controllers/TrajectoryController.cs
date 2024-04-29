using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller]")]
public class TrajectoryController : ControllerBase
{
    ITrajectoryService trajectoryService;

    public TrajectoryController(ITrajectoryService service)
    {
        trajectoryService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(trajectoryService.Get());
    }


    [HttpPost]
    public IActionResult Post([FromBody] Trajectory trajectory)
    {
        trajectoryService.Save(trajectory);
        return Ok();
    }


    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Trajectory trajectory)
    {
        trajectoryService.Update(id, trajectory);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        trajectoryService.Delete(id);
        return Ok();
    }

}