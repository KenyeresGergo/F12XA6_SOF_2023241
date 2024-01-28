using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class newpc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c92c1a2d-a8eb-4fec-a2ea-da08f05448b2", 0, "ba7cba9b-b1d5-400c-894f-157f3a49dca8", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEP5dPVoxZaVZROLEL3Pv7U9q11fUcp0qefML4U63Q5QaELWvErXbccwfWuwnwbunRw==", null, false, null, null, "08df41f7-4842-49c3-b74e-00a3717072b1", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "036c203a-85af-4d9a-bb97-8ec7746479d3", "~/wwwroot/logos_in_svg/blizzard", 2 },
                    { "05f91778-357c-4d83-bae3-c6c26c829621", "~/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "15bae70f-2c5a-4a48-96a8-919dfcf1ee37", "~/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "163859ef-22f2-4b7c-a7ff-fd4a77d652f0", "~/wwwroot/logos_in_svg/microsoft", 11 },
                    { "17702228-3689-4623-94c7-838c4f8b618b", "~/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "18ea3c62-fee5-48d9-87c4-1aa0384d5caf", "~/wwwroot/logos_in_svg/epic-games", 8 },
                    { "285102e4-5326-467b-ab93-abbfcb78003e", "~/wwwroot/logos_in_svg/valve", 21 },
                    { "66c75c95-9767-45e5-85c6-f4f5a196e545", "~/wwwroot/logos_in_svg/crystal", 6 },
                    { "711579b2-8462-4fc4-a3a6-901e75746007", "~/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "75278aa7-07f4-426d-b770-c7e5061db9f9", "~/wwwroot/logos_in_svg/square-enix", 19 },
                    { "88eaa27d-bfae-4d3e-bf93-0160e8610dd7", "~/wwwroot/logos_in_svg/nintendo", 13 },
                    { "8ad4c39e-f8e5-4013-949e-201fb9c6f615", "~/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "90b5be9e-efe0-4874-a1a2-f5c12550249e", "~/wwwroot/logos_in_svg/bethesda", 1 },
                    { "95106fb7-9d9f-4e0a-808b-ce541a66204f", "~/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "9b252cf3-8771-45dc-82ce-c112ab06cec1", "~/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "a71fd032-e942-449a-878c-651dbd127a32", "~/wwwroot/logos_in_svg/sony", 18 },
                    { "aefbe325-a2eb-4975-86d8-9f07c1a348fb", "~/wwwroot/logos_in_svg/capcom", 4 },
                    { "b829f7e6-f13c-4119-807d-377b0d432604", "~/wwwroot/logos_in_svg/bluehole", 3 },
                    { "e577657b-3b67-4f9a-8f35-c2c5645c5c05", "~/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "ee9784be-e6f5-48c6-80e7-7441e0c4c82c", "~/wwwroot/logos_in_svg/mojang", 12 },
                    { "f559eb47-a146-4fe5-b902-bdd7bfc309e7", "~/wwwroot/logos_in_svg/sega", 17 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "3ce36891-6c9a-4aea-ad6a-7c421e1885f8", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "c92c1a2d-a8eb-4fec-a2ea-da08f05448b2", null, null, 9, "17702228-3689-4623-94c7-838c4f8b618b", "Grand Theft Auto V" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_UserId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "3ce36891-6c9a-4aea-ad6a-7c421e1885f8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "036c203a-85af-4d9a-bb97-8ec7746479d3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "05f91778-357c-4d83-bae3-c6c26c829621");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "15bae70f-2c5a-4a48-96a8-919dfcf1ee37");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "163859ef-22f2-4b7c-a7ff-fd4a77d652f0");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "18ea3c62-fee5-48d9-87c4-1aa0384d5caf");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "285102e4-5326-467b-ab93-abbfcb78003e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "66c75c95-9767-45e5-85c6-f4f5a196e545");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "711579b2-8462-4fc4-a3a6-901e75746007");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "75278aa7-07f4-426d-b770-c7e5061db9f9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "88eaa27d-bfae-4d3e-bf93-0160e8610dd7");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8ad4c39e-f8e5-4013-949e-201fb9c6f615");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "90b5be9e-efe0-4874-a1a2-f5c12550249e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "95106fb7-9d9f-4e0a-808b-ce541a66204f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9b252cf3-8771-45dc-82ce-c112ab06cec1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "a71fd032-e942-449a-878c-651dbd127a32");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "aefbe325-a2eb-4975-86d8-9f07c1a348fb");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b829f7e6-f13c-4119-807d-377b0d432604");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e577657b-3b67-4f9a-8f35-c2c5645c5c05");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ee9784be-e6f5-48c6-80e7-7441e0c4c82c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "f559eb47-a146-4fe5-b902-bdd7bfc309e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c92c1a2d-a8eb-4fec-a2ea-da08f05448b2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "17702228-3689-4623-94c7-838c4f8b618b");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comment");

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
        }
    }
}
