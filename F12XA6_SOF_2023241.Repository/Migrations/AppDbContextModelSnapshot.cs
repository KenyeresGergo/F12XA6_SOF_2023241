﻿// <auto-generated />
using System;
using F12XA6_SOF_2023241.Repository;
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

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Game", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("Games", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "52bdbd06-a971-4a93-9b5a-98a6ceb81c27",
                            Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                            OwnerId = "3032f327-4d04-477c-9ffe-30db909028d9",
                            Rating = 9,
                            StudiosId = "a35a4439-7d92-4008-892d-628889268e41",
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

                    b.ToTable("Studios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "46050e5f-7875-434e-82d3-b59556312de8",
                            LogoSvg = "~/logos_in_svg/bethesda",
                            Name = 1
                        },
                        new
                        {
                            Id = "25f02099-461e-445a-92b4-a3f46dcccde8",
                            LogoSvg = "~/logos_in_svg/blizzard",
                            Name = 2
                        },
                        new
                        {
                            Id = "7b302064-4685-489a-ba8d-8b859743f208",
                            LogoSvg = "~/logos_in_svg/bluehole",
                            Name = 3
                        },
                        new
                        {
                            Id = "61cd55c6-4a5e-4ff6-bddb-a4e3a86980ee",
                            LogoSvg = "~/logos_in_svg/capcom",
                            Name = 4
                        },
                        new
                        {
                            Id = "e3ee77fc-f667-46fb-b0f7-08b3231c4f59",
                            LogoSvg = "~/logos_in_svg/cd-projekt",
                            Name = 5
                        },
                        new
                        {
                            Id = "1351fc00-1488-48ae-bc60-a2a0fcbd512a",
                            LogoSvg = "~/logos_in_svg/crystal",
                            Name = 6
                        },
                        new
                        {
                            Id = "1078aa23-a08c-4852-bca8-064185ebd18b",
                            LogoSvg = "~/logos_in_svg/electronic-arts",
                            Name = 7
                        },
                        new
                        {
                            Id = "dbaa7a3c-bc39-4792-b69a-4e8916c25a80",
                            LogoSvg = "~/logos_in_svg/epic-games",
                            Name = 8
                        },
                        new
                        {
                            Id = "691dc219-3463-4d1a-b887-8574bdd6eae5",
                            LogoSvg = "~/logos_in_svg/firaxis-games",
                            Name = 9
                        },
                        new
                        {
                            Id = "8fab579a-332e-45f1-b748-313ad1f4f9f6",
                            LogoSvg = "~/logos_in_svg/insomniac-games",
                            Name = 10
                        },
                        new
                        {
                            Id = "721f515e-a213-47bc-8000-a65f900af13f",
                            LogoSvg = "~/logos_in_svg/microsoft",
                            Name = 11
                        },
                        new
                        {
                            Id = "10721950-4c72-4750-90d8-fb2f1fb29741",
                            LogoSvg = "~/logos_in_svg/mojang",
                            Name = 12
                        },
                        new
                        {
                            Id = "ae94423c-f1f3-48eb-b95c-76ddea922183",
                            LogoSvg = "~/logos_in_svg/nintendo",
                            Name = 13
                        },
                        new
                        {
                            Id = "39f7698a-768d-4972-bd0c-e947d433e31f",
                            LogoSvg = "~/logos_in_svg/paradox-interactive",
                            Name = 14
                        },
                        new
                        {
                            Id = "73dc74b1-f997-4b32-bfa5-e93994660016",
                            LogoSvg = "~/logos_in_svg/remedy-entertainment",
                            Name = 15
                        },
                        new
                        {
                            Id = "a35a4439-7d92-4008-892d-628889268e41",
                            LogoSvg = "~/logos_in_svg/rockstar-games",
                            Name = 16
                        },
                        new
                        {
                            Id = "c8447167-cff6-4ce0-ad3d-9f83baf34cf7",
                            LogoSvg = "~/logos_in_svg/sega",
                            Name = 17
                        },
                        new
                        {
                            Id = "089bfff7-5fc4-457c-b63f-65b860ce7f5f",
                            LogoSvg = "~/logos_in_svg/sony",
                            Name = 18
                        },
                        new
                        {
                            Id = "2ba54d44-3f4b-4084-a7e7-ca7eb3743d84",
                            LogoSvg = "~/logos_in_svg/square-enix",
                            Name = 19
                        },
                        new
                        {
                            Id = "2754cb7d-f8fd-4fb2-9468-e48dfcb914b4",
                            LogoSvg = "~/logos_in_svg/ubisoft",
                            Name = 20
                        },
                        new
                        {
                            Id = "5e05cd0b-0615-48a9-974e-7af2cc9ec4bd",
                            LogoSvg = "~/logos_in_svg/valve",
                            Name = 21
                        },
                        new
                        {
                            Id = "3c5e37e1-62e6-497d-b705-791556e50e0f",
                            LogoSvg = "~/logos_in_svg/activision",
                            Name = 22
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
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

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhotoContentType")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("PhotoData")
                        .HasColumnType("varbinary(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "3032f327-4d04-477c-9ffe-30db909028d9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a8c29b77-040a-478e-950c-9d540eedbb7c",
                            Email = "keny.gergo@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "KENY.GERGO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIA+mnUUSO96EfKPryu5KQR3DXoC5YUP4/AI6Mt8VO5cKGrX5e7peAm6Tp7jrmef9Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3de27807-e330-422d-a7dc-308c4b57e994",
                            TwoFactorEnabled = false,
                            UserName = "keny.gergo@gmail.com",
                            FirstName = "Kenyeres",
                            LastName = "Gergő"
                        });
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
                        .OnDelete(DeleteBehavior.Cascade)
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.Studios", b =>
                {
                    b.Navigation("GamesOwned");
                });

            modelBuilder.Entity("F12XA6_SOF_2023241.Models.AppUser", b =>
                {
                    b.Navigation("GamesOwned");
                });
#pragma warning restore 612, 618
        }
    }
}
