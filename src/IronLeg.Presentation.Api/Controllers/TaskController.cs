using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace IronLeg.Presentation.Api.Controllers
{
  
  [ApiVersion(1)]
  [Route("api/v{v:apiVersion}/[controller]")]
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
