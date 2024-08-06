using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class SchemeSched : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_finalHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_initHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropIndex(
                name: "IX_SchedulesRegisters_finalHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropColumn(
                name: "finalHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.RenameColumn(
                name: "initHour_id",
                table: "SchedulesRegisters",
                newName: "sched_id");

            migrationBuilder.RenameIndex(
                name: "IX_SchedulesRegisters_initHour_id",
                table: "SchedulesRegisters",
                newName: "IX_SchedulesRegisters_sched_id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_sched_id",
                table: "SchedulesRegisters",
                column: "sched_id",
                principalTable: "SchedulesSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_sched_id",
                table: "SchedulesRegisters");

            migrationBuilder.RenameColumn(
                name: "sched_id",
                table: "SchedulesRegisters",
                newName: "initHour_id");

            migrationBuilder.RenameIndex(
                name: "IX_SchedulesRegisters_sched_id",
                table: "SchedulesRegisters",
                newName: "IX_SchedulesRegisters_initHour_id");

            migrationBuilder.AddColumn<int>(
                name: "finalHour_id",
                table: "SchedulesRegisters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "creadoEn",
                value: new DateTime(2024, 8, 5, 23, 58, 48, 501, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2,
                column: "creadoEn",
                value: new DateTime(2024, 8, 5, 23, 58, 48, 501, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3,
                column: "creadoEn",
                value: new DateTime(2024, 8, 5, 23, 58, 48, 501, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.CreateIndex(
                name: "IX_SchedulesRegisters_finalHour_id",
                table: "SchedulesRegisters",
                column: "finalHour_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_finalHour_id",
                table: "SchedulesRegisters",
                column: "finalHour_id",
                principalTable: "SchedulesSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_initHour_id",
                table: "SchedulesRegisters",
                column: "initHour_id",
                principalTable: "SchedulesSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
