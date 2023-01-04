using Microsoft.AspNetCore.Mvc;
using MiniFB.Core.Services;
using MiniFB.Core.Models;

namespace learn_web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController : ControllerBase
{
    private IStatusService _statusService { get; }

    public StatusController(IStatusService statusService)
    {
        _statusService = statusService;
    }

    [HttpGet]
    public IActionResult GetAllStatus()
    {
        return Ok(_statusService.GetAllStatus());
    }

    [HttpGet]
    [Route("{id:guid}")]
    public IActionResult GetStatus()
    {
        return Ok("One");
    }
}
