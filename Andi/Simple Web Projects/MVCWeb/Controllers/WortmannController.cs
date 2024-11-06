using Microsoft.AspNetCore.Mvc;

namespace MVCWeb.Controllers
{
    public class WortmannController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int z1, int z2)
        {
            return View(z1+z2);
        }
    }
}
