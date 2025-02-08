using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BancoController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Banco Controller is working!");
        }
    }
}