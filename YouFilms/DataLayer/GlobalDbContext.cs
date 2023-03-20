using Microsoft.EntityFrameworkCore;
using YouFilms.DataLayer.Configurations;
using YouFilms.Models;

namespace YouFilms.DataLayer
{
    public class GlobalDbContext : DbContext
    {
        public GlobalDbContext (DbContextOptions<GlobalDbContext> options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Film> Films { get; set; }

        public DbSet<Review> Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FilmConfiguration());
        }
    }
}
