using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class SchedIntegrated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchedulesSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    initHour = table.Column<DateTime>(type: "TEXT", nullable: false),
                    finalHour = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulesSystems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "creadoEn",
                value: new DateTime(2024, 8, 5, 19, 46, 41, 695, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "creadoEn",
                value: new DateTime(2024, 8, 5, 19, 46, 41, 695, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "creadoEn",
                value: new DateTime(2024, 8, 5, 19, 46, 41, 695, DateTimeKind.Local).AddTicks(4087));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchedulesSystems");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "creadoEn",
                value: new DateTime(2024, 8, 3, 18, 3, 14, 827, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "creadoEn",
                value: new DateTime(2024, 8, 3, 18, 3, 14, 827, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "creadoEn",
                value: new DateTime(2024, 8, 3, 18, 3, 14, 827, DateTimeKind.Local).AddTicks(1705));
        }
    }
}
