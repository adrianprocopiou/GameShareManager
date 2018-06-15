using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [Display(Name = "Code", ResourceType = typeof(Resource.Language))]
        public string Code { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [Phone]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resource.Language))]
        public string PhoneNumber { get; set; }
    }
}