using System;

namespace GameShareManager.Domain.Entities
{
    public class Game : Entity
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public Guid FriendId { get; set; }

        public virtual Friend Friend { get; set; }
        public virtual Company Company { get; set; }

    }
}