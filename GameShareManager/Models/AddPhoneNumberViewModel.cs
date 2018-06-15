using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [Phone]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resource.Language))]
        public string Number { get; set; }
    }
}