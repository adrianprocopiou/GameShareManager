using System;

namespace GameShareManager.Application.ViewModels
{
    public class GameViewModel
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? FriendId { get; set; }
        public string CompanyName { get; set; }
        public string FriendName { get; set; }
        public string FriendEmail { get; set; }
        public string FriendPhoneNumber { get; set; }
        public string FriendNickname { get; set; }
    }
}