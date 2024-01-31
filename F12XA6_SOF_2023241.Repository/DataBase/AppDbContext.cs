﻿using F12XA6_SOF_2023241.Models.Interfaces;
using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F12XA6_SOF_2023241.Repository.DataBase
{


    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Studios> Studios { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
            (
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
                NormalizedUserName = "KENY.GERGO@GMAIL.COM",
                GamesOwned = new List<Game>()
            };
            gergo.PasswordHash = ph.HashPassword(gergo, "asd123");
            builder.Entity<AppUser>().HasData(gergo);

            //Studios data
            var studios = Enum.GetValues(typeof(StudioName))
                .Cast<StudioName>()
                .Select((studio, index) => new Studios((index + 1).ToString())).ToList();
            builder.Entity<Studios>().HasData(studios);

            var game = new Game()
            {
                Title = "Grand Theft Auto V",
                Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton," +
                " and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                Rating = 9,
                OwnerId = gergo.Id,
                //Owner = gergo,
                StudiosId = studios.FirstOrDefault(t => t.Serial_Num == "16").Id,
                //Studios = studios.FirstOrDefault(t => t.Serial_Num == "16") as Studios

            };
            // gergo.GamesOwned.Add(game);
            builder.Entity<Game>().HasData(game);

            builder.Entity<Game>()
                .HasOne(t => t.Owner)
                .WithMany(t => t.GamesOwned)
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Game>()
                .HasOne(t => t.Studios)
                .WithMany(s => s.GamesOwned)
                .HasForeignKey(t => t.StudiosId) // Use a dedicated foreign key property
                .OnDelete(DeleteBehavior.NoAction);


            

            builder.Entity<Comment>()
                .HasOne(c => c.Owner)
                .WithMany(a => a.Commenst)
                .HasForeignKey(c => c.OwnerId)
                .OnDelete(DeleteBehavior.NoAction);

          

            builder.Entity<Comment>()
                .HasOne(c => c.Game)
                .WithMany(g => g.Comments)
                .HasForeignKey(c => c.GameId)
                .OnDelete(DeleteBehavior.NoAction);



            builder.Entity<AppUser>()
              .HasMany(t => t.GamesOwned)
              .WithOne(t => t.Owner)
              .HasForeignKey(t => t.OwnerId)
              .OnDelete(DeleteBehavior.NoAction);
                


            base.OnModelCreating(builder);
        }
    }
}
