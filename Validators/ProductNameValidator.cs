using System.ComponentModel.DataAnnotations;

namespace FirstAppBlazor.Validators
{
    public class ProductNameValidator: ValidationAttribute
    {
        public ProductNameValidator() 
        {
            ErrorMessage = "Le nom de votre produit doit commencer par une majuscule !";
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value is string name)
            {
                if(string.IsNullOrEmpty(name) || !char.IsUpper(name[0]))
                {
                    return new ValidationResult($"Le nom du produit '{name}' doit commencer par une majuscule.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
