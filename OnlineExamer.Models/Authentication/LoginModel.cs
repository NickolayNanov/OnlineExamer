namespace OnlineExamer.Models.Authentication
{
    using System.ComponentModel.DataAnnotations;

    using OnlineExamer.Common;
    using OnlineExamer.Models.Attributes.ValidationAttributes;

    [LoginValidation]
    public class LoginModel
    {
        [Required(ErrorMessage = GlobalConstants.RequiredEmailMessage)]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Е-Поща")]
        public string Email { get; set; }


        [Required(ErrorMessage = GlobalConstants.RequiredPasswordMessage)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }
    }
}
