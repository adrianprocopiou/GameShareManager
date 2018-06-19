using System;
using System.ComponentModel.DataAnnotations;
using GameShareManager.Resource;

namespace GameShareManager.Application.ViewModels
{
    public class LoanViewModel
    {
        [Display(Name = "Game", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "RequiredFieldError")]
        public Guid GameId { get; set; }
        [Display(Name = "Friend", ResourceType = typeof(Language))]
        [Required(ErrorMessageResourceType = typeof(Language), ErrorMessageResourceName = "RequiredFieldError")]
        public Guid FriendId { get; set; }
    }
}