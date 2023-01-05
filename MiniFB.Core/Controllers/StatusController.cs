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
    public IActionResult CreateStatus(CreateStatusRequest request)
    {
        try
        {
            var newStatus = new Status(request.Content);
            _statusService.CreateStatus(newStatus);

            return Ok(
                new StatusResponse (
                   Id: newStatus.Id,
                   Content: newStatus.Content,
                   CreatedAt: newStatus.CreatedAt
                )
            );
        }
        catch (System.Exception e)
        {
            return Problem(e.Message);
        }
    }

    [HttpGet]
    [Route("{id:guid}")]
    public IActionResult GetStatus(Guid id)
    {
        try
        {
            var retreivedStatus =_statusService.GetStatus(id);
            return Ok(
                new StatusResponse (
                   Id: retreivedStatus.Id,
                   Content: retreivedStatus.Content,
                   CreatedAt: retreivedStatus.CreatedAt
                )
            );
        }
        catch (System.Exception e)
        {
            return Problem(e.Message);
        }
    }

    [HttpPut]
    [Route("{id:guid}")]
    public IActionResult UpdateStatus(Guid id, UpdateStatusRequest request)
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
