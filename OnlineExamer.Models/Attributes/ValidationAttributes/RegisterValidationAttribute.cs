namespace OnlineExamer.Models.Attributes.ValidationAttributes
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    using OnlineExamer.Models.Authentication;

    public class RegisterValidationAttribute : ValidationAttribute
    {
        private const string InvalidInputErrorMessage = @"Е-пощата е невалидна!";

        public RegisterValidationAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (RegisterModel)value;
            var regex = new Regex(@"^[A-Za-z0-0-_]+[\d]*@[a-z]+\.[a-z]+$");

            if(!regex.IsMatch(model.Email) ||
                model.FullName.Length <= 0 ||
                model.Password.Length <= 0 || 
                model.Password != model.ConfirmPassword)
            {
                return new ValidationResult(InvalidInputErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
