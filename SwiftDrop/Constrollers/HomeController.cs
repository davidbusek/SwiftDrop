using Microsoft.AspNetCore.Mvc;

namespace SwiftDrop.Constrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
