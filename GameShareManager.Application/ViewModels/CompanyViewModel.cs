using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameShareManager.Resource;

namespace GameShareManager.Application.ViewModels
{
    public class CompanyViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Name",ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "RequiredFieldError")]
        public string Name { get; set; }
    }
}