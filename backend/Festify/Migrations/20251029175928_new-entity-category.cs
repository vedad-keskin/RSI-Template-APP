using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Festify.Migrations
{
    public partial class newentitycategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedAt", "Description", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(547), "...", true, "Desserts", null },
                    { 2, new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(548), "...", true, "Main Dish", null }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 59, 27, 997, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IgMYwzB6X5PuYBmawgLgpI9yvs6hBXyjMsbSsekdN78=", "LW1OrdymeTyhGY+mZtAX1n+7lT+6KeiC5V+OBYDxo1M=" });

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ZveHSuFlPVMq1PfKAIbSEwOCvru5aREntG+5TwLfG9k=", "BGi8INa959tQtpm8LcUNtG9wEYFrhzAwrbYCC8I40OU=" });

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UPv2Fk73/0jhr3jBkqPdcma5ercKY97a3kAGm+gh2oA=", "sL8mF4ZFomnGdoN7tlIYOL/j3MjmNquASbH1LNeTHiE=" });

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "vClg9ZMsFfEDwvsOtuKcSHTD3ZEFQbkbT1uiT3z4LqM=", "TXV14TzPAbApcdXxF/QtSsHDy+4KlHyUuinfOlz2vvs=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 29, 17, 44, 49, 258, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ffLsFTORZZOpXxG+GzkwZLLKHwlW96r1JmlUFtdUf2Y=", "ytyXFy/ujquLHSXuRZbOAjABiZhRZeaRjO2Ite5z8E0=" });

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HX0Fs/MUcgMknbLsngCUXXmY4GaWDmQs7roYR3CanbQ=", "Y2GZ9Picau4kHCl16FIfqe5ODTbAK73WzPRFbqeafrk=" });

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "sOwZwZ8z+/oz2yly2rjOGOdvG67et737ZTN9XrImOtU=", "XA9aCB2SuUmLa5wQZITSS1jKxRGO899BlOOC7POzREA=" });

            migrationBuilder.UpdateData(
                table: "MyAppUsers",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "af/U9d6iEvBLsnLmay15OV8P5vVUrSbMB+olQv8GXs8=", "ICQ2jKrBY95elkzaYmLhtyzN5aMbbdOqoPsPj3eRen0=" });
        }
    }
}
