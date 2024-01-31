﻿// <auto-generated />
using System;
using F12XA6_SOF_2023241.Repository.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoContentType")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("PhotoData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f2c3a59b-4474-4829-b423-af5bd15f483b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "440e48d3-d272-47f4-b22e-3b53bc8d7411",
                            Email = "keny.gergo@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kenyeres",
                            LastName = "Gergő",
                            LockoutEnabled = false,
                            NormalizedUserName = "KENY.GERGO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH00A9Qk3iWeNOyNjB4hevfUGRtvSZTssMg/P2cuy4DgAKrcRj07Y2CW4JG1jamvcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2a17db16-2370-46de-a869-a17e97f9b10a",
                            TwoFactorEnabled = false,
                            UserName = "keny.gergo@gmail.com"
                        });
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReactionCounter")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Game", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhotoContentType")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("PhotoData")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("StudiosId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("StudiosId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = "d754f73d-dd44-442f-9ffc-145225a32a9f",
                            Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                            OwnerId = "f2c3a59b-4474-4829-b423-af5bd15f483b",
                            PhotoContentType = "image/jpeg",
                            PhotoData = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Rating = 9,
                            StudiosId = "6a644c81-8f2e-4537-a8f1-3cc9fc928a17",
                            Title = "Grand Theft Auto V"
                        });
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Studios", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoSvg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Studios");

                    b.HasData(
                        new
                        {
                            Id = "7ae459d6-72fd-4f5f-bd90-014d65c6f8e4",
                            LogoSvg = "/wwwroot/logos_in_svg/bethesda",
                            Name = 1
                        },
                        new
                        {
                            Id = "8594736f-07a1-4f9a-a9a5-4f73bd61cead",
                            LogoSvg = "/wwwroot/logos_in_svg/blizzard",
                            Name = 2
                        },
                        new
                        {
                            Id = "4ddd12a2-941b-43fc-ae40-6700e83a0f2d",
                            LogoSvg = "/wwwroot/logos_in_svg/bluehole",
                            Name = 3
                        },
                        new
                        {
                            Id = "808fd4cd-e5a2-4981-a5e4-d28c27b6fe6f",
                            LogoSvg = "/wwwroot/logos_in_svg/capcom",
                            Name = 4
                        },
                        new
                        {
                            Id = "3b296dd5-61ce-4120-a0f1-c7ded34e46ff",
                            LogoSvg = "/wwwroot/logos_in_svg/cd-projekt",
                            Name = 5
                        },
                        new
                        {
                            Id = "d7e084c7-cf21-452a-b70a-872bdf76bd27",
                            LogoSvg = "/wwwroot/logos_in_svg/crystal",
                            Name = 6
                        },
                        new
                        {
                            Id = "4341c405-0e1e-4360-853a-8830a52d3526",
                            LogoSvg = "/wwwroot/logos_in_svg/electronic-arts",
                            Name = 7
                        },
                        new
                        {
                            Id = "5eff9887-9077-499c-b811-ae32ae9acb02",
                            LogoSvg = "/wwwroot/logos_in_svg/epic-games",
                            Name = 8
                        },
                        new
                        {
                            Id = "5f8790f2-5bd8-4816-9f09-3ac13c0e09c9",
                            LogoSvg = "/wwwroot/logos_in_svg/firaxis-games",
                            Name = 9
                        },
                        new
                        {
                            Id = "05c6b65f-12e6-4098-9938-b2f8e0053f0b",
                            LogoSvg = "/wwwroot/logos_in_svg/insomniac-games",
                            Name = 10
                        },
                        new
                        {
                            Id = "fcfc0afa-d357-4698-af09-38fc3a9a6acf",
                            LogoSvg = "/wwwroot/logos_in_svg/microsoft",
                            Name = 11
                        },
                        new
                        {
                            Id = "e545bfc2-16e3-474d-9a9d-eb114d643540",
                            LogoSvg = "/wwwroot/logos_in_svg/mojang",
                            Name = 12
                        },
                        new
                        {
                            Id = "462836c7-bf66-45d4-a4ce-9e94eb09161e",
                            LogoSvg = "/wwwroot/logos_in_svg/nintendo",
                            Name = 13
                        },
                        new
                        {
                            Id = "7fe54e96-401b-4aea-b0b6-76c52dbacb9a",
                            LogoSvg = "/wwwroot/logos_in_svg/paradox-interactive",
                            Name = 14
                        },
                        new
                        {
                            Id = "bcb1a58e-a85d-4740-bcb2-eced8ff68f43",
                            LogoSvg = "/wwwroot/logos_in_svg/remedy-entertainment",
                            Name = 15
                        },
                        new
                        {
                            Id = "6a644c81-8f2e-4537-a8f1-3cc9fc928a17",
                            LogoSvg = "/wwwroot/logos_in_svg/rockstar-games",
                            Name = 16
                        },
                        new
                        {
                            Id = "ceab1b39-fbfc-47f2-8aef-d0caa35cbd5f",
                            LogoSvg = "/wwwroot/logos_in_svg/sega",
                            Name = 17
                        },
                        new
                        {
                            Id = "fd24373e-b274-4016-a4b6-8e739f0d5e1b",
                            LogoSvg = "/wwwroot/logos_in_svg/sony",
                            Name = 18
                        },
                        new
                        {
                            Id = "a5d108e4-68b8-44c1-8902-fc7c2cc53f5f",
                            LogoSvg = "/wwwroot/logos_in_svg/square-enix",
                            Name = 19
                        },
                        new
                        {
                            Id = "4819621b-a6a2-4c52-b3b0-a6ba04452cb8",
                            LogoSvg = "/wwwroot/logos_in_svg/ubisoft",
                            Name = 20
                        },
                        new
                        {
                            Id = "ef3c951a-0a9d-4cf5-8a67-7d329cf542ce",
                            LogoSvg = "/wwwroot/logos_in_svg/valve",
                            Name = 21
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Comment", b =>
                {
                    b.HasOne("F12XA6_SOF_2023241.Models.Game", "Game")
                        .WithMany("Comments")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("F12XA6_SOF_2023241.Models.AppUser", "Owner")
                        .WithMany("Commenst")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Game", b =>
                {
                    b.HasOne("F12XA6_SOF_2023241.Models.AppUser", "Owner")
                        .WithMany("GamesOwned")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F12XA6_SOF_2023241.Models.Studios", "Studios")
                        .WithMany("GamesOwned")
                        .HasForeignKey("StudiosId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Studios");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("F12XA6_SOF_2023241.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("F12XA6_SOF_2023241.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F12XA6_SOF_2023241.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("F12XA6_SOF_2023241.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.AppUser", b =>
                {
                    b.Navigation("Commenst");

                    b.Navigation("GamesOwned");
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Game", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Studios", b =>
                {
                    b.Navigation("GamesOwned");
                });
#pragma warning restore 612, 618
        }
    }
}
