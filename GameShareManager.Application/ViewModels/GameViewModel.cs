using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using GameShareManager.Resource;

namespace GameShareManager.Application.ViewModels
{
    public class GameViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Name", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "RequiredFieldError")]
        [StringLength(100, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaximumStringLenghtError")]
        public string Name { get; set; }
        [Display(Name = "Company", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "RequiredFieldError")]
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}