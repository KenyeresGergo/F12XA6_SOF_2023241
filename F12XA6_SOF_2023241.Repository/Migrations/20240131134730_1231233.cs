using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class _1231233 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "8f1def7f-d48c-4347-be61-7d76cd77d5b6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "03aa4dea-fa4e-4611-8e33-42b7e4a2f2d5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "09dacbf6-56d4-4bc1-8d7a-f7d1aaf0ddc2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0fdded65-b5f8-4a1e-b4dc-91c78bf1a57a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "160ae166-ef32-4723-b1b6-a2defe056bc1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1c96fe09-7d10-4cfd-9ab8-f038309ccd05");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "214b6031-44cc-4224-a778-3c81e7beaa50");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3e0e1253-ad9f-4569-9c3c-b63d0dc03dc5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "43e5e4d4-cda9-42fa-aec0-e53934963e94");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4e6e3b13-d009-46ff-b892-f20110e8c584");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "542d6d13-014a-4f7e-9723-7a3a2e8f2882");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "545889a1-9fbd-45f0-a25a-dbd3605ad6ca");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "60c14f38-1538-4463-a326-ab55c11436d8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7af237ee-9625-47fc-ace0-5e7d52d16c7b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8ca1fde9-9c5d-4f01-98c9-1314c75d0b9c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9b609dcd-15c2-4168-9f87-889e0a67797d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b48e30cb-7fd5-4253-bb57-eb0f8155000f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "c1d25ab8-4cfa-42fb-8e18-961d00dda974");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ce3c77e1-5bb8-4974-bd9c-17b5a91bc0fe");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "d1393ab6-4f9e-4c33-b5f3-7bcf7cceb634");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ecf44cc1-cb8b-4a97-88dd-3fe4d9c1ba04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f67fd95-fcd1-41ad-be06-9a2e2c2d83f7");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e8ad955f-04a2-48c6-ae01-3d329ab26170");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6f67fd95-fcd1-41ad-be06-9a2e2c2d83f7", 0, "157da477-853a-4e63-b86a-13452b9c4f94", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEBKbA76hr/3zUyI3Cr09FEjjpejKsTWL0gdiu0OuqvE9DjxoDb9Xyqq/uuhCS5V7pA==", null, false, null, null, "74ded318-4eca-476e-89ba-296141c6f2df", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "03aa4dea-fa4e-4611-8e33-42b7e4a2f2d5", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "09dacbf6-56d4-4bc1-8d7a-f7d1aaf0ddc2", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "0fdded65-b5f8-4a1e-b4dc-91c78bf1a57a", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "160ae166-ef32-4723-b1b6-a2defe056bc1", "/wwwroot/logos_in_svg/valve", 21 },
                    { "1c96fe09-7d10-4cfd-9ab8-f038309ccd05", "/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "214b6031-44cc-4224-a778-3c81e7beaa50", "/wwwroot/logos_in_svg/sony", 18 },
                    { "3e0e1253-ad9f-4569-9c3c-b63d0dc03dc5", "/wwwroot/logos_in_svg/bluehole", 3 },
                    { "43e5e4d4-cda9-42fa-aec0-e53934963e94", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "4e6e3b13-d009-46ff-b892-f20110e8c584", "/wwwroot/logos_in_svg/microsoft", 11 },
                    { "542d6d13-014a-4f7e-9723-7a3a2e8f2882", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "545889a1-9fbd-45f0-a25a-dbd3605ad6ca", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "60c14f38-1538-4463-a326-ab55c11436d8", "/wwwroot/logos_in_svg/nintendo", 13 },
                    { "7af237ee-9625-47fc-ace0-5e7d52d16c7b", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "8ca1fde9-9c5d-4f01-98c9-1314c75d0b9c", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "9b609dcd-15c2-4168-9f87-889e0a67797d", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "b48e30cb-7fd5-4253-bb57-eb0f8155000f", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "c1d25ab8-4cfa-42fb-8e18-961d00dda974", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "ce3c77e1-5bb8-4974-bd9c-17b5a91bc0fe", "/wwwroot/logos_in_svg/blizzard", 2 },
                    { "d1393ab6-4f9e-4c33-b5f3-7bcf7cceb634", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "e8ad955f-04a2-48c6-ae01-3d329ab26170", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "ecf44cc1-cb8b-4a97-88dd-3fe4d9c1ba04", "/wwwroot/logos_in_svg/sega", 17 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "8f1def7f-d48c-4347-be61-7d76cd77d5b6", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "6f67fd95-fcd1-41ad-be06-9a2e2c2d83f7", null, null, 9, "e8ad955f-04a2-48c6-ae01-3d329ab26170", "Grand Theft Auto V" });
        }
    }
}
