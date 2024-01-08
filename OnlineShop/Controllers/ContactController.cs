using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
