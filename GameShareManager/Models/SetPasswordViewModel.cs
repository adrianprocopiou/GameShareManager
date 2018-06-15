using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class SetPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Language))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmNewPassword", ResourceType = typeof(Resources.Language))]
        [Compare("NewPassword", ErrorMessageResourceName = "NewPasswordAndConfirmPasswordDontMatchError", ErrorMessageResourceType = typeof(Resources.Language))]
        public string ConfirmPassword { get; set; }
    }
}