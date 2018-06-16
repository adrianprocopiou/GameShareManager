using System.Collections.Generic;

namespace GameShareManager.Domain.Entities
{
    public class Company : Entity
    {
        public Company()
        {
            Games = new List<Game>();
        }

        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}