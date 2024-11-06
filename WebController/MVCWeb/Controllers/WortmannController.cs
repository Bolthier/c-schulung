using Microsoft.AspNetCore.Mvc;

namespace MVCWeb.Controllers
{
    public class WortmannController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
