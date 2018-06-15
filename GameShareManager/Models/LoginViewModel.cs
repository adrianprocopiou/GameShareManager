using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [Display(Name = "Email", ResourceType = typeof(Resources.Language))]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Language))]
        public string Password { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(Resources.Language))]
        public bool RememberMe { get; set; }
    }
}