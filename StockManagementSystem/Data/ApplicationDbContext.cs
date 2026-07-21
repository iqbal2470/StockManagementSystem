using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
      
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Unit> Units { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.BrandName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                      .HasDefaultValue(true);

                entity.HasIndex(e => e.BrandName)
                      .IsUnique();

            });
            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.UnitName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                      .HasDefaultValue(true);

                entity.HasIndex(e => e.UnitName)
                      .IsUnique();
            });
        }
    }
}
