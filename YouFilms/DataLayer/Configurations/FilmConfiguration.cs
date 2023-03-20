using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YouFilms.Models;

namespace YouFilms.DataLayer.Configurations
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name)
                .HasMaxLength(100);

            builder.Property(f => f.Poster)
                 .HasMaxLength(100);

            builder.Property(u => u.Country)
                 .HasMaxLength(50);

            builder.Property(u => u.MPAA)
                 .HasMaxLength(50);

            builder.Property(u => u.Description)
                 .HasMaxLength(300);

            builder.Property(u => u.Director)
                 .HasMaxLength(100);

            builder.HasMany(u => u.Reviews)
                .WithOne(u => u.Film)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
