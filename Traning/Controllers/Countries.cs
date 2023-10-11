using Microsoft.AspNetCore.Mvc;

namespace Traning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class Countries : ControllerBase

    {

        [MapToApiVersion("1.0")]

        [HttpGet]
        public IActionResult GetAllV1()
        {
            return Ok("HELLO v1");
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        //[Authorize(Roles = "Reader")]
        public IActionResult GetAllV2()
        {
            return Ok("HELLO v2");
        }
    }
}
