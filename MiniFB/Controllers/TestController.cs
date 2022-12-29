using Microsoft.AspNetCore.Mvc;

namespace learn_web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var add = (int a, int b) => a + b;
        return Ok(add.GetType().ToString());
    }
}
