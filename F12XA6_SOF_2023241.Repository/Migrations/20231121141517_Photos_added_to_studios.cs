using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class Photos_added_to_studios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PhotoContentType",
                table: "Games",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "79f47f97-e85d-43d2-b5fc-f4dbb2c8f42f", 0, "a5afda16-67c0-4d5b-b6a6-48503b61dbc8", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEPVzd/rVOAE2Jh6BG8Pljjbs5i96JFO/v9Hp0g+xh+Mbq8v0ZJCL56K6UURzP0vW3A==", null, false, null, null, "00cf426a-1fe5-4169-bb27-ae85cca58cac", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "08a98d66-de06-40bf-b597-1dc5c7016928", "~/wwwroot/logos_in_svg/nintendo", 13 },
                    { "0bb17b28-90ab-45b3-be5f-ab3690f3f7e2", "~/wwwroot/logos_in_svg/sony", 18 },
                    { "1e511486-fc30-418d-a313-1b6156d5020b", "~/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "328924ec-caa9-4842-b80d-b3a0f64da085", "~/wwwroot/logos_in_svg/square-enix", 19 },
                    { "35468480-5890-4aa9-9756-9c6995f040e8", "~/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "413f87b1-33ce-4652-8089-ca2c0cec6470", "~/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "4c7ed6e4-a5be-46ff-a529-c082c7ccf336", "~/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "5a19297b-15ad-4542-bea2-909dae37e606", "~/wwwroot/logos_in_svg/sega", 17 },
                    { "5a40b231-00e8-46a4-a11b-d2a42e8acfa1", "~/wwwroot/logos_in_svg/mojang", 12 },
                    { "6591a07f-c0fe-4a76-9c00-3559508ede33", "~/wwwroot/logos_in_svg/crystal", 6 },
                    { "6676ca7d-f29d-4432-9aa4-dcf09bb3de63", "~/wwwroot/logos_in_svg/microsoft", 11 },
                    { "6e76f86c-9715-45c9-a330-d4dac9f9feb4", "~/wwwroot/logos_in_svg/epic-games", 8 },
                    { "7b1e9809-1b9f-4200-83e0-db4cf0242d15", "~/wwwroot/logos_in_svg/bethesda", 1 },
                    { "826de83d-0d98-43f0-a439-17043e5ab58b", "~/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "8f8a8b6c-107a-471d-a988-d51b2b832d66", "~/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "c2b3116c-4c83-4451-9a6f-a8952e0ff646", "~/wwwroot/logos_in_svg/capcom", 4 },
                    { "cc39bae8-b372-47e4-8f81-18f8da542cb5", "~/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "ea8d72a6-d13f-40b3-ad66-6412dc4edcdc", "~/wwwroot/logos_in_svg/bluehole", 3 },
                    { "ec4e7157-a0d5-4727-b0c3-d3debd8ca842", "~/wwwroot/logos_in_svg/blizzard", 2 },
                    { "fd7dad99-a6f6-4661-bf8d-628270bcda52", "~/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "fd8585a7-9efa-4fb7-a4a7-2dda94ba6255", "~/wwwroot/logos_in_svg/valve", 21 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "0910ec40-af1b-42bf-91fa-52dc9a03233e", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "79f47f97-e85d-43d2-b5fc-f4dbb2c8f42f", null, null, 9, "fd7dad99-a6f6-4661-bf8d-628270bcda52", "Grand Theft Auto V" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "0910ec40-af1b-42bf-91fa-52dc9a03233e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "08a98d66-de06-40bf-b597-1dc5c7016928");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0bb17b28-90ab-45b3-be5f-ab3690f3f7e2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1e511486-fc30-418d-a313-1b6156d5020b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "328924ec-caa9-4842-b80d-b3a0f64da085");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "35468480-5890-4aa9-9756-9c6995f040e8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "413f87b1-33ce-4652-8089-ca2c0cec6470");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "4c7ed6e4-a5be-46ff-a529-c082c7ccf336");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5a19297b-15ad-4542-bea2-909dae37e606");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5a40b231-00e8-46a4-a11b-d2a42e8acfa1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6591a07f-c0fe-4a76-9c00-3559508ede33");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6676ca7d-f29d-4432-9aa4-dcf09bb3de63");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6e76f86c-9715-45c9-a330-d4dac9f9feb4");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7b1e9809-1b9f-4200-83e0-db4cf0242d15");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "826de83d-0d98-43f0-a439-17043e5ab58b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8f8a8b6c-107a-471d-a988-d51b2b832d66");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "c2b3116c-4c83-4451-9a6f-a8952e0ff646");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cc39bae8-b372-47e4-8f81-18f8da542cb5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ea8d72a6-d13f-40b3-ad66-6412dc4edcdc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ec4e7157-a0d5-4727-b0c3-d3debd8ca842");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fd8585a7-9efa-4fb7-a4a7-2dda94ba6255");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79f47f97-e85d-43d2-b5fc-f4dbb2c8f42f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fd7dad99-a6f6-4661-bf8d-628270bcda52");

            migrationBuilder.DropColumn(
                name: "PhotoContentType",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
