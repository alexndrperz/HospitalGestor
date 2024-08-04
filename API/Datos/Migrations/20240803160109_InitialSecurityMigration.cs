using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class InitialSecurityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    creadoEn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    role_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_role_id",
                        column: x => x.role_id,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Doctor" },
                    { 3, "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "creadoEn", "password", "role_id", "username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 3, 12, 1, 7, 611, DateTimeKind.Local).AddTicks(1140), "12345", 1, "admin_test" },
                    { 2, new DateTime(2024, 8, 3, 12, 1, 7, 611, DateTimeKind.Local).AddTicks(1160), "12345", 2, "doctor_test" },
                    { 3, new DateTime(2024, 8, 3, 12, 1, 7, 611, DateTimeKind.Local).AddTicks(1163), "12345", 3, "client_test" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_role_id",
                table: "Users",
                column: "role_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
