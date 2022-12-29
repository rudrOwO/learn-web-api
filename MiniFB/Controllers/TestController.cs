using Microsoft.AspNetCore.Mvc;

namespace learn_web_api.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
     
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("TESTING");
    }
}
