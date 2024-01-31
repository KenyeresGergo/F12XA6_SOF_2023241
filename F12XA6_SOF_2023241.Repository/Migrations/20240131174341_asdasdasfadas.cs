using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class asdasdasfadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "e2901556-63a3-4e96-9609-ba44c80824b9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "021e3552-7f14-45a0-afb3-2bac308a4009");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3589be05-6083-4cc1-99f1-d0bffc84813d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "63f12e03-7a1f-4fef-a75d-373da99b55d4");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "65b7a595-c0d2-4cb0-a2f5-e1fe51e3b405");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6f4bacab-d809-4d00-80af-5df6ec1d6628");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "702b16e2-874c-4d81-83da-cff113d80a0d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "77967129-2fbf-4fce-80d0-e88f65580075");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7ec84c93-9a69-4c1f-8892-5ad350dcb7dc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7fbc9a85-bcd7-417b-bd59-998d9a3e9dd1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8f8bcc67-28ce-4c46-9a80-1c3691171f6e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9977720d-7bd1-437e-96e8-d857f99fc963");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a0644e81-cbea-457a-a66f-5bb630e89363");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "c1ff580e-52a4-422d-bb10-e5826620bcef");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "d6043980-30df-43e1-919a-75d89281aa9f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "d7564995-43a2-4066-9328-fd15d84ebbc7");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "d7bd3799-5069-4e93-8064-1b1d8ef96f7b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "da9823d4-e101-4310-9bef-d81448829c48");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e14c686f-3d57-46c9-8535-08e33a616bba");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e89f09c8-768b-4db6-952f-ec37cd515b69");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f1832627-60f7-4b9f-8bb6-af8b78958471");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9dce373-372c-4b9f-8cf3-ba3b66a4b7b3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "61e5b8bd-c5cc-4672-ba64-1e2e11fb6481");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "606bfb84-7b9f-42a4-8af3-ea15e73cc549", 0, "4d0a8ef4-63c3-4216-95eb-cd6170c64910", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEFPu2lMa6e/Hl5Q/7hciUvVlO71VnK43T55/kGYJzl2X2Vh7oBK/qS59tiYo7uOWkg==", null, false, null, null, "38e0d842-3497-4f1e-b982-46509b4543dd", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "0b936dbf-4abd-423c-a128-bcc7d7f48b33", "/wwwroot/logos_in_svg/valve", 21 },
                    { "0f4e097c-def8-4cdf-a2ae-b7fc01c92171", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "304d91eb-0a1e-4933-82b5-35048632b1b3", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "39df331d-f858-44e5-92f3-a682b653bad9", "/wwwroot/logos_in_svg/microsoft", 11 },
                    { "421fea40-a79a-4d9a-b31a-3d221b5df5bc", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "5b426e5b-34d5-439b-8864-d9a9bec50682", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "5c16ecdd-594a-458b-b951-f65fd0032b3b", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "6d98020b-d6db-4c92-8a94-d9e820558d2d", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "6f6a6d2b-75f4-45d5-b4a2-2b21cf37258a", "/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "772ac4c4-f365-4bd0-b0ef-c0a75a305e43", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "7a9d2b8f-4440-495f-bf91-70ddd4467214", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "7ad32820-ec54-4467-b106-08d684240cb6", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "9b3d4af6-3096-4297-8bcd-0b3b0fa5970b", "/wwwroot/logos_in_svg/sega", 17 },
                    { "a954963f-47d0-4f35-af47-f6a022354f3e", "/wwwroot/logos_in_svg/nintendo", 13 },
                    { "a9e00120-7605-49d3-af70-89cabc69c26b", "/wwwroot/logos_in_svg/bluehole", 3 },
                    { "ae70e57c-2ecb-43e7-a24e-e704df5e3240", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "bf9f7f21-d8d7-476e-8d8d-12172213af99", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "da379d3c-e8f5-4277-84c7-666ad357f8ac", "/wwwroot/logos_in_svg/sony", 18 },
                    { "e0b8c92e-2c3c-429b-94e2-22ab9cf7c6f9", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "e6f5ce5a-85d5-49b3-988d-8fc816e11166", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "f26f6364-2ac1-4c9d-a67c-c1bb3c129321", "/wwwroot/logos_in_svg/blizzard", 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "d706776c-777c-4e37-a9ef-1701609de704", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "606bfb84-7b9f-42a4-8af3-ea15e73cc549", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "6d98020b-d6db-4c92-8a94-d9e820558d2d", "Grand Theft Auto V" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "d706776c-777c-4e37-a9ef-1701609de704");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0b936dbf-4abd-423c-a128-bcc7d7f48b33");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0f4e097c-def8-4cdf-a2ae-b7fc01c92171");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "304d91eb-0a1e-4933-82b5-35048632b1b3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "39df331d-f858-44e5-92f3-a682b653bad9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "421fea40-a79a-4d9a-b31a-3d221b5df5bc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5b426e5b-34d5-439b-8864-d9a9bec50682");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5c16ecdd-594a-458b-b951-f65fd0032b3b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6f6a6d2b-75f4-45d5-b4a2-2b21cf37258a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "772ac4c4-f365-4bd0-b0ef-c0a75a305e43");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7a9d2b8f-4440-495f-bf91-70ddd4467214");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7ad32820-ec54-4467-b106-08d684240cb6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9b3d4af6-3096-4297-8bcd-0b3b0fa5970b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a954963f-47d0-4f35-af47-f6a022354f3e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a9e00120-7605-49d3-af70-89cabc69c26b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ae70e57c-2ecb-43e7-a24e-e704df5e3240");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "bf9f7f21-d8d7-476e-8d8d-12172213af99");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "da379d3c-e8f5-4277-84c7-666ad357f8ac");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e0b8c92e-2c3c-429b-94e2-22ab9cf7c6f9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e6f5ce5a-85d5-49b3-988d-8fc816e11166");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f26f6364-2ac1-4c9d-a67c-c1bb3c129321");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "606bfb84-7b9f-42a4-8af3-ea15e73cc549");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6d98020b-d6db-4c92-8a94-d9e820558d2d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a9dce373-372c-4b9f-8cf3-ba3b66a4b7b3", 0, "81292fc6-2923-42a1-a245-a06f367cf60d", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEA8e+00OhHDf3soKDNq8GWN6+9Y6G82qetFNDpvTOlsD8n+QGLwVNsNu5VsZ/Oqd8w==", null, false, null, null, "94b92d08-fb85-4d07-85c9-c03b9ca1e106", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "021e3552-7f14-45a0-afb3-2bac308a4009", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "3589be05-6083-4cc1-99f1-d0bffc84813d", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "61e5b8bd-c5cc-4672-ba64-1e2e11fb6481", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "63f12e03-7a1f-4fef-a75d-373da99b55d4", "/wwwroot/logos_in_svg/valve", 21 },
                    { "65b7a595-c0d2-4cb0-a2f5-e1fe51e3b405", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "6f4bacab-d809-4d00-80af-5df6ec1d6628", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "702b16e2-874c-4d81-83da-cff113d80a0d", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "77967129-2fbf-4fce-80d0-e88f65580075", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "7ec84c93-9a69-4c1f-8892-5ad350dcb7dc", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "7fbc9a85-bcd7-417b-bd59-998d9a3e9dd1", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "8f8bcc67-28ce-4c46-9a80-1c3691171f6e", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "9977720d-7bd1-437e-96e8-d857f99fc963", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "a0644e81-cbea-457a-a66f-5bb630e89363", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "c1ff580e-52a4-422d-bb10-e5826620bcef", "/wwwroot/logos_in_svg/nintendo", 13 },
                    { "d6043980-30df-43e1-919a-75d89281aa9f", "/wwwroot/logos_in_svg/sony", 18 },
                    { "d7564995-43a2-4066-9328-fd15d84ebbc7", "/wwwroot/logos_in_svg/blizzard", 2 },
                    { "d7bd3799-5069-4e93-8064-1b1d8ef96f7b", "/wwwroot/logos_in_svg/microsoft", 11 },
                    { "da9823d4-e101-4310-9bef-d81448829c48", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "e14c686f-3d57-46c9-8535-08e33a616bba", "/wwwroot/logos_in_svg/bluehole", 3 },
                    { "e89f09c8-768b-4db6-952f-ec37cd515b69", "/wwwroot/logos_in_svg/sega", 17 },
                    { "f1832627-60f7-4b9f-8bb6-af8b78958471", "/wwwroot/logos_in_svg/firaxis-games", 9 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "e2901556-63a3-4e96-9609-ba44c80824b9", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "a9dce373-372c-4b9f-8cf3-ba3b66a4b7b3", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "61e5b8bd-c5cc-4672-ba64-1e2e11fb6481", "Grand Theft Auto V" });
        }
    }
}
