using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class addDuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(2120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0f2cfd03-b1f5-46a1-886d-a1c8148da00d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f06b00da-ca7b-4741-8e2f-91f6040cede3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 334, DateTimeKind.Local).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "93e68f37-b196-4d63-9e63-b323aaa3e0e5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "430ed8ed-2cb5-46f0-9331-5abbcc3adf8b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ed8ccd25-a581-4a6a-97ca-47c35b01277c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "34bb58bb-6557-417e-bfa7-f01aa99148f0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "12bd1d61-842e-437e-9a2c-8426edfa9cde",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "34ace022-a72d-47db-b2d4-693357dd901d");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(9270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f06b00da-ca7b-4741-8e2f-91f6040cede3",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0f2cfd03-b1f5-46a1-886d-a1c8148da00d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(4030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 334, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "430ed8ed-2cb5-46f0-9331-5abbcc3adf8b",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "93e68f37-b196-4d63-9e63-b323aaa3e0e5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "34bb58bb-6557-417e-bfa7-f01aa99148f0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ed8ccd25-a581-4a6a-97ca-47c35b01277c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "34ace022-a72d-47db-b2d4-693357dd901d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "12bd1d61-842e-437e-9a2c-8426edfa9cde");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));
        }
    }
}
