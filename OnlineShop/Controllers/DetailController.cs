using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
