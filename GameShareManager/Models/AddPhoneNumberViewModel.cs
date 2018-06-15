using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [Phone]
        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources.Language))]
        public string Number { get; set; }
    }
}