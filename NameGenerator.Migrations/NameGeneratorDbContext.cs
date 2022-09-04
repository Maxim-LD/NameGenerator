using Microsoft.EntityFrameworkCore;
using NameGenerator.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Migrations
{
    public class NameGeneratorDbContext: DbContext
    {
        public NameGeneratorDbContext(DbContextOptions<NameGeneratorDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedProfile>().ToTable("BasicProfile");
        }

        public DbSet<DetailedProfile> DetailedProfiles { get; set; }
    }
}
