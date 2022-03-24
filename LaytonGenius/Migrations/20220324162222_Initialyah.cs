using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonGenius.Migrations
{
    public partial class Initialyah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailableTimes",
                columns: table => new
                {
                    DateID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableTimes", x => x.DateID);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false),
                    DateID = table.Column<int>(nullable: false),
                    AvailableDateID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppId);
                    table.ForeignKey(
                        name: "FK_Appointments_AvailableTimes_AvailableDateID",
                        column: x => x.AvailableDateID,
                        principalTable: "AvailableTimes",
                        principalColumn: "DateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 1, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 2, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 3, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 4, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 5, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 6, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 7, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 8, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 9, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 10, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 11, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 12, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "DateID", "Date" },
                values: new object[] { 13, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AvailableDateID",
                table: "Appointments",
                column: "AvailableDateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AvailableTimes");
        }
    }
}
