using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [DataType(DataType.Password)]
        [Display(Name = "CurrentPassword", ResourceType = typeof(Resources.Language))]
        public string OldPassword { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [StringLength(100, ErrorMessageResourceName = "NewPassword", ErrorMessageResourceType = typeof(Resources.Language),MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Language))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmNewPassword", ResourceType = typeof(Resources.Language))]
        [Compare("NewPassword", ErrorMessageResourceName = "NewPasswordAndConfirmPasswordDontMatchError", ErrorMessageResourceType = typeof(Resources.Language))]
        public string ConfirmPassword { get; set; }
    }
}