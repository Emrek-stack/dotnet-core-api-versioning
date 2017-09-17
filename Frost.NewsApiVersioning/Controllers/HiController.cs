using Microsoft.AspNetCore.Mvc;

namespace Frost.V1Hi.Controllers
{

    public class HiController : Controller
    {
        [Route("~/api/v1/Hi")] // Attribute routing  
        [HttpGet]
        public IActionResult Get() => Content("Hi Version 1");
    }
}

namespace Frost.V2Hi.Controllers
{
    public class HiController : Controller
    {
        [Route("~/api/v2/Hi")]// Attribute routing  
        [HttpGet]
        public IActionResult Get() => Content("Hi Version 2");
    }
}