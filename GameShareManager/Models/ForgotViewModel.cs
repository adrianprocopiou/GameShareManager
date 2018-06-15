using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class ForgotViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Language))]
        public string Email { get; set; }
    }
}