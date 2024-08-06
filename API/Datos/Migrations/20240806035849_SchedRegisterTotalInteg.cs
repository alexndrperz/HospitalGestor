using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class SchedRegisterTotalInteg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegister_Doctors_DoctorsId",
                table: "SchedulesRegister");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchedulesRegister",
                table: "SchedulesRegister");

            migrationBuilder.DropIndex(
                name: "IX_SchedulesRegister_DoctorsId",
                table: "SchedulesRegister");

            migrationBuilder.DropColumn(
                name: "DoctorsId",
                table: "SchedulesRegister");

            migrationBuilder.RenameTable(
                name: "SchedulesRegister",
                newName: "SchedulesRegisters");

            migrationBuilder.AddColumn<int>(
                name: "day_id",
                table: "SchedulesRegisters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "doctor_id",
                table: "SchedulesRegisters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "finalHour_id",
                table: "SchedulesRegisters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "initHour_id",
                table: "SchedulesRegisters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchedulesRegisters",
                table: "SchedulesRegisters",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.id);
                });

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
                name: "IX_SchedulesRegisters_day_id",
                table: "SchedulesRegisters",
                column: "day_id");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulesRegisters_doctor_id",
                table: "SchedulesRegisters",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulesRegisters_finalHour_id",
                table: "SchedulesRegisters",
                column: "finalHour_id");

            migrationBuilder.CreateIndex(
                name: "IX_SchedulesRegisters_initHour_id",
                table: "SchedulesRegisters",
                column: "initHour_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulesRegisters_Days_day_id",
                table: "SchedulesRegisters",
                column: "day_id",
                principalTable: "Days",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulesRegisters_Doctors_doctor_id",
                table: "SchedulesRegisters",
                column: "doctor_id",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_Days_day_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_Doctors_doctor_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_finalHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_SchedulesRegisters_SchedulesSystems_initHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchedulesRegisters",
                table: "SchedulesRegisters");

            migrationBuilder.DropIndex(
                name: "IX_SchedulesRegisters_day_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropIndex(
                name: "IX_SchedulesRegisters_doctor_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropIndex(
                name: "IX_SchedulesRegisters_finalHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropIndex(
                name: "IX_SchedulesRegisters_initHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropColumn(
                name: "day_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropColumn(
                name: "doctor_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropColumn(
                name: "finalHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.DropColumn(
                name: "initHour_id",
                table: "SchedulesRegisters");

            migrationBuilder.RenameTable(
                name: "SchedulesRegisters",
                newName: "SchedulesRegister");

            migrationBuilder.AddColumn<int>(
                name: "DoctorsId",
                table: "SchedulesRegister",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchedulesRegister",
                table: "SchedulesRegister",
                column: "id");

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

            migrationBuilder.CreateIndex(
                name: "IX_SchedulesRegister_DoctorsId",
                table: "SchedulesRegister",
                column: "DoctorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SchedulesRegister_Doctors_DoctorsId",
                table: "SchedulesRegister",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }
    }
}
