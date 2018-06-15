using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [Display(Name = "Code", ResourceType = typeof(Resources.Language))]
        public string Code { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [Phone]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Language))]
        public string PhoneNumber { get; set; }
    }
}