using Microsoft.EntityFrameworkCore;
using Mozaika.Data.Models.Core;

namespace Mozaika.Data.Data
{
    public class MozaikaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tile> Tiles { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Mosaic> Mosaics { get; set; }

        public MozaikaContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Mozaika;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}
