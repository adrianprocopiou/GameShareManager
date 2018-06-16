using System;

namespace GameShareManager.Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string OwnerUserId { get; set; }
    }
}