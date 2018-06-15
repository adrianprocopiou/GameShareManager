using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resource.Language))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [StringLength(100, ErrorMessageResourceName = "MinimumStringLenghtError", ErrorMessageResourceType = typeof(Resource.Language), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resource.Language))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resource.Language))]
        [Compare("Password", ErrorMessageResourceName = "PasswordAndConfirmPasswordDontMatchError", ErrorMessageResourceType = typeof(Resource.Language))]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}