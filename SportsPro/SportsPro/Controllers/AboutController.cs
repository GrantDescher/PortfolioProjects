using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class AboutController : Controller
    {
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}
