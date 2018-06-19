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
        public Guid? FriendId { get; set; }
        [Display(Name = "Name", ResourceType = typeof(Language))]
        public string FriendName { get; set; }
        [Display(Name = "Nickname", ResourceType = typeof(Language))]
        public string FriendNickname { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Language))]
        public string FriendEmail { get; set; }
        [Display(Name = "PhoneNumber", ResourceType = typeof(Language))]
        public string FriendPhoneNumber { get; set; }

    }
}