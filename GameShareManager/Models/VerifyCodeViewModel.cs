using System.ComponentModel.DataAnnotations;

namespace GameShareManager.Models
{
    public class VerifyCodeViewModel
    {
        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        public string Provider { get; set; }

        [Required(ErrorMessageResourceName = "RequiredFieldError", ErrorMessageResourceType = typeof(Resources.Language))]
        [Display(Name = "Code", ResourceType = typeof(Resources.Language))]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "RememberBrowser", ResourceType = typeof(Resources.Language))]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
}