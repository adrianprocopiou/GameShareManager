using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class SetPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resource.Language))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmNewPassword", ResourceType = typeof(Resource.Language))]
        [Compare("NewPassword", ErrorMessageResourceName = "NewPasswordAndConfirmPasswordDontMatchError", ErrorMessageResourceType = typeof(Resource.Language))]
        public string ConfirmPassword { get; set; }
    }
}