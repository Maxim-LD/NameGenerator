using Microsoft.EntityFrameworkCore;
using NameGenerator.Model.Entity;

namespace NameGenerator.Migrations
{
    public class NameGeneratorDbContext: DbContext
    {
        public NameGeneratorDbContext(DbContextOptions<NameGeneratorDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedProfile>().ToTable("DetailedProfile");
        }

        public DbSet<DetailedProfile> DetailedProfiles { get; set; }
    }
}
