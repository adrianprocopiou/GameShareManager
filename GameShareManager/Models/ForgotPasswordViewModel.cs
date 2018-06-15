using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Resources.Language))]
        public string Email { get; set; }
    }
}