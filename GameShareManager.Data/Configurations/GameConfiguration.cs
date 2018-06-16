using System.Data.Entity.ModelConfiguration;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Data.Configurations
{
    public class GameConfiguration : EntityTypeConfiguration<Game>
    {
        public GameConfiguration()
        {
            HasKey(g => g.Id);

            Property(g => g.Name)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(100);

            HasRequired(g => g.Company)
                .WithMany(c=>c.Games)
                .HasForeignKey(g => g.CompanyId);

            HasOptional(g => g.Friend)
                .WithMany(f => f.Games)
                .HasForeignKey(g => g.FriendId);

        }
    }
}