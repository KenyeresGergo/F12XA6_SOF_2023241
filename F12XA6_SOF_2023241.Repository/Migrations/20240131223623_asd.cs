using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F12XA6_SOF_2023241.Repository.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4296015a-db0e-4d85-9359-ca78103dcc8d", 0, "b07202ec-9f7a-4381-8b47-23d53fcc071a", "keny.gergo@gmail.com", true, "Kenyeres", "Gergő", false, null, null, "KENY.GERGO@GMAIL.COM", "AQAAAAEAACcQAAAAEINih/wkWjqc7MR/jYpSMNGxM/IkwoJSgd9ES1aAyaE681LMn5ud9whU7wM2UYkUig==", null, false, null, null, "6985b8ea-8dea-4465-9316-fdc07f80c140", false, "keny.gergo@gmail.com" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "LogoSvg", "Name" },
                values: new object[,]
                {
                    { "01208655-1046-4b6b-984f-712729366fe9", "~/logos_in_svg/square-enix", 19 },
                    { "0dda331f-6b84-4097-ac42-bbd8998b74c3", "~/logos_in_svg/epic-games", 8 },
                    { "1670b9e7-3d31-4f6c-a32e-e94313d26edf", "~/logos_in_svg/microsoft", 11 },
                    { "28cb169d-7b8a-4b96-aa03-145ef7bb893f", "~/logos_in_svg/electronic-arts", 7 },
                    { "2ddbb209-490e-409a-a84a-68999b44c249", "~/logos_in_svg/blizzard", 2 },
                    { "3ae07a48-b9ea-4d63-81d8-eb086e3d6772", "~/logos_in_svg/nintendo", 13 },
                    { "48106a0a-8cf5-4cfd-b39f-3371bad79aad", "~/logos_in_svg/crystal", 6 },
                    { "67ff805f-a788-4d90-905f-872a77f1fb2f", "~/logos_in_svg/paradox-interactive", 14 },
                    { "7738fb0d-1c83-4f65-8eb2-4337864f6f0f", "~/logos_in_svg/remedy-entertainment", 15 },
                    { "7b659668-3adc-44c1-acc9-c2be518e21e7", "~/logos_in_svg/rockstar-games", 16 },
                    { "8343f066-3d7c-4698-822f-1dabcdd6d706", "~/logos_in_svg/insomniac-games", 10 },
                    { "8bcbe153-7e65-487b-8177-ec71ddb11fa2", "~/logos_in_svg/cd-projekt", 5 },
                    { "8cb8ff53-6634-4896-9d85-a206d82c34df", "~/logos_in_svg/sony", 18 },
                    { "96857615-b33e-49bc-8cec-2b4c6f281562", "~/logos_in_svg/bethesda", 1 },
                    { "9e898228-fe8b-4405-b12a-c4e29b56f7a8", "~/logos_in_svg/ubisoft", 20 },
                    { "aec2bc60-a7f1-4fe8-9262-278fc66c9ef0", "~/logos_in_svg/firaxis-games", 9 },
                    { "b1b51cfc-6fd8-4d97-b0e5-1c57a3266244", "~/logos_in_svg/mojang", 12 },
                    { "cb659961-530b-4fc9-a847-d4fb832a0b1a", "~/logos_in_svg/capcom", 4 },
                    { "cbf09055-ed7a-47ec-ac64-7d306fd04507", "~/logos_in_svg/sega", 17 },
                    { "e9c2a600-76b6-484c-856a-7d1c6592d5e1", "~/logos_in_svg/bluehole", 3 },
                    { "eee6028f-8f30-480b-8680-9abe2ea6ad05", "~/logos_in_svg/valve", 21 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "OwnerId", "PhotoContentType", "PhotoData", "Rating", "StudiosId", "Title" },
                values: new object[] { "fdb037bc-b9f3-4716-8e6c-7bc001ea5fae", "Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt ...", "4296015a-db0e-4d85-9359-ca78103dcc8d", "image/jpeg", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 9, "7b659668-3adc-44c1-acc9-c2be518e21e7", "Grand Theft Auto V" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: "fdb037bc-b9f3-4716-8e6c-7bc001ea5fae");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "01208655-1046-4b6b-984f-712729366fe9");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "0dda331f-6b84-4097-ac42-bbd8998b74c3");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "1670b9e7-3d31-4f6c-a32e-e94313d26edf");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "28cb169d-7b8a-4b96-aa03-145ef7bb893f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "2ddbb209-490e-409a-a84a-68999b44c249");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "3ae07a48-b9ea-4d63-81d8-eb086e3d6772");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "48106a0a-8cf5-4cfd-b39f-3371bad79aad");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "67ff805f-a788-4d90-905f-872a77f1fb2f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7738fb0d-1c83-4f65-8eb2-4337864f6f0f");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8343f066-3d7c-4698-822f-1dabcdd6d706");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8bcbe153-7e65-487b-8177-ec71ddb11fa2");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "8cb8ff53-6634-4896-9d85-a206d82c34df");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "96857615-b33e-49bc-8cec-2b4c6f281562");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "9e898228-fe8b-4405-b12a-c4e29b56f7a8");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "aec2bc60-a7f1-4fe8-9262-278fc66c9ef0");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "b1b51cfc-6fd8-4d97-b0e5-1c57a3266244");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cb659961-530b-4fc9-a847-d4fb832a0b1a");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "cbf09055-ed7a-47ec-ac64-7d306fd04507");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "e9c2a600-76b6-484c-856a-7d1c6592d5e1");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "eee6028f-8f30-480b-8680-9abe2ea6ad05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4296015a-db0e-4d85-9359-ca78103dcc8d");

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: "7b659668-3adc-44c1-acc9-c2be518e21e7");

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
    }
}
