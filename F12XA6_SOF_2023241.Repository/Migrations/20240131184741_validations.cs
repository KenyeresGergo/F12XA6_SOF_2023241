using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class validations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9d708ec1-f1c1-4106-bb87-237419502975", 0, "a2902770-d5ac-4fba-be9b-63578a4cfac9", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEOiGrgk7XBumc25bhVAad1e3mMEtL29A8CNX48ISwGsoehqSq/yTQoUklQKXQnql1Q==", null, false, null, null, "1c7d9230-056f-4cc0-89bf-9b9def49eca1", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "007cceb2-5bb7-4143-b054-e2884d8366f6", "/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "2340fa8e-f5cc-4e64-bd53-7bc751eaba81", "/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "35e37d2b-7ca9-41ee-989c-723434608e97", "/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "4580284b-b4af-4c6b-aef3-4b28301b408e", "/wwwroot/logos_in_svg/mojang", 12 },
                    { "5385181f-d7ed-4413-9c82-b94672f4b9dc", "/wwwroot/logos_in_svg/square-enix", 19 },
                    { "5db5471f-3c52-46ee-96d0-b30a51b9a087", "/wwwroot/logos_in_svg/sony", 18 },
                    { "644a5a5f-293f-403f-bdb2-e2b898ee9beb", "/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "6ac43fc6-a67d-4457-ae2a-46c8f1dfe63b", "/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "6dba5e49-c1ab-453a-90dd-7de70579af65", "/wwwroot/logos_in_svg/crystal", 6 },
                    { "6eeca7d0-a8a7-483f-b4a3-93d6f49cc6f6", "/wwwroot/logos_in_svg/bethesda", 1 },
                    { "755f8cfd-a35a-4bbd-8e7b-1cff0a9c9224", "/wwwroot/logos_in_svg/epic-games", 8 },
                    { "7bed5c9e-3d8e-46e4-ba38-6b98d04a0c95", "/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "7c398392-f469-4a48-b941-2d67892e2d4b", "/wwwroot/logos_in_svg/microsoft", 11 },
                    { "8d54f150-3507-4845-8d21-05d96b3fe312", "/wwwroot/logos_in_svg/blizzard", 2 },
                    { "94b57841-ff32-4491-b86a-783263c17687", "/wwwroot/logos_in_svg/bluehole", 3 },
                    { "98066393-e42e-4a16-a029-3fae58babd0d", "/wwwroot/logos_in_svg/valve", 21 },
                    { "ac70181c-543c-45b5-918e-00f528d263cc", "/wwwroot/logos_in_svg/capcom", 4 },
                    { "ba1d66d5-f2a7-4155-8493-88651bddcd1b", "/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "c5f5d919-316f-4c0d-a542-ecd94991b40f", "/wwwroot/logos_in_svg/sega", 17 },
                    { "e60ff26d-a0fe-498e-ae38-aa32918faa96", "/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "ecd164ba-45f2-461c-83e0-b41ef95f8786", "/wwwroot/logos_in_svg/nintendo", 13 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "dc0060b9-3f4e-4a52-9bdf-4dd81975a729", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "9d708ec1-f1c1-4106-bb87-237419502975", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "644a5a5f-293f-403f-bdb2-e2b898ee9beb", "Grand Theft Auto V" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "dc0060b9-3f4e-4a52-9bdf-4dd81975a729");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "007cceb2-5bb7-4143-b054-e2884d8366f6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2340fa8e-f5cc-4e64-bd53-7bc751eaba81");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "35e37d2b-7ca9-41ee-989c-723434608e97");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4580284b-b4af-4c6b-aef3-4b28301b408e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5385181f-d7ed-4413-9c82-b94672f4b9dc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5db5471f-3c52-46ee-96d0-b30a51b9a087");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6ac43fc6-a67d-4457-ae2a-46c8f1dfe63b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6dba5e49-c1ab-453a-90dd-7de70579af65");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6eeca7d0-a8a7-483f-b4a3-93d6f49cc6f6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "755f8cfd-a35a-4bbd-8e7b-1cff0a9c9224");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7bed5c9e-3d8e-46e4-ba38-6b98d04a0c95");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7c398392-f469-4a48-b941-2d67892e2d4b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8d54f150-3507-4845-8d21-05d96b3fe312");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "94b57841-ff32-4491-b86a-783263c17687");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "98066393-e42e-4a16-a029-3fae58babd0d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ac70181c-543c-45b5-918e-00f528d263cc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ba1d66d5-f2a7-4155-8493-88651bddcd1b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "c5f5d919-316f-4c0d-a542-ecd94991b40f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e60ff26d-a0fe-498e-ae38-aa32918faa96");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ecd164ba-45f2-461c-83e0-b41ef95f8786");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d708ec1-f1c1-4106-bb87-237419502975");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "644a5a5f-293f-403f-bdb2-e2b898ee9beb");

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
    }
}
