using Microsoft.AspNetCore.Mvc;
using SportsPro.Models.DataAccess;

namespace SportsPro.Controllers
{
    public class HomeController : Controller
    {
        private SportsProContext context { get; set; }

        public HomeController(SportsProContext ctx) => context = ctx;

        public IActionResult Index()
        {
            return View();
        }
    }
}