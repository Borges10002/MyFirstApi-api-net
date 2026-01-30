using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstApiBaseController : ControllerBase
    {
        public string Author { get; set; } = "Diego Borges";
    }
}
