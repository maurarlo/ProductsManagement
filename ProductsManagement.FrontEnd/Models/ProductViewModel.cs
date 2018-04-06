using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductsManagement.FrontEnd.Models
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Number")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}