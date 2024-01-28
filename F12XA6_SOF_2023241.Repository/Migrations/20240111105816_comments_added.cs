using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class comments_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReactionCounter = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b25cebef-195a-4fc2-99da-7790d5371533", 0, "883be986-4c0b-4363-b9eb-5af4a03137ea", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEK96K6Hkv8rp2qJD2Ev8EH7oT0B5RIOHLuHVsgu1t3RqKHLE/pQaOpyjkmacg1xXug==", null, false, null, null, "2dea4c03-2a17-4ca7-8969-5ee2db3eca47", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "0d040b18-a014-455c-8398-386c2e0ff372", "~/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "2166a151-7aca-4114-b158-c09e05575c6b", "~/wwwroot/logos_in_svg/blizzard", 2 },
                    { "24d1e40a-d885-44d6-805b-7fc13696b7a2", "~/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "27bd6cb7-e315-4c09-97d5-c39189a01499", "~/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "298629b5-c5c2-467e-ab90-4c68302292e3", "~/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "360175b4-0db9-4ef5-9a38-26cd854ee79f", "~/wwwroot/logos_in_svg/valve", 21 },
                    { "39285ff2-466b-4309-b509-64ea11bf308d", "~/wwwroot/logos_in_svg/square-enix", 19 },
                    { "3cabe1c4-70bf-49e3-8b67-138e5b726619", "~/wwwroot/logos_in_svg/crystal", 6 },
                    { "53884400-736b-4b4e-adae-e0f89bebd922", "~/wwwroot/logos_in_svg/bethesda", 1 },
                    { "5cea3390-2a93-4dd3-a090-b55a68c5d6aa", "~/wwwroot/logos_in_svg/nintendo", 13 },
                    { "750341f1-e5e9-471b-993c-e10e43d4d38b", "~/wwwroot/logos_in_svg/microsoft", 11 },
                    { "92cccbf5-0dcc-44e9-9ed9-e398c82f8232", "~/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "93fb06b4-4b4d-4024-8e85-e9eb7adca4b2", "~/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "9dd171e3-7869-4d7a-886e-9ce72bbda5d1", "~/wwwroot/logos_in_svg/mojang", 12 },
                    { "a82f2df1-ec63-4a43-8fc4-9079bd6c4f0f", "~/wwwroot/logos_in_svg/epic-games", 8 },
                    { "afdd6339-053e-48a8-afb6-ca6a4d381958", "~/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "b81ebd7f-efa5-4b24-87f0-288cd5d01614", "~/wwwroot/logos_in_svg/bluehole", 3 },
                    { "b90a7b2a-0bd1-4fa0-a636-5acb291c77a7", "~/wwwroot/logos_in_svg/sony", 18 },
                    { "daf8d13f-eaef-4b7c-9a6b-27b801830854", "~/wwwroot/logos_in_svg/capcom", 4 },
                    { "ed74b9bc-a998-4e33-861c-97788d297b52", "~/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "f87970fd-7db6-40c9-922e-40aaea7e14c3", "~/wwwroot/logos_in_svg/sega", 17 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "0b3f8640-0091-4c2b-ac75-c77a63e6b58d", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "b25cebef-195a-4fc2-99da-7790d5371533", null, null, 9, "afdd6339-053e-48a8-afb6-ca6a4d381958", "Grand Theft Auto V" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_GameId",
                table: "Comment",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "0b3f8640-0091-4c2b-ac75-c77a63e6b58d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0d040b18-a014-455c-8398-386c2e0ff372");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2166a151-7aca-4114-b158-c09e05575c6b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "24d1e40a-d885-44d6-805b-7fc13696b7a2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "27bd6cb7-e315-4c09-97d5-c39189a01499");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "298629b5-c5c2-467e-ab90-4c68302292e3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "360175b4-0db9-4ef5-9a38-26cd854ee79f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "39285ff2-466b-4309-b509-64ea11bf308d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3cabe1c4-70bf-49e3-8b67-138e5b726619");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "53884400-736b-4b4e-adae-e0f89bebd922");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "5cea3390-2a93-4dd3-a090-b55a68c5d6aa");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "750341f1-e5e9-471b-993c-e10e43d4d38b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "92cccbf5-0dcc-44e9-9ed9-e398c82f8232");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "93fb06b4-4b4d-4024-8e85-e9eb7adca4b2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9dd171e3-7869-4d7a-886e-9ce72bbda5d1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a82f2df1-ec63-4a43-8fc4-9079bd6c4f0f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b81ebd7f-efa5-4b24-87f0-288cd5d01614");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b90a7b2a-0bd1-4fa0-a636-5acb291c77a7");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "daf8d13f-eaef-4b7c-9a6b-27b801830854");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ed74b9bc-a998-4e33-861c-97788d297b52");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f87970fd-7db6-40c9-922e-40aaea7e14c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b25cebef-195a-4fc2-99da-7790d5371533");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "afdd6339-053e-48a8-afb6-ca6a4d381958");

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
    }
}
