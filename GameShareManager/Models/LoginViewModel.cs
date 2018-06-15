using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [Display(Name = "Email", ResourceType = typeof(Resource.Language))]
        [System.ComponentModel.DataAnnotations.EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resource.Language))]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resource.Language))]
        public string Password { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(Resource.Language))]
        public bool RememberMe { get; set; }
    }
}