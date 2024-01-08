using OnlineShop.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Areas.Admin.ViewModels
{
    public class UpdateProductVM
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public IFormFile Image { get; set; }

        [Required]
        public int? CategoryId { get; set; }

        public List<Category>? Categories { get; set; }

        public List<Color>? Colors { get; set; }
        public List<Size>? Sizes { get; set; }


        public List<int> ColorIds { get; set; } 
        public List<int> SizeIds { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
    }
}
