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
    [Migration("20240131223623_asd")]
    partial class asd
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
                            Id = "4296015a-db0e-4d85-9359-ca78103dcc8d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b07202ec-9f7a-4381-8b47-23d53fcc071a",
                            Email = "keny.gergo@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Kenyeres",
                            LastName = "Gergő",
                            LockoutEnabled = false,
                            NormalizedUserName = "KENY.GERGO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEINih/wkWjqc7MR/jYpSMNGxM/IkwoJSgd9ES1aAyaE681LMn5ud9whU7wM2UYkUig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6985b8ea-8dea-4465-9316-fdc07f80c140",
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
                            Id = "fdb037bc-b9f3-4716-8e6c-7bc001ea5fae",
                            Description = "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...",
                            OwnerId = "4296015a-db0e-4d85-9359-ca78103dcc8d",
                            PhotoContentType = "image/jpeg",
                            PhotoData = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            Rating = 9,
                            StudiosId = "7b659668-3adc-44c1-acc9-c2be518e21e7",
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
                            Id = "96857615-b33e-49bc-8cec-2b4c6f281562",
                            LogoSvg = "~/logos_in_svg/bethesda",
                            Name = 1
                        },
                        new
                        {
                            Id = "2ddbb209-490e-409a-a84a-68999b44c249",
                            LogoSvg = "~/logos_in_svg/blizzard",
                            Name = 2
                        },
                        new
                        {
                            Id = "e9c2a600-76b6-484c-856a-7d1c6592d5e1",
                            LogoSvg = "~/logos_in_svg/bluehole",
                            Name = 3
                        },
                        new
                        {
                            Id = "cb659961-530b-4fc9-a847-d4fb832a0b1a",
                            LogoSvg = "~/logos_in_svg/capcom",
                            Name = 4
                        },
                        new
                        {
                            Id = "8bcbe153-7e65-487b-8177-ec71ddb11fa2",
                            LogoSvg = "~/logos_in_svg/cd-projekt",
                            Name = 5
                        },
                        new
                        {
                            Id = "48106a0a-8cf5-4cfd-b39f-3371bad79aad",
                            LogoSvg = "~/logos_in_svg/crystal",
                            Name = 6
                        },
                        new
                        {
                            Id = "28cb169d-7b8a-4b96-aa03-145ef7bb893f",
                            LogoSvg = "~/logos_in_svg/electronic-arts",
                            Name = 7
                        },
                        new
                        {
                            Id = "0dda331f-6b84-4097-ac42-bbd8998b74c3",
                            LogoSvg = "~/logos_in_svg/epic-games",
                            Name = 8
                        },
                        new
                        {
                            Id = "aec2bc60-a7f1-4fe8-9262-278fc66c9ef0",
                            LogoSvg = "~/logos_in_svg/firaxis-games",
                            Name = 9
                        },
                        new
                        {
                            Id = "8343f066-3d7c-4698-822f-1dabcdd6d706",
                            LogoSvg = "~/logos_in_svg/insomniac-games",
                            Name = 10
                        },
                        new
                        {
                            Id = "1670b9e7-3d31-4f6c-a32e-e94313d26edf",
                            LogoSvg = "~/logos_in_svg/microsoft",
                            Name = 11
                        },
                        new
                        {
                            Id = "b1b51cfc-6fd8-4d97-b0e5-1c57a3266244",
                            LogoSvg = "~/logos_in_svg/mojang",
                            Name = 12
                        },
                        new
                        {
                            Id = "3ae07a48-b9ea-4d63-81d8-eb086e3d6772",
                            LogoSvg = "~/logos_in_svg/nintendo",
                            Name = 13
                        },
                        new
                        {
                            Id = "67ff805f-a788-4d90-905f-872a77f1fb2f",
                            LogoSvg = "~/logos_in_svg/paradox-interactive",
                            Name = 14
                        },
                        new
                        {
                            Id = "7738fb0d-1c83-4f65-8eb2-4337864f6f0f",
                            LogoSvg = "~/logos_in_svg/remedy-entertainment",
                            Name = 15
                        },
                        new
                        {
                            Id = "7b659668-3adc-44c1-acc9-c2be518e21e7",
                            LogoSvg = "~/logos_in_svg/rockstar-games",
                            Name = 16
                        },
                        new
                        {
                            Id = "cbf09055-ed7a-47ec-ac64-7d306fd04507",
                            LogoSvg = "~/logos_in_svg/sega",
                            Name = 17
                        },
                        new
                        {
                            Id = "8cb8ff53-6634-4896-9d85-a206d82c34df",
                            LogoSvg = "~/logos_in_svg/sony",
                            Name = 18
                        },
                        new
                        {
                            Id = "01208655-1046-4b6b-984f-712729366fe9",
                            LogoSvg = "~/logos_in_svg/square-enix",
                            Name = 19
                        },
                        new
                        {
                            Id = "9e898228-fe8b-4405-b12a-c4e29b56f7a8",
                            LogoSvg = "~/logos_in_svg/ubisoft",
                            Name = 20
                        },
                        new
                        {
                            Id = "eee6028f-8f30-480b-8680-9abe2ea6ad05",
                            LogoSvg = "~/logos_in_svg/valve",
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