using System.Data.Entity;
using GameShareManager.Data.Configurations;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Data.Context
{
    public class GameShareManagerContext : BaseDbContext
    {
        public GameShareManagerContext() : base("GameShareManager")
        {
        }

        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Friend> Friends { get; set; }
        public IDbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new FriendConfiguration());
            modelBuilder.Configurations.Add(new GameConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}