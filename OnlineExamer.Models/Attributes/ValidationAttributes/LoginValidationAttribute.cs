namespace OnlineExamer.Models.Attributes.ValidationAttributes
{
    using System.ComponentModel.DataAnnotations;

    using OnlineExamer.Models.Authentication;

    public class LoginValidationAttribute : ValidationAttribute
    {
        private const string InvalidInputDataErrorMessage = "Невалидни входни данни!";

        public LoginValidationAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (LoginModel)value;

            if (model?.Email == null ||
                model?.Email.Length < 5 ||
                !model.Email.Contains("@") ||
                model?.Password == null)
            {
                return new ValidationResult(InvalidInputDataErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
