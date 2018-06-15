using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [DataType(DataType.Password)]
        [Display(Name = "CurrentPassword", ResourceType = typeof(Resource.Language))]
        public string OldPassword { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [StringLength(100, ErrorMessageResourceName = "NewPassword", ErrorMessageResourceType = typeof(Resource.Language),MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resource.Language))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmNewPassword", ResourceType = typeof(Resource.Language))]
        [Compare("NewPassword", ErrorMessageResourceName = "NewPasswordAndConfirmPasswordDontMatchError", ErrorMessageResourceType = typeof(Resource.Language))]
        public string ConfirmPassword { get; set; }
    }
}