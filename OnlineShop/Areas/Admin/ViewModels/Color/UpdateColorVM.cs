﻿using OnlineShop.DAL;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Areas.Admin.ViewModels
{
    public class UpdateColorVM
    {
        [Required(ErrorMessage = "Ad mutleq daxil edilmelidir")]
        [MaxLength(25, ErrorMessage = "Uzunlug max 25 olmalidir")]
        public string Name { get; set; }



    }
}