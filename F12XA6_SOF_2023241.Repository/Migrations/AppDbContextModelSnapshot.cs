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
                            Id = "6f67fd95-fcd1-41ad-be06-9a2e2c2d83f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "157da477-853a-4e63-b86a-13452b9c4f94",
                            Email = "keny.gergo@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kenyeres",
                            LastName = "Gergő",
                            LockoutEnabled = false,
                            NormalizedUserName = "KENY.GERGO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBKbA76hr/3zUyI3Cr09FEjjpejKsTWL0gdiu0OuqvE9DjxoDb9Xyqq/uuhCS5V7pA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "74ded318-4eca-476e-89ba-296141c6f2df",
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
                            Id = "8f1def7f-d48c-4347-be61-7d76cd77d5b6",
                            Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                            OwnerId = "6f67fd95-fcd1-41ad-be06-9a2e2c2d83f7",
                            Rating = 9,
                            StudiosId = "e8ad955f-04a2-48c6-ae01-3d329ab26170",
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
                            Id = "d1393ab6-4f9e-4c33-b5f3-7bcf7cceb634",
                            LogoSvg = "/wwwroot/logos_in_svg/bethesda",
                            Name = 1
                        },
                        new
                        {
                            Id = "ce3c77e1-5bb8-4974-bd9c-17b5a91bc0fe",
                            LogoSvg = "/wwwroot/logos_in_svg/blizzard",
                            Name = 2
                        },
                        new
                        {
                            Id = "3e0e1253-ad9f-4569-9c3c-b63d0dc03dc5",
                            LogoSvg = "/wwwroot/logos_in_svg/bluehole",
                            Name = 3
                        },
                        new
                        {
                            Id = "09dacbf6-56d4-4bc1-8d7a-f7d1aaf0ddc2",
                            LogoSvg = "/wwwroot/logos_in_svg/capcom",
                            Name = 4
                        },
                        new
                        {
                            Id = "8ca1fde9-9c5d-4f01-98c9-1314c75d0b9c",
                            LogoSvg = "/wwwroot/logos_in_svg/cd-projekt",
                            Name = 5
                        },
                        new
                        {
                            Id = "03aa4dea-fa4e-4611-8e33-42b7e4a2f2d5",
                            LogoSvg = "/wwwroot/logos_in_svg/crystal",
                            Name = 6
                        },
                        new
                        {
                            Id = "545889a1-9fbd-45f0-a25a-dbd3605ad6ca",
                            LogoSvg = "/wwwroot/logos_in_svg/electronic-arts",
                            Name = 7
                        },
                        new
                        {
                            Id = "0fdded65-b5f8-4a1e-b4dc-91c78bf1a57a",
                            LogoSvg = "/wwwroot/logos_in_svg/epic-games",
                            Name = 8
                        },
                        new
                        {
                            Id = "1c96fe09-7d10-4cfd-9ab8-f038309ccd05",
                            LogoSvg = "/wwwroot/logos_in_svg/firaxis-games",
                            Name = 9
                        },
                        new
                        {
                            Id = "7af237ee-9625-47fc-ace0-5e7d52d16c7b",
                            LogoSvg = "/wwwroot/logos_in_svg/insomniac-games",
                            Name = 10
                        },
                        new
                        {
                            Id = "4e6e3b13-d009-46ff-b892-f20110e8c584",
                            LogoSvg = "/wwwroot/logos_in_svg/microsoft",
                            Name = 11
                        },
                        new
                        {
                            Id = "9b609dcd-15c2-4168-9f87-889e0a67797d",
                            LogoSvg = "/wwwroot/logos_in_svg/mojang",
                            Name = 12
                        },
                        new
                        {
                            Id = "60c14f38-1538-4463-a326-ab55c11436d8",
                            LogoSvg = "/wwwroot/logos_in_svg/nintendo",
                            Name = 13
                        },
                        new
                        {
                            Id = "43e5e4d4-cda9-42fa-aec0-e53934963e94",
                            LogoSvg = "/wwwroot/logos_in_svg/paradox-interactive",
                            Name = 14
                        },
                        new
                        {
                            Id = "c1d25ab8-4cfa-42fb-8e18-961d00dda974",
                            LogoSvg = "/wwwroot/logos_in_svg/remedy-entertainment",
                            Name = 15
                        },
                        new
                        {
                            Id = "e8ad955f-04a2-48c6-ae01-3d329ab26170",
                            LogoSvg = "/wwwroot/logos_in_svg/rockstar-games",
                            Name = 16
                        },
                        new
                        {
                            Id = "ecf44cc1-cb8b-4a97-88dd-3fe4d9c1ba04",
                            LogoSvg = "/wwwroot/logos_in_svg/sega",
                            Name = 17
                        },
                        new
                        {
                            Id = "214b6031-44cc-4224-a778-3c81e7beaa50",
                            LogoSvg = "/wwwroot/logos_in_svg/sony",
                            Name = 18
                        },
                        new
                        {
                            Id = "542d6d13-014a-4f7e-9723-7a3a2e8f2882",
                            LogoSvg = "/wwwroot/logos_in_svg/square-enix",
                            Name = 19
                        },
                        new
                        {
                            Id = "b48e30cb-7fd5-4253-bb57-eb0f8155000f",
                            LogoSvg = "/wwwroot/logos_in_svg/ubisoft",
                            Name = 20
                        },
                        new
                        {
                            Id = "160ae166-ef32-4723-b1b6-a2defe056bc1",
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
