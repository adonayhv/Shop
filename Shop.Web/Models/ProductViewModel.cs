using Shop.Web.Data.Entities;

namespace Shop.Web.Models
{
    using Microsoft.AspNetCore.Http;

    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel: Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

       
    }
}
