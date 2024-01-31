using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class _12312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "ac78fd52-7f73-4526-b59e-246e68dbe664");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "024792d4-6d29-49e9-896f-48c76db4f48f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "02fd44ea-e9c9-4dc7-b5a3-9ed22fd7a715");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "05173518-cee3-4227-834f-c354b095d6ee");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "13965842-d8c5-4549-951c-73c6075a6838");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1d127555-420f-4f84-8027-c8ea54f7f563");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "236ee060-7fcb-49f2-84ee-98df2995bd52");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "277e1f48-13c9-4196-a307-0253f1b23af1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2f56368a-f2d8-402b-9ab4-53417e82653f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4cae97bb-c91e-401c-a923-03abc427f77d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "67388d9f-ed4c-4769-ae51-3877080bddf9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7c50efe6-5558-4687-8673-03418107cf51");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7d043eb5-6a3e-4cb4-b0d0-95240487de29");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "895bffbd-2afc-43c2-8978-4fdf00832d99");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8c343efc-66d1-4d14-a249-688864c911f5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b50d5758-9f19-403c-8a40-80f6383351f4");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cbd0b697-3381-42eb-a939-ad05488c213f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e5a0ea5c-24b8-4624-95f3-5d365799f6e0");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f3317d8c-a9a5-4dcd-bcb0-5f9cd3b2d636");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f64c8cc0-f05c-4180-a365-9f45d732c676");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f9a1e503-0fbf-4de5-a1f9-39038a13963f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1442aba-7850-498b-97a8-9368bab91896");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ccfa625d-4388-4d41-a6d5-c123d79ffbc8");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d1442aba-7850-498b-97a8-9368bab91896", 0, "9e38c424-4beb-4131-9413-73360734ca84", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAENrvj0Swbyte0rgc52zJUASF2vbSgzsoJuWQddU45nHZJmpRDGAey2VxiDy19wCjAg==", null, false, null, null, "9251eba3-095e-4652-a1e8-1ec9b4169eb1", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "024792d4-6d29-49e9-896f-48c76db4f48f", "microsoft", 11 },
                    { "02fd44ea-e9c9-4dc7-b5a3-9ed22fd7a715", "bluehole", 3 },
                    { "05173518-cee3-4227-834f-c354b095d6ee", "square-enix", 19 },
                    { "13965842-d8c5-4549-951c-73c6075a6838", "ubisoft", 20 },
                    { "1d127555-420f-4f84-8027-c8ea54f7f563", "valve", 21 },
                    { "236ee060-7fcb-49f2-84ee-98df2995bd52", "sony", 18 },
                    { "277e1f48-13c9-4196-a307-0253f1b23af1", "sega", 17 },
                    { "2f56368a-f2d8-402b-9ab4-53417e82653f", "insomniac-games", 10 },
                    { "4cae97bb-c91e-401c-a923-03abc427f77d", "crystal", 6 },
                    { "67388d9f-ed4c-4769-ae51-3877080bddf9", "blizzard", 2 },
                    { "7c50efe6-5558-4687-8673-03418107cf51", "firaxis-games", 9 },
                    { "7d043eb5-6a3e-4cb4-b0d0-95240487de29", "bethesda", 1 },
                    { "895bffbd-2afc-43c2-8978-4fdf00832d99", "mojang", 12 },
                    { "8c343efc-66d1-4d14-a249-688864c911f5", "epic-games", 8 },
                    { "b50d5758-9f19-403c-8a40-80f6383351f4", "cd-projekt", 5 },
                    { "cbd0b697-3381-42eb-a939-ad05488c213f", "capcom", 4 },
                    { "ccfa625d-4388-4d41-a6d5-c123d79ffbc8", "rockstar-games", 16 },
                    { "e5a0ea5c-24b8-4624-95f3-5d365799f6e0", "nintendo", 13 },
                    { "f3317d8c-a9a5-4dcd-bcb0-5f9cd3b2d636", "electronic-arts", 7 },
                    { "f64c8cc0-f05c-4180-a365-9f45d732c676", "remedy-entertainment", 15 },
                    { "f9a1e503-0fbf-4de5-a1f9-39038a13963f", "paradox-interactive", 14 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "ac78fd52-7f73-4526-b59e-246e68dbe664", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "d1442aba-7850-498b-97a8-9368bab91896", null, null, 9, "ccfa625d-4388-4d41-a6d5-c123d79ffbc8", "Grand Theft Auto V" });
        }
    }
}
