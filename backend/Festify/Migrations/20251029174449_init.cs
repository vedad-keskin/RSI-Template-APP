using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Festify.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Flag = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MyAppUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsUser = table.Column<bool>(type: "bit", nullable: false),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: false),
                    LockoutUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyAppUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MyAppUsers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyAppUsers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyAuthenticationTokens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyAppUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyAuthenticationTokens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MyAuthenticationTokens_MyAppUsers_MyAppUserId",
                        column: x => x.MyAppUserId,
                        principalTable: "MyAppUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CreatedAt", "Flag", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9921), null, true, "Bosnia and Herzegovina", null },
                    { 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9923), null, true, "France", null },
                    { 3, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9923), null, true, "Germany", null },
                    { 4, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9924), null, true, "Italy", null },
                    { 5, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9924), null, true, "Norway", null },
                    { 6, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9925), null, true, "Portugal", null },
                    { 7, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9925), null, true, "Spain", null },
                    { 8, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9925), null, true, "Turkey", null },
                    { 9, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9926), null, true, "United Kingdom", null },
                    { 10, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9926), null, true, "United States", null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9908), true, "Male", null },
                    { 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9909), true, "Female", null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryId", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9942), true, "Sarajevo", null },
                    { 2, 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9943), true, "Mostar", null },
                    { 3, 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9943), true, "Banja Luka", null },
                    { 4, 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9944), true, "Jajce", null },
                    { 5, 1, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9945), true, "Trebinje", null },
                    { 6, 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9945), true, "Paris", null },
                    { 7, 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9946), true, "Lyon", null },
                    { 8, 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9946), true, "Nice", null },
                    { 9, 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9947), true, "Cannes", null },
                    { 10, 2, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9947), true, "Marseille", null },
                    { 11, 3, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9948), true, "Berlin", null },
                    { 12, 3, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9948), true, "Munich", null },
                    { 13, 3, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9949), true, "Hamburg", null },
                    { 14, 3, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9949), true, "Cologne", null },
                    { 15, 3, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9950), true, "Frankfurt", null },
                    { 16, 4, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9950), true, "Venice", null },
                    { 17, 4, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9951), true, "Rome", null },
                    { 18, 4, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9951), true, "Milan", null },
                    { 19, 4, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9952), true, "Florence", null },
                    { 20, 4, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9952), true, "Turin", null },
                    { 21, 5, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9953), true, "Oslo", null },
                    { 22, 5, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9953), true, "Bergen", null },
                    { 23, 5, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9954), true, "Tromsø", null },
                    { 24, 5, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9954), true, "Stavanger", null },
                    { 25, 5, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9955), true, "Trondheim", null },
                    { 26, 6, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9955), true, "Lisbon", null },
                    { 27, 6, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9956), true, "Porto", null },
                    { 28, 6, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9956), true, "Faro", null },
                    { 29, 6, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9957), true, "Coimbra", null },
                    { 30, 6, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9958), true, "Braga", null },
                    { 31, 7, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9958), true, "Barcelona", null },
                    { 32, 7, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9959), true, "Madrid", null },
                    { 33, 7, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9959), true, "Seville", null },
                    { 34, 7, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9960), true, "Valencia", null },
                    { 35, 7, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9960), true, "Bilbao", null },
                    { 36, 8, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9961), true, "Istanbul", null },
                    { 37, 8, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9961), true, "Ankara", null },
                    { 38, 8, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9962), true, "Izmir", null },
                    { 39, 8, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9962), true, "Antalya", null },
                    { 40, 8, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9963), true, "Bodrum", null },
                    { 41, 9, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9963), true, "London", null },
                    { 42, 9, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9964), true, "Edinburgh", null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "CountryId", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 43, 9, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9964), true, "Manchester", null },
                    { 44, 9, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9965), true, "Bristol", null },
                    { 45, 9, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9965), true, "Brighton", null },
                    { 46, 10, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9966), true, "New Orleans", null },
                    { 47, 10, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9966), true, "Austin", null },
                    { 48, 10, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9967), true, "New York", null },
                    { 49, 10, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9967), true, "Los Angeles", null },
                    { 50, 10, new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9968), true, "Miami", null }
                });

            migrationBuilder.InsertData(
                table: "MyAppUsers",
                columns: new[] { "ID", "CityId", "CreatedAt", "Email", "FailedLoginAttempts", "FirstName", "GenderId", "IsActive", "IsAdmin", "IsUser", "LastName", "LockoutUntil", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "example1@gmail.com", 0, "Denis", 1, true, true, false, "Mušić", null, "ffLsFTORZZOpXxG+GzkwZLLKHwlW96r1JmlUFtdUf2Y=", "ytyXFy/ujquLHSXuRZbOAjABiZhRZeaRjO2Ite5z8E0=", "+387 00 000 000", null, "admin" },
                    { 2, 2, new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "example2@gmail.com", 0, "Adil", 1, true, false, true, "Joldić", null, "HX0Fs/MUcgMknbLsngCUXXmY4GaWDmQs7roYR3CanbQ=", "Y2GZ9Picau4kHCl16FIfqe5ODTbAK73WzPRFbqeafrk=", "+387 00 000 000", null, "user" },
                    { 3, 1, new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "hana.haljevac@edu.fit.com", 0, "Hana", 2, true, true, false, "Heljevac", null, "sOwZwZ8z+/oz2yly2rjOGOdvG67et737ZTN9XrImOtU=", "XA9aCB2SuUmLa5wQZITSS1jKxRGO899BlOOC7POzREA=", "+387 00 000 000", null, "hana" },
                    { 4, 2, new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "aida.patak@edu.fit.com", 0, "Aida", 2, true, false, true, "Patak", null, "af/U9d6iEvBLsnLmay15OV8P5vVUrSbMB+olQv8GXs8=", "ICQ2jKrBY95elkzaYmLhtyzN5aMbbdOqoPsPj3eRen0=", "+387 00 000 000", null, "aida" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name_CountryId",
                table: "Cities",
                columns: new[] { "Name", "CountryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyAppUsers_CityId",
                table: "MyAppUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_MyAppUsers_Email",
                table: "MyAppUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyAppUsers_GenderId",
                table: "MyAppUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_MyAppUsers_Username",
                table: "MyAppUsers",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyAuthenticationTokens_MyAppUserId",
                table: "MyAuthenticationTokens",
                column: "MyAppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyAuthenticationTokens");

            migrationBuilder.DropTable(
                name: "MyAppUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
