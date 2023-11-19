using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class Studios_Values_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "52bdbd06-a971-4a93-9b5a-98a6ceb81c27");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "089bfff7-5fc4-457c-b63f-65b860ce7f5f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "10721950-4c72-4750-90d8-fb2f1fb29741");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1078aa23-a08c-4852-bca8-064185ebd18b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1351fc00-1488-48ae-bc60-a2a0fcbd512a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "25f02099-461e-445a-92b4-a3f46dcccde8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2754cb7d-f8fd-4fb2-9468-e48dfcb914b4");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2ba54d44-3f4b-4084-a7e7-ca7eb3743d84");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "39f7698a-768d-4972-bd0c-e947d433e31f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3c5e37e1-62e6-497d-b705-791556e50e0f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "46050e5f-7875-434e-82d3-b59556312de8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5e05cd0b-0615-48a9-974e-7af2cc9ec4bd");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "61cd55c6-4a5e-4ff6-bddb-a4e3a86980ee");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "691dc219-3463-4d1a-b887-8574bdd6eae5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "721f515e-a213-47bc-8000-a65f900af13f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "73dc74b1-f997-4b32-bfa5-e93994660016");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7b302064-4685-489a-ba8d-8b859743f208");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8fab579a-332e-45f1-b748-313ad1f4f9f6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ae94423c-f1f3-48eb-b95c-76ddea922183");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "c8447167-cff6-4ce0-ad3d-9f83baf34cf7");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "dbaa7a3c-bc39-4792-b69a-4e8916c25a80");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e3ee77fc-f667-46fb-b0f7-08b3231c4f59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3032f327-4d04-477c-9ffe-30db909028d9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a35a4439-7d92-4008-892d-628889268e41");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "16b21ae5-10d2-44e2-9383-3ce0070f552e", 0, "7eb11b50-36ba-4bd8-8bb1-54a973e0307f", "AppUser", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEPYfdlE5ZM7Ggk9R7yQVvN5DdK30NTu25cBQYkEXBmpNPclF3fBwHIgh/QjJwkwHGg==", null, false, null, null, "816b9d64-0b5f-42f1-81a3-5830a040a617", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "09c45af2-202a-400d-96ca-5549c0f5d9da", "~/logos_in_svg/mojang", 12 },
                    { "119d4e3a-8800-4f70-9558-2d3749973f61", "~/logos_in_svg/paradox-interactive", 14 },
                    { "2022bd87-44a3-40bb-ad3d-33b147af1177", "~/logos_in_svg/ubisoft", 20 },
                    { "263f859a-b25c-4aaa-bb09-2af03afacd28", "~/logos_in_svg/cd-projekt", 5 },
                    { "29f044e3-e817-46ba-a11c-171d439f77b5", "~/logos_in_svg/blizzard", 2 },
                    { "4e0b5f38-03b1-4339-9411-0b44413a99f0", "~/logos_in_svg/sony", 18 },
                    { "53dc4157-3236-4fd5-a026-613123c238ce", "~/logos_in_svg/rockstar-games", 16 },
                    { "5965d9be-acea-4714-9ce6-8bddce74ca2d", "~/logos_in_svg/nintendo", 13 },
                    { "878296be-6ebf-4e02-b73f-b15e247b1cf3", "~/logos_in_svg/insomniac-games", 10 },
                    { "93581f26-1f66-41a7-9a6b-1e30d3370121", "~/logos_in_svg/capcom", 4 },
                    { "97b85443-076f-4489-afbd-6e0cb9c2e018", "~/logos_in_svg/crystal", 6 },
                    { "9dc06029-b6d3-408c-9c56-6bc7a7a39142", "~/logos_in_svg/bluehole", 3 },
                    { "a5aeb464-52df-4782-996d-c13178d5e05d", "~/logos_in_svg/microsoft", 11 },
                    { "ab253513-3277-4f48-afe2-d4e0d3e85a53", "~/logos_in_svg/valve", 21 },
                    { "b086af6c-0c06-4455-9693-eab96998de3f", "~/logos_in_svg/remedy-entertainment", 15 },
                    { "b7e4e0d4-bcfa-4a0a-b043-17e57cb1f4ea", "~/logos_in_svg/sega", 17 },
                    { "cc83fb31-7928-414c-923b-b42497e4f107", "~/logos_in_svg/square-enix", 19 },
                    { "e46ae75c-d060-495d-b1bd-d47def941f3c", "~/logos_in_svg/electronic-arts", 7 },
                    { "e56b5b66-5293-466b-88ce-e6987fccd6a2", "~/logos_in_svg/bethesda", 1 },
                    { "fbb9d013-4cc8-4d0d-a90e-905eea52f0d9", "~/logos_in_svg/firaxis-games", 9 },
                    { "fc60b6f3-2546-48fd-82a9-44385f6710ee", "~/logos_in_svg/epic-games", 8 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ContentType", "Description", "OwnerId", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "fa4ad9f9-7649-4dc0-a75f-dbfcc2bf2b17", null, "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "16b21ae5-10d2-44e2-9383-3ce0070f552e", null, 9, "53dc4157-3236-4fd5-a026-613123c238ce", "Grand Theft Auto V" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "fa4ad9f9-7649-4dc0-a75f-dbfcc2bf2b17");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "09c45af2-202a-400d-96ca-5549c0f5d9da");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "119d4e3a-8800-4f70-9558-2d3749973f61");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2022bd87-44a3-40bb-ad3d-33b147af1177");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "263f859a-b25c-4aaa-bb09-2af03afacd28");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "29f044e3-e817-46ba-a11c-171d439f77b5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4e0b5f38-03b1-4339-9411-0b44413a99f0");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5965d9be-acea-4714-9ce6-8bddce74ca2d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "878296be-6ebf-4e02-b73f-b15e247b1cf3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "93581f26-1f66-41a7-9a6b-1e30d3370121");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "97b85443-076f-4489-afbd-6e0cb9c2e018");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9dc06029-b6d3-408c-9c56-6bc7a7a39142");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a5aeb464-52df-4782-996d-c13178d5e05d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ab253513-3277-4f48-afe2-d4e0d3e85a53");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b086af6c-0c06-4455-9693-eab96998de3f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b7e4e0d4-bcfa-4a0a-b043-17e57cb1f4ea");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cc83fb31-7928-414c-923b-b42497e4f107");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e46ae75c-d060-495d-b1bd-d47def941f3c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e56b5b66-5293-466b-88ce-e6987fccd6a2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fbb9d013-4cc8-4d0d-a90e-905eea52f0d9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fc60b6f3-2546-48fd-82a9-44385f6710ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16b21ae5-10d2-44e2-9383-3ce0070f552e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "53dc4157-3236-4fd5-a026-613123c238ce");

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
        }
    }
}
