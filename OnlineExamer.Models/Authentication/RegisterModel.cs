namespace OnlineExamer.Models.Authentication
{ 
    using System.ComponentModel.DataAnnotations;

    using OnlineExamer.Common;

    public class RegisterModel
    {
        [Required(/*ErrorMessage = GlobalConstants.RequiredEmailMessage*/)]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Е-Поща")]
        public string Email { get; set; }


        [Required(/*ErrorMessage = GlobalConstants.RequiredFullNameMessage*/)]
        [MinLength(3)]
        [DataType(DataType.Text)]
        [Display(Name = "Пълно име")]
        public string FullName { get; set; }

        [Required(/*ErrorMessage = GlobalConstants.RequiredPasswordMessage*/)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [Required(/*ErrorMessage = GlobalConstants.RequiredConfirmPasswordNameMessage*/)]
        [DataType(DataType.Password)]
        [Display(Name = "Потвърдете парола")]
        [Compare(nameof(Password), ErrorMessage = GlobalConstants.PasswordsDoesNotmMatchMessage)]
        public string ConfirmPassword { get; set; }
    }
}
