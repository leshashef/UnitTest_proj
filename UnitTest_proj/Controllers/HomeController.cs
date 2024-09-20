using Microsoft.AspNetCore.Mvc;

namespace UnitTest_proj.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello!";
            return View("Index");
        }
    }
}
