using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Areas.Admin.ViewModels;
using OnlineShop.DAL;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {

            List<Product> products = await _db.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .ToListAsync();

            return View(products);
        }

        //public async Task<IActionResult> Create()
        //{
        //    CreateProductVM productVM = new CreateProductVM
        //    {
        //        Categories = await _db.Categories.ToListAsync(),
        //        Colors = await _db.Colors.ToListAsync(),
        //        Sizes = await _db.Sizes.ToListAsync()
        //    };

        //    return View(productVM);
        //}
    }
}
