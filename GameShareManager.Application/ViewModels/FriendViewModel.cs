using System;
using System.ComponentModel.DataAnnotations;
using GameShareManager.Resource;

namespace GameShareManager.Application.ViewModels
{
    public class FriendViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Name", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "RequiredFieldError")]
        [StringLength(100, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaximumStringLenghtError")]
        public string Name { get; set; }

        [Display(Name = "PhoneNumber", ResourceType = typeof(Language))]
        [StringLength(20, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaximumStringLenghtError")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Language))]
        [StringLength(100, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaximumStringLenghtError")]
        public string Email { get; set; }

        [Display(Name = "Nickname", ResourceType = typeof(Language))]
        [StringLength(20, ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "MaximumStringLenghtError")]
        public string Nickname { get; set; }
    }
}