using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class ClientIntegrated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                    table.ForeignKey(
                        name: "FK_Client_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 1, 31, 4, 156, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 1, 31, 4, 156, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 1, 31, 4, 156, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.CreateIndex(
                name: "IX_Client_user_id",
                table: "Client",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 0, 51, 13, 345, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 0, 51, 13, 345, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 0, 51, 13, 345, DateTimeKind.Local).AddTicks(5379));
        }
    }
}
