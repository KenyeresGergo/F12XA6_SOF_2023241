using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class adminRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9f57a887-87ea-4adc-9107-6ecb14a586b8", 0, "4eefec18-a328-49d1-a4df-980a25ad114f", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEJ9nLx/ixQXj/97PZ9CpOmxZxZR1F/+yjdMIAg1vcTuM/o7XV6vb/Heu+/dcJHUWpg==", null, false, null, null, "73ec6b0b-e17b-4e3d-9f95-ec884ebd2fae", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "0fec951e-de79-45da-a7f5-f8f713cb1229", "/wwwroot/logos_in_svg/valve", 21 },
                    { "14faaec0-c06f-4c7c-9bc2-e9ebfb0c8edc", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "22f6bea2-dfd8-42e8-87a5-dacbec907869", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "37d088a4-8638-4768-8288-265ab564dabb", "/wwwroot/logos_in_svg/sony", 18 },
                    { "3dc4c717-3fc7-464f-9cf5-ba29b849e6b3", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "540c623b-d335-4bc3-aed3-374a54dd7c35", "/wwwroot/logos_in_svg/sega", 17 },
                    { "63d95d70-e635-428f-8ac6-e516e4635a44", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "70eccb2e-dc28-4920-9624-72019ac275cf", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "73cfae3a-7daf-4b5d-b236-4ae3e7a93e0e", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "74c3bde2-c573-4d99-9003-27c456827ea6", "/wwwroot/logos_in_svg/microsoft", 11 },
                    { "755df860-c24c-4d93-9668-4488082758f3", "/wwwroot/logos_in_svg/nintendo", 13 },
                    { "7ac902b0-844a-4a5d-a63d-19abfd8cc4cf", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "8203126e-b558-4255-8c78-2f74846f45ce", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "8845069d-cab9-42e4-bd2f-3f0f3d990def", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "a65d6155-3ae7-467f-93bd-be77346abeb6", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "b06a7aaa-2671-415d-b2b8-03fe30a84edf", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "cf02c78e-ef9d-4afe-b637-809064ad1656", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "db51f112-d1bb-442f-9e5d-159bfb76ad7d", "/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "eee317b6-c77f-44d1-a0b6-70ed3e0a0895", "/wwwroot/logos_in_svg/blizzard", 2 },
                    { "f7c1ab1b-831b-4b1c-9099-88585a90b093", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "fe45d9f0-edd1-4ff0-89cb-4c96023e47c1", "/wwwroot/logos_in_svg/bluehole", 3 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "96f01d7a-1333-4f7b-a741-fb17e841decd", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "9f57a887-87ea-4adc-9107-6ecb14a586b8", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "22f6bea2-dfd8-42e8-87a5-dacbec907869", "Grand Theft Auto V" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "96f01d7a-1333-4f7b-a741-fb17e841decd");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0fec951e-de79-45da-a7f5-f8f713cb1229");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "14faaec0-c06f-4c7c-9bc2-e9ebfb0c8edc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "37d088a4-8638-4768-8288-265ab564dabb");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3dc4c717-3fc7-464f-9cf5-ba29b849e6b3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "540c623b-d335-4bc3-aed3-374a54dd7c35");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "63d95d70-e635-428f-8ac6-e516e4635a44");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "70eccb2e-dc28-4920-9624-72019ac275cf");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "73cfae3a-7daf-4b5d-b236-4ae3e7a93e0e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "74c3bde2-c573-4d99-9003-27c456827ea6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "755df860-c24c-4d93-9668-4488082758f3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7ac902b0-844a-4a5d-a63d-19abfd8cc4cf");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8203126e-b558-4255-8c78-2f74846f45ce");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8845069d-cab9-42e4-bd2f-3f0f3d990def");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a65d6155-3ae7-467f-93bd-be77346abeb6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b06a7aaa-2671-415d-b2b8-03fe30a84edf");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cf02c78e-ef9d-4afe-b637-809064ad1656");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "db51f112-d1bb-442f-9e5d-159bfb76ad7d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "eee317b6-c77f-44d1-a0b6-70ed3e0a0895");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f7c1ab1b-831b-4b1c-9099-88585a90b093");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fe45d9f0-edd1-4ff0-89cb-4c96023e47c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f57a887-87ea-4adc-9107-6ecb14a586b8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "22f6bea2-dfd8-42e8-87a5-dacbec907869");

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
        }
    }
}
