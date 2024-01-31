using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class validations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
