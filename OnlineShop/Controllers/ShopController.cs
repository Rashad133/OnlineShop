using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
