using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resources.Language))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [StringLength(100, ErrorMessageResourceName = "MinimumStringLenghtError", ErrorMessageResourceType = typeof(Resources.Language), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Language))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Language))]
        [Compare("Password", ErrorMessageResourceName = "PasswordAndConfirmPasswordDontMatchError", ErrorMessageResourceType = typeof(Resources.Language))]
        public string ConfirmPassword { get; set; }
    }
}
