using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class DataReay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "dataReady",
                table: "Doctors",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "especiality_id",
                table: "Doctors",
                type: "INTEGER",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "dataReady",
                table: "Client",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 2, 14, 29, 42, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 2, 14, 29, 42, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "creadoEn",
                value: new DateTime(2024, 8, 6, 2, 14, 29, 42, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_especiality_id",
                table: "Doctors",
                column: "especiality_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Especialities_especiality_id",
                table: "Doctors",
                column: "especiality_id",
                principalTable: "Especialities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Especialities_especiality_id",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_especiality_id",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "dataReady",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "especiality_id",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "dataReady",
                table: "Client");

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
        }
    }
}
