using F12XA6_SOF_2023241.Webapp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F12XA6_SOF_2023241.Webapp.Data
{
    public class AppDbContext : IdentityDbContext
    {
       public DbSet<Game> Games { get; set; }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
              new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
              new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }

            builder.Entity<Game>()
                .HasOne(t => t.Owner)
                .WithMany()
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}
