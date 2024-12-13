using FirstAppBlazor.Models;
using System.ComponentModel.DataAnnotations;

namespace FirstAppBlazor.Validators
{
    public class ProductPriceValidator: ValidationAttribute
    {
        public ProductPriceValidator() 
        {
            ErrorMessage = "Le prix ne peut pas être 10 fois supérieur au stock.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            // Accéder à l'objet contenant le produit (par exemple, Product)
            var product = context.ObjectInstance as Product;
            if (product == null)
            {
                return ValidationResult.Success;
            }

            // Vérifier si le prix est 10 fois supérieur au stock
            if (product.Price > 10 * product.Stock)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
