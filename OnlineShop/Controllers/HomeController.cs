using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Models;
using OnlineShop.ViewModels;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Slide> slides = await _db.Slides.OrderBy(s=>s.Order).Take(3).ToListAsync();
            List<Product> products = await _db.Products.Include(p=>p.ProductImages).ToListAsync();
            List<Category> categories = await _db.Categories.ToListAsync(); 

            HomeVM vm = new HomeVM
            {
                Slides= slides,
                Products= products,
                Categories= categories
            };

            return View(vm);
        }
        
    }
}
