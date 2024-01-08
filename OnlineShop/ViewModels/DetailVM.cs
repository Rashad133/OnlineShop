using OnlineShop.Models;

namespace OnlineShop.ViewModels
{
    public class DetailVM
    {
        public List<Product> Products { get; set; }
        public List<Product> RelatedProducts { get; set; }
    }
}
