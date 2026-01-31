using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi3.Controllers
{
    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var laptop = new Entities.Laptop();
            var model = laptop.GetModel();
            return Ok(model);
        }
    }
}
