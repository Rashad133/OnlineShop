using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
