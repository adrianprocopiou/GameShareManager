using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
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
            modelBuilder.Properties()
                .Where(p=>p.Name == "OwnerUserId")
                .Configure(p=> p.HasMaxLength(128));

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new FriendConfiguration());
            modelBuilder.Configurations.Add(new GameConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().IsSubclassOf(typeof(Entity))))
            {
                if(entry.State == EntityState.Added)
                    entry.Property("OwnerUserId").CurrentValue = UserId;
                else if (entry.State == EntityState.Modified)
                    entry.Property("OwnerUserId").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}