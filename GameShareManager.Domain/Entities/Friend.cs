using System.Collections.Generic;

namespace GameShareManager.Domain.Entities
{
    public class Friend : Entity
    {
        public Friend()
        {
            Games = new List<Game>();
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}