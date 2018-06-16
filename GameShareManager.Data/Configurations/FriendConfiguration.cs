using System.Data.Entity.ModelConfiguration;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Data.Configurations
{
    public class FriendConfiguration : EntityTypeConfiguration<Friend>
    {
        public FriendConfiguration()
        {
            HasKey(f => f.Id);

            Property(f => f.Name)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(100);

            Property(f => f.Nickname)
                .IsOptional()
                .IsUnicode(false)
                .HasMaxLength(20);

            Property(f => f.Email)
                .IsOptional()
                .IsUnicode(false)
                .HasMaxLength(100);

            Property(f => f.PhoneNumber)
                .IsOptional()
                .IsUnicode(false)
                .HasMaxLength(20);
        }
    }
}