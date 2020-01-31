using Microsoft.AspNetCore.Mvc;

namespace testBuildEnv.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}