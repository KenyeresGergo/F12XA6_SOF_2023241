﻿// <auto-generated />
using System;
using F12XA6_SOF_2023241.Repository.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240131174341_asdasdasfadas")]
    partial class asdasdasfadas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = "606bfb84-7b9f-42a4-8af3-ea15e73cc549",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4d0a8ef4-63c3-4216-95eb-cd6170c64910",
                            Email = "keny.gergo@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kenyeres",
                            LastName = "Gergő",
                            LockoutEnabled = false,
                            NormalizedUserName = "KENY.GERGO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFPu2lMa6e/Hl5Q/7hciUvVlO71VnK43T55/kGYJzl2X2Vh7oBK/qS59tiYo7uOWkg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "38e0d842-3497-4f1e-b982-46509b4543dd",
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
                            Id = "d706776c-777c-4e37-a9ef-1701609de704",
                            Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                            OwnerId = "606bfb84-7b9f-42a4-8af3-ea15e73cc549",
                            PhotoContentType = "image/jpeg",
                            PhotoData = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Rating = 9,
                            StudiosId = "6d98020b-d6db-4c92-8a94-d9e820558d2d",
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
                            Id = "772ac4c4-f365-4bd0-b0ef-c0a75a305e43",
                            LogoSvg = "/wwwroot/logos_in_svg/bethesda",
                            Name = 1
                        },
                        new
                        {
                            Id = "f26f6364-2ac1-4c9d-a67c-c1bb3c129321",
                            LogoSvg = "/wwwroot/logos_in_svg/blizzard",
                            Name = 2
                        },
                        new
                        {
                            Id = "a9e00120-7605-49d3-af70-89cabc69c26b",
                            LogoSvg = "/wwwroot/logos_in_svg/bluehole",
                            Name = 3
                        },
                        new
                        {
                            Id = "e6f5ce5a-85d5-49b3-988d-8fc816e11166",
                            LogoSvg = "/wwwroot/logos_in_svg/capcom",
                            Name = 4
                        },
                        new
                        {
                            Id = "7ad32820-ec54-4467-b106-08d684240cb6",
                            LogoSvg = "/wwwroot/logos_in_svg/cd-projekt",
                            Name = 5
                        },
                        new
                        {
                            Id = "bf9f7f21-d8d7-476e-8d8d-12172213af99",
                            LogoSvg = "/wwwroot/logos_in_svg/crystal",
                            Name = 6
                        },
                        new
                        {
                            Id = "421fea40-a79a-4d9a-b31a-3d221b5df5bc",
                            LogoSvg = "/wwwroot/logos_in_svg/electronic-arts",
                            Name = 7
                        },
                        new
                        {
                            Id = "5b426e5b-34d5-439b-8864-d9a9bec50682",
                            LogoSvg = "/wwwroot/logos_in_svg/epic-games",
                            Name = 8
                        },
                        new
                        {
                            Id = "6f6a6d2b-75f4-45d5-b4a2-2b21cf37258a",
                            LogoSvg = "/wwwroot/logos_in_svg/firaxis-games",
                            Name = 9
                        },
                        new
                        {
                            Id = "ae70e57c-2ecb-43e7-a24e-e704df5e3240",
                            LogoSvg = "/wwwroot/logos_in_svg/insomniac-games",
                            Name = 10
                        },
                        new
                        {
                            Id = "39df331d-f858-44e5-92f3-a682b653bad9",
                            LogoSvg = "/wwwroot/logos_in_svg/microsoft",
                            Name = 11
                        },
                        new
                        {
                            Id = "5c16ecdd-594a-458b-b951-f65fd0032b3b",
                            LogoSvg = "/wwwroot/logos_in_svg/mojang",
                            Name = 12
                        },
                        new
                        {
                            Id = "a954963f-47d0-4f35-af47-f6a022354f3e",
                            LogoSvg = "/wwwroot/logos_in_svg/nintendo",
                            Name = 13
                        },
                        new
                        {
                            Id = "e0b8c92e-2c3c-429b-94e2-22ab9cf7c6f9",
                            LogoSvg = "/wwwroot/logos_in_svg/paradox-interactive",
                            Name = 14
                        },
                        new
                        {
                            Id = "304d91eb-0a1e-4933-82b5-35048632b1b3",
                            LogoSvg = "/wwwroot/logos_in_svg/remedy-entertainment",
                            Name = 15
                        },
                        new
                        {
                            Id = "6d98020b-d6db-4c92-8a94-d9e820558d2d",
                            LogoSvg = "/wwwroot/logos_in_svg/rockstar-games",
                            Name = 16
                        },
                        new
                        {
                            Id = "9b3d4af6-3096-4297-8bcd-0b3b0fa5970b",
                            LogoSvg = "/wwwroot/logos_in_svg/sega",
                            Name = 17
                        },
                        new
                        {
                            Id = "da379d3c-e8f5-4277-84c7-666ad357f8ac",
                            LogoSvg = "/wwwroot/logos_in_svg/sony",
                            Name = 18
                        },
                        new
                        {
                            Id = "0f4e097c-def8-4cdf-a2ae-b7fc01c92171",
                            LogoSvg = "/wwwroot/logos_in_svg/square-enix",
                            Name = 19
                        },
                        new
                        {
                            Id = "7a9d2b8f-4440-495f-bf91-70ddd4467214",
                            LogoSvg = "/wwwroot/logos_in_svg/ubisoft",
                            Name = 20
                        },
                        new
                        {
                            Id = "0b936dbf-4abd-423c-a128-bcc7d7f48b33",
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
                        .OnDelete(DeleteBehavior.NoAction)
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