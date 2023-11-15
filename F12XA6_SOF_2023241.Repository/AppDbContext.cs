using F12XA6_SOF_2023241.Models.Interfaces;
using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F12XA6_SOF_2023241.Repository
{
    public class AppDbContext : IdentityDbContext<IdentityUser>, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
              new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
              new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" }
              );

            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            AppUser gergo = new AppUser
            {
                Email = "keny.gergo@gmail.com",
                EmailConfirmed = true,
                UserName = "keny.gergo@gmail.com",
                FirstName = "Kenyeres",
                LastName = "Gergő",
                NormalizedUserName = "KENY.GERGO@GMAIL.COM"
            };
            gergo.PasswordHash = ph.HashPassword(gergo, "asd123");
            builder.Entity<AppUser>().HasData(gergo);

            builder.Entity<Game>().HasData(new Game()
            {
                Title = "Grand Theft Auto V",
                Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton," +
                " and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                Rating = 9,
                OwnerId = gergo.Id,
                Owner = gergo,

            });

            builder.Entity<Game>()
                .HasOne(t => t.Owner)
                .WithMany()
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}
