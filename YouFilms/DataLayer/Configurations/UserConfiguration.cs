using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouFilms.Models;

namespace YouFilms.DataLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Password) 
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.Avatar)
                .HasMaxLength(100);

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(50);

            builder.Property(u => u.FavorGenre)
                 .HasMaxLength(50);

            builder.HasMany(u => u.FavorFilms)
                .WithMany(f => f.Users);
        }
    }
}
