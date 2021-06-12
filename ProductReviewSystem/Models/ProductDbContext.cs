using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewSystem.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
             : base(options)
        {

        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>().HasOne(u => u.Product).WithOne(p => p.User);

            // modelBuilder.Entity<User>().HasOne(u => u.Review).WithOne(r => r.User);

            // modelBuilder.Entity<User>().Property(u => u.Id).IsRequired();

            // modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();


            // modelBuilder.Entity<User>().Property(u => u.Email)
            //     .IsRequired()
            //     .HasMaxLength(40);

            // modelBuilder.Entity<Product>().HasKey(r => r.UserId);


            // modelBuilder.Entity<Product>().HasIndex(r => r.UserId).IsUnique();

            // modelBuilder.Entity<Review>().HasKey(p => p.UserId);

            // modelBuilder.Entity<Review>().HasIndex(r => r.UserId).IsUnique();

            // modelBuilder.Entity<User>().HasOne(u => u.Role).WithMany(r => r.Users);

            // base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }
        
        // public DbSet<Role> Roles { get; set; }
        
    }
}
