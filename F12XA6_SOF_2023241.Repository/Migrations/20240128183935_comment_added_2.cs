using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class comment_added_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Games_GameId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studios_StudiosId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

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

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_GameId",
                table: "Comments",
                newName: "IX_Comments_GameId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoContentType", "PhotoData", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2cef9122-cde6-4a7f-9daa-adb3184883cc", 0, "218c0c27-941b-494e-983c-00727e811004", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEN7Ai8KvFfm6qcnwCPn34BsmtJuuNZiz1fQ9+O01M1Mj3SjcGphlh5P80FngYotQFw==", null, false, null, null, "1984b42a-a9ff-4dec-9b21-ea2edb8aaff3", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "042e34a1-4c26-4439-9a96-516744f92a61", "~/wwwroot/logos_in_svg/remedy-entertainment", 15 },
                    { "04c87a34-e55c-4000-b17b-5b33acb01b8c", "~/wwwroot/logos_in_svg/sony", 18 },
                    { "07d4da67-d29c-42a6-b04c-613f05392974", "~/wwwroot/logos_in_svg/blizzard", 2 },
                    { "143ff734-1633-41c6-a659-ee1b3f5c1899", "~/wwwroot/logos_in_svg/ubisoft", 20 },
                    { "15a9fe86-676b-4406-a0d4-f7a8e895711c", "~/wwwroot/logos_in_svg/electronic-arts", 7 },
                    { "1afbe55d-0fe7-478b-8c31-f054b26b7a58", "~/wwwroot/logos_in_svg/bethesda", 1 },
                    { "25cd7b1b-3554-4fc2-8b7c-cfbf698346ec", "~/wwwroot/logos_in_svg/rockstar-games", 16 },
                    { "28ac21ce-bb79-45f9-8625-bfc456849ede", "~/wwwroot/logos_in_svg/cd-projekt", 5 },
                    { "2cdcfbe3-965a-4a3e-ac2c-7df7ee76466c", "~/wwwroot/logos_in_svg/insomniac-games", 10 },
                    { "3d392f2a-5663-4c04-9ad6-a9b03ee70063", "~/wwwroot/logos_in_svg/square-enix", 19 },
                    { "6bffffc0-9045-4533-b9c5-170fa01bd4f5", "~/wwwroot/logos_in_svg/mojang", 12 },
                    { "72c67440-4c54-4bd7-b259-f09e26eace43", "~/wwwroot/logos_in_svg/sega", 17 },
                    { "75b7f8d5-bfef-44bf-918d-56c85baf52ac", "~/wwwroot/logos_in_svg/bluehole", 3 },
                    { "7784bf16-d552-499b-811e-ae5bd8aada90", "~/wwwroot/logos_in_svg/valve", 21 },
                    { "827716f7-ce13-426e-a16e-1a43e442bc7b", "~/wwwroot/logos_in_svg/firaxis-games", 9 },
                    { "888af383-6b05-48b4-90fe-103b40c1b537", "~/wwwroot/logos_in_svg/epic-games", 8 },
                    { "aaf2af19-1fc2-409d-94c5-5dd80921163f", "~/wwwroot/logos_in_svg/microsoft", 11 },
                    { "aafa7b69-e5d5-4262-9921-cdd94735c4aa", "~/wwwroot/logos_in_svg/crystal", 6 },
                    { "bb20a8b8-264e-4449-8f0b-ae2d5dfa3543", "~/wwwroot/logos_in_svg/paradox-interactive", 14 },
                    { "e170bac4-c88f-4e79-a20c-3de9e21e174e", "~/wwwroot/logos_in_svg/nintendo", 13 },
                    { "ef20a3b1-220d-4769-9a04-1c79813eba0d", "~/wwwroot/logos_in_svg/capcom", 4 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "42d3b068-26c3-4bc2-b89f-3ae4c4d5d7ca", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "2cef9122-cde6-4a7f-9daa-adb3184883cc", null, null, 9, "25cd7b1b-3554-4fc2-8b7c-cfbf698346ec", "Grand Theft Auto V" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_OwnerId",
                table: "Comments",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_OwnerId",
                table: "Comments",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studios_StudiosId",
                table: "Games",
                column: "StudiosId",
                principalTable: "Studios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_OwnerId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Studios_StudiosId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_OwnerId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "42d3b068-26c3-4bc2-b89f-3ae4c4d5d7ca");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "042e34a1-4c26-4439-9a96-516744f92a61");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "04c87a34-e55c-4000-b17b-5b33acb01b8c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "07d4da67-d29c-42a6-b04c-613f05392974");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "143ff734-1633-41c6-a659-ee1b3f5c1899");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "15a9fe86-676b-4406-a0d4-f7a8e895711c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1afbe55d-0fe7-478b-8c31-f054b26b7a58");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "28ac21ce-bb79-45f9-8625-bfc456849ede");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2cdcfbe3-965a-4a3e-ac2c-7df7ee76466c");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3d392f2a-5663-4c04-9ad6-a9b03ee70063");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "6bffffc0-9045-4533-b9c5-170fa01bd4f5");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "72c67440-4c54-4bd7-b259-f09e26eace43");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "75b7f8d5-bfef-44bf-918d-56c85baf52ac");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7784bf16-d552-499b-811e-ae5bd8aada90");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "827716f7-ce13-426e-a16e-1a43e442bc7b");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "888af383-6b05-48b4-90fe-103b40c1b537");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "aaf2af19-1fc2-409d-94c5-5dd80921163f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "aafa7b69-e5d5-4262-9921-cdd94735c4aa");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "bb20a8b8-264e-4449-8f0b-ae2d5dfa3543");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e170bac4-c88f-4e79-a20c-3de9e21e174e");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "ef20a3b1-220d-4769-9a04-1c79813eba0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cef9122-cde6-4a7f-9daa-adb3184883cc");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "25cd7b1b-3554-4fc2-8b7c-cfbf698346ec");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_GameId",
                table: "Comment",
                newName: "IX_Comment_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Games_GameId",
                table: "Comment",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_OwnerId",
                table: "Games",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Studios_StudiosId",
                table: "Games",
                column: "StudiosId",
                principalTable: "Studios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
