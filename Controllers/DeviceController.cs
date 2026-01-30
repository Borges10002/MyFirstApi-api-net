using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi3.Controllers
{
    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var devices = new List<string>
            {
                "Device1",
                "Device2",
                "Device3"
            };
            return Ok(devices);
        }
    }
}
