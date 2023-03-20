using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouFilms.Models;

namespace YouFilms.DataLayer.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Title)
                .HasMaxLength(100);

            builder.Property(r => r.Description)
                 .HasMaxLength(300);

            builder.HasOne(r => r.User)
                .WithMany(u => u.Reviews);

            builder.HasOne(r => r.Film)
                .WithMany(f => f.Reviews);
        }
    }
}
