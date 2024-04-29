using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller]")]
public class TaxiController : ControllerBase
{
    ITaxiService taxiService;

    public TaxiController(ITaxiService service)
    {
        taxiService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(taxiService.Get());
    }


    [HttpPost]
    public IActionResult Post([FromBody] Taxi taxi)
    {
            taxiService.Save(taxi);
            return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Taxi taxi)
    {
        taxiService.Update(id, taxi);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        taxiService.Delete(id);
        return Ok();
    }
}