using Microsoft.AspNetCore.Mvc;
using MiniFB.Core.Services;
using MiniFB.Contracts.Status;
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
    
    [HttpPost]
    public IActionResult CreateStatus(CreateStatusRequest status)
    {
        try
        {
            var newStatus = new Status(status.Content);
            _statusService.CreateStatus(newStatus);
            return Ok();
        }
        catch (System.Exception e)
        {
            return Problem(e.Message);
        }
    }

    [HttpGet]
    [Route("{id:guid}")]
    public IActionResult GetStatus()
    {
        try
        {
        
            return Ok();
        }
        catch (System.Exception e)
        {
            return Problem(e.Message);
        }
    }

    [HttpPut]
    [Route("{id:guid}")]
    public IActionResult UpdateStatus()
    {
        try
        {
        
            return Ok();
        }
        catch (System.Exception e)
        {
            return Problem(e.Message);
        }
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public IActionResult DeleteStatus()
    {
        try
        {
        
            return Ok();
        }
        catch (System.Exception e)
        {
            return Problem(e.Message);
        }
    }
    
}
