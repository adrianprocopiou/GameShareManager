using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using GameShareManager.Data.Configurations;
using GameShareManager.Domain.Entities;
using Microsoft.AspNet.Identity;

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
            var userId = HttpContext.Current.User.Identity.GetUserId();
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().IsSubclassOf(typeof(Entity)) && entry.State == EntityState.Added))
            {
                entry.Property("OwnerUserId").CurrentValue = userId;
            }
            return base.SaveChanges();
        }
    }
}