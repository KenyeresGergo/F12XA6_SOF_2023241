using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class Studios_Key_Erros_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "5ebd2234-49d3-4853-b944-ec16e8c0fa8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ad1073-6758-4bc8-af99-5723e14a468a");

            migrationBuilder.DropColumn(
                name: "StudioName",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "AspNetUsers",
                newName: "PhotoData");

            migrationBuilder.AddColumn<string>(
                name: "StudiosId",
                table: "Games",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    LogoSvg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3032f327-4d04-477c-9ffe-30db909028d9", 0, "a8c29b77-040a-478e-950c-9d540eedbb7c", "AppUser", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEIA+mnUUSO96EfKPryu5KQR3DXoC5YUP4/AI6Mt8VO5cKGrX5e7peAm6Tp7jrmef9Q==", null, false, null, null, "3de27807-e330-422d-a7dc-308c4b57e994", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "089bfff7-5fc4-457c-b63f-65b860ce7f5f", "~/logos_in_svg/sony", 18 },
                    { "10721950-4c72-4750-90d8-fb2f1fb29741", "~/logos_in_svg/mojang", 12 },
                    { "1078aa23-a08c-4852-bca8-064185ebd18b", "~/logos_in_svg/electronic-arts", 7 },
                    { "1351fc00-1488-48ae-bc60-a2a0fcbd512a", "~/logos_in_svg/crystal", 6 },
                    { "25f02099-461e-445a-92b4-a3f46dcccde8", "~/logos_in_svg/blizzard", 2 },
                    { "2754cb7d-f8fd-4fb2-9468-e48dfcb914b4", "~/logos_in_svg/ubisoft", 20 },
                    { "2ba54d44-3f4b-4084-a7e7-ca7eb3743d84", "~/logos_in_svg/square-enix", 19 },
                    { "39f7698a-768d-4972-bd0c-e947d433e31f", "~/logos_in_svg/paradox-interactive", 14 },
                    { "3c5e37e1-62e6-497d-b705-791556e50e0f", "~/logos_in_svg/activision", 22 },
                    { "46050e5f-7875-434e-82d3-b59556312de8", "~/logos_in_svg/bethesda", 1 },
                    { "5e05cd0b-0615-48a9-974e-7af2cc9ec4bd", "~/logos_in_svg/valve", 21 },
                    { "61cd55c6-4a5e-4ff6-bddb-a4e3a86980ee", "~/logos_in_svg/capcom", 4 },
                    { "691dc219-3463-4d1a-b887-8574bdd6eae5", "~/logos_in_svg/firaxis-games", 9 },
                    { "721f515e-a213-47bc-8000-a65f900af13f", "~/logos_in_svg/microsoft", 11 },
                    { "73dc74b1-f997-4b32-bfa5-e93994660016", "~/logos_in_svg/remedy-entertainment", 15 },
                    { "7b302064-4685-489a-ba8d-8b859743f208", "~/logos_in_svg/bluehole", 3 },
                    { "8fab579a-332e-45f1-b748-313ad1f4f9f6", "~/logos_in_svg/insomniac-games", 10 },
                    { "a35a4439-7d92-4008-892d-628889268e41", "~/logos_in_svg/rockstar-games", 16 },
                    { "ae94423c-f1f3-48eb-b95c-76ddea922183", "~/logos_in_svg/nintendo", 13 },
                    { "c8447167-cff6-4ce0-ad3d-9f83baf34cf7", "~/logos_in_svg/sega", 17 },
                    { "dbaa7a3c-bc39-4792-b69a-4e8916c25a80", "~/logos_in_svg/epic-games", 8 },
                    { "e3ee77fc-f667-46fb-b0f7-08b3231c4f59", "~/logos_in_svg/cd-projekt", 5 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ContentType", "Description", "OwnerId", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "52bdbd06-a971-4a93-9b5a-98a6ceb81c27", null, "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "3032f327-4d04-477c-9ffe-30db909028d9", null, 9, "a35a4439-7d92-4008-892d-628889268e41", "Grand Theft Auto V" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_StudiosId",
                table: "Games",
                column: "StudiosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studios_StudiosId",
                table: "Games",
                column: "StudiosId",
                principalTable: "Studios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studios_StudiosId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DropIndex(
                name: "IX_Games_StudiosId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "52bdbd06-a971-4a93-9b5a-98a6ceb81c27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3032f327-4d04-477c-9ffe-30db909028d9");

            migrationBuilder.DropColumn(
                name: "StudiosId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "PhotoData",
                table: "AspNetUsers",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "StudioName",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a0ad1073-6758-4bc8-af99-5723e14a468a", 0, "d05b9859-e414-4ca5-a3a9-78ae7053e7e0", null, "AppUser", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEDkQuWIFKHm6bm0pQsyURryk2VcdOzNKM9R7t5xf/bkamxLcwt4n5wqdA4al3VyNsQ==", null, false, null, "02f85e16-9ea3-4086-989d-9f321e941792", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ContentType", "Description", "OwnerId", "PhotoData", "Rating", "StudioName", "Title" },
                values: new object[] { "5ebd2234-49d3-4853-b944-ec16e8c0fa8b", null, "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "a0ad1073-6758-4bc8-af99-5723e14a468a", null, 9, 0, "Grand Theft Auto V" });
        }
    }
}
