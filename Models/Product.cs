using FirstAppBlazor.Validators;
using System.ComponentModel.DataAnnotations;

namespace FirstAppBlazor.Models
{
    public class Product
    {
        [Required]
        [ProductNameValidator]
        public string Name { get; set; }

        [Required]
        [ProductPriceValidator]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 100)]
        public int Stock { get; set; }
    }
}
