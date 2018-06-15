using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resource.Language))]
        public string Email { get; set; }
    }
}