using System;

namespace GameShareManager.Domain.Entities
{
    public class Loan
    {
        public Guid FriendId { get; set; }
        public Guid GameId { get; set; }
    }
}