using Microsoft.AspNetCore.Mvc;

namespace IronLeg.Presentation.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TaskController : Controller 
  {
    [HttpGet("")]
    public IActionResult TestEndpoint()
    {
      return Ok("Testing the build");
    }
  } 
}
