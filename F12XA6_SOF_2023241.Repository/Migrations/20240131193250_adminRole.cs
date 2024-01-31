using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class adminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "c10113e7-ea25-48cd-93c1-9bbd83d7c505");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "012d5eb8-2724-4873-9d6d-d004c6affa75");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "09532fc4-4257-4dee-bfe3-bafb5b6ff740");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1933bfcc-6607-40c8-b537-4e802bddfe0a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2c7e1a46-c9ef-41c2-ba96-dac8e99823dd");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5510a973-ae70-4429-95b7-9044ca509b6a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5e8b870c-38b4-458d-bec2-beb81d95f5f8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "69a13fd3-566f-4036-b768-a94fa1b43178");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "745bea17-8db5-401b-a872-29c4732550ae");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "76bb694f-aadf-499b-8ddf-9999925a4bab");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7bf9c229-f49a-4e86-8777-d72e124a3a25");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8b596415-0b2f-4a6a-9526-ccb8ce6277ae");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8d211a49-6cae-4ac2-bf7d-00ce36934841");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "90f6db3e-acc2-45ad-a497-2465463975dd");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "94aafa66-61cf-497f-9318-3fece9bf353d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9592ceb2-6941-4882-bb9d-9d1dff710fdc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9aada492-0615-494b-903b-e32ef5415b57");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ab4fb532-63c9-4226-859f-891558940088");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "db473d19-e499-458e-a568-c7171234703a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f183a3c8-c08d-42d8-b290-0d5f24b3d02b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f2ce7682-de2e-4943-b2d8-df0dde1d71e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc447fdb-026b-43c8-98ca-449090502734");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2b12910b-a886-4f28-86e3-e4367dd9fb18");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f2c3a59b-4474-4829-b423-af5bd15f483b", 0, "440e48d3-d272-47f4-b22e-3b53bc8d7411", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEH00A9Qk3iWeNOyNjB4hevfUGRtvSZTssMg/P2cuy4DgAKrcRj07Y2CW4JG1jamvcQ==", null, false, null, null, "2a17db16-2370-46de-a869-a17e97f9b10a", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "05c6b65f-12e6-4098-9938-b2f8e0053f0b", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "3b296dd5-61ce-4120-a0f1-c7ded34e46ff", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "4341c405-0e1e-4360-853a-8830a52d3526", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "462836c7-bf66-45d4-a4ce-9e94eb09161e", "/wwwroot/logos_in_svg/nintendo", 13 },
                    { "4819621b-a6a2-4c52-b3b0-a6ba04452cb8", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "4ddd12a2-941b-43fc-ae40-6700e83a0f2d", "/wwwroot/logos_in_svg/bluehole", 3 },
                    { "5eff9887-9077-499c-b811-ae32ae9acb02", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "5f8790f2-5bd8-4816-9f09-3ac13c0e09c9", "/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "6a644c81-8f2e-4537-a8f1-3cc9fc928a17", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "7ae459d6-72fd-4f5f-bd90-014d65c6f8e4", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "7fe54e96-401b-4aea-b0b6-76c52dbacb9a", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "808fd4cd-e5a2-4981-a5e4-d28c27b6fe6f", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "8594736f-07a1-4f9a-a9a5-4f73bd61cead", "/wwwroot/logos_in_svg/blizzard", 2 },
                    { "a5d108e4-68b8-44c1-8902-fc7c2cc53f5f", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "bcb1a58e-a85d-4740-bcb2-eced8ff68f43", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "ceab1b39-fbfc-47f2-8aef-d0caa35cbd5f", "/wwwroot/logos_in_svg/sega", 17 },
                    { "d7e084c7-cf21-452a-b70a-872bdf76bd27", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "e545bfc2-16e3-474d-9a9d-eb114d643540", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "ef3c951a-0a9d-4cf5-8a67-7d329cf542ce", "/wwwroot/logos_in_svg/valve", 21 },
                    { "fcfc0afa-d357-4698-af09-38fc3a9a6acf", "/wwwroot/logos_in_svg/microsoft", 11 },
                    { "fd24373e-b274-4016-a4b6-8e739f0d5e1b", "/wwwroot/logos_in_svg/sony", 18 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "d754f73d-dd44-442f-9ffc-145225a32a9f", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "f2c3a59b-4474-4829-b423-af5bd15f483b", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "6a644c81-8f2e-4537-a8f1-3cc9fc928a17", "Grand Theft Auto V" });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "d754f73d-dd44-442f-9ffc-145225a32a9f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "05c6b65f-12e6-4098-9938-b2f8e0053f0b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3b296dd5-61ce-4120-a0f1-c7ded34e46ff");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4341c405-0e1e-4360-853a-8830a52d3526");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "462836c7-bf66-45d4-a4ce-9e94eb09161e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4819621b-a6a2-4c52-b3b0-a6ba04452cb8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4ddd12a2-941b-43fc-ae40-6700e83a0f2d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5eff9887-9077-499c-b811-ae32ae9acb02");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5f8790f2-5bd8-4816-9f09-3ac13c0e09c9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7ae459d6-72fd-4f5f-bd90-014d65c6f8e4");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7fe54e96-401b-4aea-b0b6-76c52dbacb9a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "808fd4cd-e5a2-4981-a5e4-d28c27b6fe6f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8594736f-07a1-4f9a-a9a5-4f73bd61cead");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a5d108e4-68b8-44c1-8902-fc7c2cc53f5f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "bcb1a58e-a85d-4740-bcb2-eced8ff68f43");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ceab1b39-fbfc-47f2-8aef-d0caa35cbd5f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "d7e084c7-cf21-452a-b70a-872bdf76bd27");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e545bfc2-16e3-474d-9a9d-eb114d643540");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ef3c951a-0a9d-4cf5-8a67-7d329cf542ce");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fcfc0afa-d357-4698-af09-38fc3a9a6acf");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fd24373e-b274-4016-a4b6-8e739f0d5e1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2c3a59b-4474-4829-b423-af5bd15f483b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6a644c81-8f2e-4537-a8f1-3cc9fc928a17");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cc447fdb-026b-43c8-98ca-449090502734", 0, "545dcd86-b230-41e9-adcd-24335f517840", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEPZYRnWYAWPoxkDtDAKvQGjWHYgRk8gKDDrmIbsUskeQwtd5V3DqMlF5iRmuS5o0wA==", null, false, null, null, "52f53a87-4aea-4f84-9d06-bc58d08c9535", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "012d5eb8-2724-4873-9d6d-d004c6affa75", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "09532fc4-4257-4dee-bfe3-bafb5b6ff740", "/wwwroot/logos_in_svg/nintendo", 13 },
                    { "1933bfcc-6607-40c8-b537-4e802bddfe0a", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "2b12910b-a886-4f28-86e3-e4367dd9fb18", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "2c7e1a46-c9ef-41c2-ba96-dac8e99823dd", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "5510a973-ae70-4429-95b7-9044ca509b6a", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "5e8b870c-38b4-458d-bec2-beb81d95f5f8", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "69a13fd3-566f-4036-b768-a94fa1b43178", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "745bea17-8db5-401b-a872-29c4732550ae", "/wwwroot/logos_in_svg/sega", 17 },
                    { "76bb694f-aadf-499b-8ddf-9999925a4bab", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "7bf9c229-f49a-4e86-8777-d72e124a3a25", "/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "8b596415-0b2f-4a6a-9526-ccb8ce6277ae", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "8d211a49-6cae-4ac2-bf7d-00ce36934841", "/wwwroot/logos_in_svg/valve", 21 },
                    { "90f6db3e-acc2-45ad-a497-2465463975dd", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "94aafa66-61cf-497f-9318-3fece9bf353d", "/wwwroot/logos_in_svg/blizzard", 2 },
                    { "9592ceb2-6941-4882-bb9d-9d1dff710fdc", "/wwwroot/logos_in_svg/sony", 18 },
                    { "9aada492-0615-494b-903b-e32ef5415b57", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "ab4fb532-63c9-4226-859f-891558940088", "/wwwroot/logos_in_svg/bluehole", 3 },
                    { "db473d19-e499-458e-a568-c7171234703a", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "f183a3c8-c08d-42d8-b290-0d5f24b3d02b", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "f2ce7682-de2e-4943-b2d8-df0dde1d71e5", "/wwwroot/logos_in_svg/microsoft", 11 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "c10113e7-ea25-48cd-93c1-9bbd83d7c505", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "cc447fdb-026b-43c8-98ca-449090502734", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "2b12910b-a886-4f28-86e3-e4367dd9fb18", "Grand Theft Auto V" });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
