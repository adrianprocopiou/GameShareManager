using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [Display(Name = "Email", ResourceType = typeof(Resource.Language))]
        public string Email { get; set; }
    }
}