using Microsoft.AspNet.Mvc;

namespace Backend.Controllers
{
    public class SimpleController : Controller
    {
        public IActionResult Index()
        {
            // some logic
            return Ok();
        }
    }
}