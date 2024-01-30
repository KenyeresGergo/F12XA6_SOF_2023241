using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class commentV09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "971161e0-d782-430d-8de6-afc3c1ac70c8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "00c91e34-e5ef-4729-8aab-b0c2972e1606");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "257c3ccd-4933-43ad-b762-3739bb772dbe");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "285ef51f-84fe-44ad-a67f-6dc0e5195ae6");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2ba1f6af-5682-4746-bbb4-7a90913b5d7e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "345a0039-d9ef-4b34-84c8-faa554df3947");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "44616225-57eb-4e29-a2d3-9b0fd3c8561b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5e594a08-9d17-4da8-a647-e2092d95b409");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "69e1a878-5643-49ea-b1f7-0b7f2996b3bc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "76883a39-0041-47dc-b5fe-a71b94608413");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "79f227a0-bdd7-420e-bb58-b65e45ce8526");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "90de324c-0ae1-436d-abfa-bc41c629bc6c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "98aa0a02-faae-49b6-b0eb-7ef0d58510ed");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ada1a697-6a5f-428d-9d32-e77b39dde516");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "bbbf5bdf-3f4a-45a0-9e76-cf4fa53c7c73");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "c3420e62-e2ee-402c-b17b-3b4dbeea6336");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cda18588-d35d-487e-b1c1-f229cf1dc8ad");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "dba9df21-d5fc-45f3-8706-1b1c647d9649");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e1de7a80-4953-45a9-a730-e806489c75da");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f2b137b1-3b65-435b-8579-798943eed6ea");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "fffd6105-bec7-44ea-9a52-a7e55e4c6b95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c568283-5ea3-4bbb-a66d-29fd14fa7e19");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "d913b45a-a608-4e4b-abaf-120ab5675ebd");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5c568283-5ea3-4bbb-a66d-29fd14fa7e19", 0, "e961aef4-234b-4f39-aa50-5e8f3a20daf6", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEFg1tLF0wmLt+Vf31rpb90FSTknLAFkgYNvpnhgoFZo4uQ4ojbFuv44LDyo8y6MaVg==", null, false, null, null, "6587b784-1274-47b8-aa6b-7101067d35dc", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "00c91e34-e5ef-4729-8aab-b0c2972e1606", "paradox-interactive", 14 },
                    { "257c3ccd-4933-43ad-b762-3739bb772dbe", "bethesda", 1 },
                    { "285ef51f-84fe-44ad-a67f-6dc0e5195ae6", "microsoft", 11 },
                    { "2ba1f6af-5682-4746-bbb4-7a90913b5d7e", "electronic-arts", 7 },
                    { "345a0039-d9ef-4b34-84c8-faa554df3947", "cd-projekt", 5 },
                    { "44616225-57eb-4e29-a2d3-9b0fd3c8561b", "firaxis-games", 9 },
                    { "5e594a08-9d17-4da8-a647-e2092d95b409", "bluehole", 3 },                    { "69e1a878-5643-49ea-b1f7-0b7f2996b3bc", "sony", 18 },
                    { "76883a39-0041-47dc-b5fe-a71b94608413", "capcom", 4 },
                    { "79f227a0-bdd7-420e-bb58-b65e45ce8526", "square-enix", 19 },
                    { "90de324c-0ae1-436d-abfa-bc41c629bc6c", "crystal", 6 },
                    { "98aa0a02-faae-49b6-b0eb-7ef0d58510ed", "epic-games", 8 },
                    { "ada1a697-6a5f-428d-9d32-e77b39dde516", "sega", 17 },
                    { "bbbf5bdf-3f4a-45a0-9e76-cf4fa53c7c73", "blizzard", 2 },
                    { "c3420e62-e2ee-402c-b17b-3b4dbeea6336", "insomniac-games", 10 },
                    { "cda18588-d35d-487e-b1c1-f229cf1dc8ad", "ubisoft", 20 },
                    { "d913b45a-a608-4e4b-abaf-120ab5675ebd", "rockstar-games", 16 },
                    { "dba9df21-d5fc-45f3-8706-1b1c647d9649", "mojang", 12 },
                    { "e1de7a80-4953-45a9-a730-e806489c75da", "nintendo", 13 },
                    { "f2b137b1-3b65-435b-8579-798943eed6ea", "remedy-entertainment", 15 },
                    { "fffd6105-bec7-44ea-9a52-a7e55e4c6b95", "valve", 21 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "971161e0-d782-430d-8de6-afc3c1ac70c8", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "5c568283-5ea3-4bbb-a66d-29fd14fa7e19", null, null, 9, "d913b45a-a608-4e4b-abaf-120ab5675ebd", "Grand Theft Auto V" });
        }
    }
}
