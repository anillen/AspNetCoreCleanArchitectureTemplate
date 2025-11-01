using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureTemplate.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index() => NoContent();
}