using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SFF_Komplettering;

#nullable disable

namespace SFF_Komplettering.Data
{
    public partial class SFFDbContext : DbContext
    {
        public SFFDbContext()
        {
        }

        public SFFDbContext(DbContextOptions<SFFDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=SFFDb.db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<SFF_Komplettering.Movie> Movie { get; set; }

        public DbSet<SFF_Komplettering.FilmAssociation> FilmAssociation { get; set; }

        public DbSet<SFF_Komplettering.Rental> Rental { get; set; }

        public DbSet<SFF_Komplettering.Review> Review { get; set; }
    }
}
