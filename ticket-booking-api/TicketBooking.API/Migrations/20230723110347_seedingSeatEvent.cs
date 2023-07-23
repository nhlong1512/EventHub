using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class seedingSeatEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "8a38fd6a-2d4e-40ec-95df-a7e3df4d78d2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0f2cfd03-b1f5-46a1-886d-a1c8148da00d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 610, DateTimeKind.Local).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 334, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f79276b1-a3f5-4274-95d5-74f2bed4637b",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "93e68f37-b196-4d63-9e63-b323aaa3e0e5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "12762196-b87a-4307-bec2-ce93f8e9878e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ed8ccd25-a581-4a6a-97ca-47c35b01277c");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "558296bc-c888-4c85-be03-9eb6aadc55fb",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "12bd1d61-842e-437e-9a2c-8426edfa9cde");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), 100000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), 100000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), 100000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), 100000 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "A1", null, "A1", null },
                    { "A10", null, "A10", null },
                    { "A11", null, "A11", null },
                    { "A12", null, "A12", null },
                    { "A13", null, "A13", null },
                    { "A14", null, "A14", null },
                    { "A15", null, "A15", null },
                    { "A16", null, "A16", null },
                    { "A17", null, "A17", null },
                    { "A18", null, "A18", null },
                    { "A2", null, "A2", null },
                    { "A3", null, "A3", null },
                    { "A4", null, "A4", null },
                    { "A5", null, "A5", null },
                    { "A6", null, "A6", null },
                    { "A7", null, "A7", null },
                    { "A8", null, "A8", null },
                    { "A9", null, "A9", null },
                    { "B1", null, "B1", null },
                    { "B10", null, "B10", null },
                    { "B11", null, "B11", null },
                    { "B12", null, "B12", null },
                    { "B13", null, "B13", null },
                    { "B14", null, "B14", null },
                    { "B15", null, "B15", null },
                    { "B16", null, "B16", null },
                    { "B17", null, "B17", null },
                    { "B18", null, "B18", null },
                    { "B2", null, "B2", null },
                    { "B3", null, "B3", null },
                    { "B4", null, "B4", null },
                    { "B5", null, "B5", null },
                    { "B6", null, "B6", null },
                    { "B7", null, "B7", null },
                    { "B8", null, "B8", null },
                    { "B9", null, "B9", null }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "DeletedAt", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { "C1", null, "C1", 1, null },
                    { "C10", null, "C10", 1, null },
                    { "C11", null, "C11", 1, null },
                    { "C12", null, "C12", 1, null },
                    { "C13", null, "C13", 1, null },
                    { "C14", null, "C14", 1, null },
                    { "C15", null, "C15", 1, null },
                    { "C16", null, "C16", 1, null },
                    { "C17", null, "C17", 1, null },
                    { "C18", null, "C18", 1, null },
                    { "C2", null, "C2", 1, null },
                    { "C3", null, "C3", 1, null },
                    { "C4", null, "C4", 1, null },
                    { "C5", null, "C5", 1, null },
                    { "C6", null, "C6", 1, null },
                    { "C7", null, "C7", 1, null },
                    { "C8", null, "C8", 1, null },
                    { "C9", null, "C9", 1, null },
                    { "D1", null, "D1", 1, null },
                    { "D10", null, "D10", 1, null },
                    { "D11", null, "D11", 1, null },
                    { "D12", null, "D12", 1, null },
                    { "D13", null, "D13", 1, null },
                    { "D14", null, "D14", 1, null },
                    { "D15", null, "D15", 1, null },
                    { "D16", null, "D16", 1, null },
                    { "D17", null, "D17", 1, null },
                    { "D18", null, "D18", 1, null },
                    { "D2", null, "D2", 1, null },
                    { "D3", null, "D3", 1, null },
                    { "D4", null, "D4", 1, null },
                    { "D5", null, "D5", 1, null },
                    { "D6", null, "D6", 1, null },
                    { "D7", null, "D7", 1, null },
                    { "D8", null, "D8", 1, null },
                    { "D9", null, "D9", 1, null },
                    { "E1", null, "E1", 2, null },
                    { "E10", null, "E10", 2, null },
                    { "E11", null, "E11", 2, null },
                    { "E12", null, "E12", 2, null },
                    { "E13", null, "E13", 2, null },
                    { "E14", null, "E14", 2, null },
                    { "E15", null, "E15", 2, null },
                    { "E16", null, "E16", 2, null },
                    { "E17", null, "E17", 2, null },
                    { "E18", null, "E18", 2, null },
                    { "E2", null, "E2", 2, null },
                    { "E3", null, "E3", 2, null },
                    { "E4", null, "E4", 2, null },
                    { "E5", null, "E5", 2, null },
                    { "E6", null, "E6", 2, null },
                    { "E7", null, "E7", 2, null },
                    { "E8", null, "E8", 2, null },
                    { "E9", null, "E9", 2, null },
                    { "F1", null, "F1", 2, null },
                    { "F10", null, "F10", 2, null },
                    { "F11", null, "F11", 2, null },
                    { "F12", null, "F12", 2, null },
                    { "F13", null, "F13", 2, null },
                    { "F14", null, "F14", 2, null },
                    { "F15", null, "F15", 2, null },
                    { "F16", null, "F16", 2, null },
                    { "F17", null, "F17", 2, null },
                    { "F18", null, "F18", 2, null },
                    { "F2", null, "F2", 2, null },
                    { "F3", null, "F3", 2, null },
                    { "F4", null, "F4", 2, null },
                    { "F5", null, "F5", 2, null },
                    { "F6", null, "F6", 2, null },
                    { "F7", null, "F7", 2, null },
                    { "F8", null, "F8", 2, null },
                    { "F9", null, "F9", 2, null }
                });

            migrationBuilder.InsertData(
                table: "SeatEvent",
                columns: new[] { "EventId", "SeatId", "Price" },
                values: new object[,]
                {
                    { "e1", "A1", 60000 },
                    { "e1", "A10", 60000 },
                    { "e1", "A11", 60000 },
                    { "e1", "A12", 60000 },
                    { "e1", "A13", 60000 },
                    { "e1", "A14", 60000 },
                    { "e1", "A15", 60000 },
                    { "e1", "A16", 60000 },
                    { "e1", "A17", 60000 },
                    { "e1", "A18", 60000 },
                    { "e1", "A2", 60000 },
                    { "e1", "A3", 60000 },
                    { "e1", "A4", 60000 },
                    { "e1", "A5", 60000 },
                    { "e1", "A6", 60000 },
                    { "e1", "A7", 60000 },
                    { "e1", "A8", 60000 },
                    { "e1", "A9", 60000 },
                    { "e1", "B1", 60000 },
                    { "e1", "B10", 60000 },
                    { "e1", "B11", 60000 },
                    { "e1", "B12", 60000 },
                    { "e1", "B13", 60000 },
                    { "e1", "B14", 60000 },
                    { "e1", "B15", 60000 },
                    { "e1", "B16", 60000 },
                    { "e1", "B17", 60000 },
                    { "e1", "B18", 60000 },
                    { "e1", "B2", 60000 },
                    { "e1", "B3", 60000 },
                    { "e1", "B4", 60000 },
                    { "e1", "B5", 60000 },
                    { "e1", "B6", 60000 },
                    { "e1", "B7", 60000 },
                    { "e1", "B8", 60000 },
                    { "e1", "B9", 60000 },
                    { "e1", "C1", 60000 },
                    { "e1", "C10", 60000 },
                    { "e1", "C11", 60000 },
                    { "e1", "C12", 60000 },
                    { "e1", "C13", 60000 },
                    { "e1", "C14", 60000 },
                    { "e1", "C15", 60000 },
                    { "e1", "C16", 60000 },
                    { "e1", "C17", 60000 },
                    { "e1", "C18", 60000 },
                    { "e1", "C2", 60000 },
                    { "e1", "C3", 60000 },
                    { "e1", "C4", 60000 },
                    { "e1", "C5", 60000 },
                    { "e1", "C6", 60000 },
                    { "e1", "C7", 60000 },
                    { "e1", "C8", 60000 },
                    { "e1", "C9", 60000 },
                    { "e1", "D1", 60000 },
                    { "e1", "D10", 60000 },
                    { "e1", "D11", 60000 },
                    { "e1", "D12", 60000 },
                    { "e1", "D13", 60000 },
                    { "e1", "D14", 60000 },
                    { "e1", "D15", 60000 },
                    { "e1", "D16", 60000 },
                    { "e1", "D17", 60000 },
                    { "e1", "D18", 60000 },
                    { "e1", "D2", 60000 },
                    { "e1", "D3", 60000 },
                    { "e1", "D4", 60000 },
                    { "e1", "D5", 60000 },
                    { "e1", "D6", 60000 },
                    { "e1", "D7", 60000 },
                    { "e1", "D8", 60000 },
                    { "e1", "D9", 60000 },
                    { "e1", "E1", 60000 },
                    { "e1", "E10", 60000 },
                    { "e1", "E11", 60000 },
                    { "e1", "E12", 60000 },
                    { "e1", "E13", 60000 },
                    { "e1", "E14", 60000 },
                    { "e1", "E15", 60000 },
                    { "e1", "E16", 60000 },
                    { "e1", "E17", 60000 },
                    { "e1", "E18", 60000 },
                    { "e1", "E2", 60000 },
                    { "e1", "E3", 60000 },
                    { "e1", "E4", 60000 },
                    { "e1", "E5", 60000 },
                    { "e1", "E6", 60000 },
                    { "e1", "E7", 60000 },
                    { "e1", "E8", 60000 },
                    { "e1", "E9", 60000 },
                    { "e1", "F1", 60000 },
                    { "e1", "F10", 60000 },
                    { "e1", "F11", 60000 },
                    { "e1", "F12", 60000 },
                    { "e1", "F13", 60000 },
                    { "e1", "F14", 60000 },
                    { "e1", "F15", 60000 },
                    { "e1", "F16", 60000 },
                    { "e1", "F17", 60000 },
                    { "e1", "F18", 60000 },
                    { "e1", "F2", 60000 },
                    { "e1", "F3", 60000 },
                    { "e1", "F4", 60000 },
                    { "e1", "F5", 60000 },
                    { "e1", "F6", 60000 },
                    { "e1", "F7", 60000 },
                    { "e1", "F8", 60000 },
                    { "e1", "F9", 60000 },
                    { "e2", "A1", 70000 },
                    { "e2", "A10", 70000 },
                    { "e2", "A11", 70000 },
                    { "e2", "A12", 70000 },
                    { "e2", "A13", 70000 },
                    { "e2", "A14", 70000 },
                    { "e2", "A15", 70000 },
                    { "e2", "A16", 70000 },
                    { "e2", "A17", 70000 },
                    { "e2", "A18", 70000 },
                    { "e2", "A2", 70000 },
                    { "e2", "A3", 70000 },
                    { "e2", "A4", 70000 },
                    { "e2", "A5", 70000 },
                    { "e2", "A6", 70000 },
                    { "e2", "A7", 70000 },
                    { "e2", "A8", 70000 },
                    { "e2", "A9", 70000 },
                    { "e2", "B1", 70000 },
                    { "e2", "B10", 70000 },
                    { "e2", "B11", 70000 },
                    { "e2", "B12", 70000 },
                    { "e2", "B13", 70000 },
                    { "e2", "B14", 70000 },
                    { "e2", "B15", 70000 },
                    { "e2", "B16", 70000 },
                    { "e2", "B17", 70000 },
                    { "e2", "B18", 70000 },
                    { "e2", "B2", 70000 },
                    { "e2", "B3", 70000 },
                    { "e2", "B4", 70000 },
                    { "e2", "B5", 70000 },
                    { "e2", "B6", 70000 },
                    { "e2", "B7", 70000 },
                    { "e2", "B8", 70000 },
                    { "e2", "B9", 70000 },
                    { "e2", "C1", 70000 },
                    { "e2", "C10", 70000 },
                    { "e2", "C11", 70000 },
                    { "e2", "C12", 70000 },
                    { "e2", "C13", 70000 },
                    { "e2", "C14", 70000 },
                    { "e2", "C15", 70000 },
                    { "e2", "C16", 70000 },
                    { "e2", "C17", 70000 },
                    { "e2", "C18", 70000 },
                    { "e2", "C2", 70000 },
                    { "e2", "C3", 70000 },
                    { "e2", "C4", 70000 },
                    { "e2", "C5", 70000 },
                    { "e2", "C6", 70000 },
                    { "e2", "C7", 70000 },
                    { "e2", "C8", 70000 },
                    { "e2", "C9", 70000 },
                    { "e2", "D1", 70000 },
                    { "e2", "D10", 70000 },
                    { "e2", "D11", 70000 },
                    { "e2", "D12", 70000 },
                    { "e2", "D13", 70000 },
                    { "e2", "D14", 70000 },
                    { "e2", "D15", 70000 },
                    { "e2", "D16", 70000 },
                    { "e2", "D17", 70000 },
                    { "e2", "D18", 70000 },
                    { "e2", "D2", 70000 },
                    { "e2", "D3", 70000 },
                    { "e2", "D4", 70000 },
                    { "e2", "D5", 70000 },
                    { "e2", "D6", 70000 },
                    { "e2", "D7", 70000 },
                    { "e2", "D8", 70000 },
                    { "e2", "D9", 70000 },
                    { "e2", "E1", 70000 },
                    { "e2", "E10", 70000 },
                    { "e2", "E11", 70000 },
                    { "e2", "E12", 70000 },
                    { "e2", "E13", 70000 },
                    { "e2", "E14", 70000 },
                    { "e2", "E15", 70000 },
                    { "e2", "E16", 70000 },
                    { "e2", "E17", 70000 },
                    { "e2", "E18", 70000 },
                    { "e2", "E2", 70000 },
                    { "e2", "E3", 70000 },
                    { "e2", "E4", 70000 },
                    { "e2", "E5", 70000 },
                    { "e2", "E6", 70000 },
                    { "e2", "E7", 70000 },
                    { "e2", "E8", 70000 },
                    { "e2", "E9", 70000 },
                    { "e2", "F1", 70000 },
                    { "e2", "F10", 70000 },
                    { "e2", "F11", 70000 },
                    { "e2", "F12", 70000 },
                    { "e2", "F13", 70000 },
                    { "e2", "F14", 70000 },
                    { "e2", "F15", 70000 },
                    { "e2", "F16", 70000 },
                    { "e2", "F17", 70000 },
                    { "e2", "F18", 70000 },
                    { "e2", "F2", 70000 },
                    { "e2", "F3", 70000 },
                    { "e2", "F4", 70000 },
                    { "e2", "F5", 70000 },
                    { "e2", "F6", 70000 },
                    { "e2", "F7", 70000 },
                    { "e2", "F8", 70000 },
                    { "e2", "F9", 70000 },
                    { "e3", "A1", 100000 },
                    { "e3", "A10", 100000 },
                    { "e3", "A11", 100000 },
                    { "e3", "A12", 100000 },
                    { "e3", "A13", 100000 },
                    { "e3", "A14", 100000 },
                    { "e3", "A15", 100000 },
                    { "e3", "A16", 100000 },
                    { "e3", "A17", 100000 },
                    { "e3", "A18", 100000 },
                    { "e3", "A2", 100000 },
                    { "e3", "A3", 100000 },
                    { "e3", "A4", 100000 },
                    { "e3", "A5", 100000 },
                    { "e3", "A6", 100000 },
                    { "e3", "A7", 100000 },
                    { "e3", "A8", 100000 },
                    { "e3", "A9", 100000 },
                    { "e3", "B1", 100000 },
                    { "e3", "B10", 100000 },
                    { "e3", "B11", 100000 },
                    { "e3", "B12", 100000 },
                    { "e3", "B13", 100000 },
                    { "e3", "B14", 100000 },
                    { "e3", "B15", 100000 },
                    { "e3", "B16", 100000 },
                    { "e3", "B17", 100000 },
                    { "e3", "B18", 100000 },
                    { "e3", "B2", 100000 },
                    { "e3", "B3", 100000 },
                    { "e3", "B4", 100000 },
                    { "e3", "B5", 100000 },
                    { "e3", "B6", 100000 },
                    { "e3", "B7", 100000 },
                    { "e3", "B8", 100000 },
                    { "e3", "B9", 100000 },
                    { "e3", "C1", 100000 },
                    { "e3", "C10", 100000 },
                    { "e3", "C11", 100000 },
                    { "e3", "C12", 100000 },
                    { "e3", "C13", 100000 },
                    { "e3", "C14", 100000 },
                    { "e3", "C15", 100000 },
                    { "e3", "C16", 100000 },
                    { "e3", "C17", 100000 },
                    { "e3", "C18", 100000 },
                    { "e3", "C2", 100000 },
                    { "e3", "C3", 100000 },
                    { "e3", "C4", 100000 },
                    { "e3", "C5", 100000 },
                    { "e3", "C6", 100000 },
                    { "e3", "C7", 100000 },
                    { "e3", "C8", 100000 },
                    { "e3", "C9", 100000 },
                    { "e3", "D1", 100000 },
                    { "e3", "D10", 100000 },
                    { "e3", "D11", 100000 },
                    { "e3", "D12", 100000 },
                    { "e3", "D13", 100000 },
                    { "e3", "D14", 100000 },
                    { "e3", "D15", 100000 },
                    { "e3", "D16", 100000 },
                    { "e3", "D17", 100000 },
                    { "e3", "D18", 100000 },
                    { "e3", "D2", 100000 },
                    { "e3", "D3", 100000 },
                    { "e3", "D4", 100000 },
                    { "e3", "D5", 100000 },
                    { "e3", "D6", 100000 },
                    { "e3", "D7", 100000 },
                    { "e3", "D8", 100000 },
                    { "e3", "D9", 100000 },
                    { "e3", "E1", 100000 },
                    { "e3", "E10", 100000 },
                    { "e3", "E11", 100000 },
                    { "e3", "E12", 100000 },
                    { "e3", "E13", 100000 },
                    { "e3", "E14", 100000 },
                    { "e3", "E15", 100000 },
                    { "e3", "E16", 100000 },
                    { "e3", "E17", 100000 },
                    { "e3", "E18", 100000 },
                    { "e3", "E2", 100000 },
                    { "e3", "E3", 100000 },
                    { "e3", "E4", 100000 },
                    { "e3", "E5", 100000 },
                    { "e3", "E6", 100000 },
                    { "e3", "E7", 100000 },
                    { "e3", "E8", 100000 },
                    { "e3", "E9", 100000 },
                    { "e3", "F1", 100000 },
                    { "e3", "F10", 100000 },
                    { "e3", "F11", 100000 },
                    { "e3", "F12", 100000 },
                    { "e3", "F13", 100000 },
                    { "e3", "F14", 100000 },
                    { "e3", "F15", 100000 },
                    { "e3", "F16", 100000 },
                    { "e3", "F17", 100000 },
                    { "e3", "F18", 100000 },
                    { "e3", "F2", 100000 },
                    { "e3", "F3", 100000 },
                    { "e3", "F4", 100000 },
                    { "e3", "F5", 100000 },
                    { "e3", "F6", 100000 },
                    { "e3", "F7", 100000 },
                    { "e3", "F8", 100000 },
                    { "e3", "F9", 100000 },
                    { "e4", "A1", 100000 },
                    { "e4", "A10", 100000 },
                    { "e4", "A11", 100000 },
                    { "e4", "A12", 100000 },
                    { "e4", "A13", 100000 },
                    { "e4", "A14", 100000 },
                    { "e4", "A15", 100000 },
                    { "e4", "A16", 100000 },
                    { "e4", "A17", 100000 },
                    { "e4", "A18", 100000 },
                    { "e4", "A2", 100000 },
                    { "e4", "A3", 100000 },
                    { "e4", "A4", 100000 },
                    { "e4", "A5", 100000 },
                    { "e4", "A6", 100000 },
                    { "e4", "A7", 100000 },
                    { "e4", "A8", 100000 },
                    { "e4", "A9", 100000 },
                    { "e4", "B1", 100000 },
                    { "e4", "B10", 100000 },
                    { "e4", "B11", 100000 },
                    { "e4", "B12", 100000 },
                    { "e4", "B13", 100000 },
                    { "e4", "B14", 100000 },
                    { "e4", "B15", 100000 },
                    { "e4", "B16", 100000 },
                    { "e4", "B17", 100000 },
                    { "e4", "B18", 100000 },
                    { "e4", "B2", 100000 },
                    { "e4", "B3", 100000 },
                    { "e4", "B4", 100000 },
                    { "e4", "B5", 100000 },
                    { "e4", "B6", 100000 },
                    { "e4", "B7", 100000 },
                    { "e4", "B8", 100000 },
                    { "e4", "B9", 100000 },
                    { "e4", "C1", 100000 },
                    { "e4", "C10", 100000 },
                    { "e4", "C11", 100000 },
                    { "e4", "C12", 100000 },
                    { "e4", "C13", 100000 },
                    { "e4", "C14", 100000 },
                    { "e4", "C15", 100000 },
                    { "e4", "C16", 100000 },
                    { "e4", "C17", 100000 },
                    { "e4", "C18", 100000 },
                    { "e4", "C2", 100000 },
                    { "e4", "C3", 100000 },
                    { "e4", "C4", 100000 },
                    { "e4", "C5", 100000 },
                    { "e4", "C6", 100000 },
                    { "e4", "C7", 100000 },
                    { "e4", "C8", 100000 },
                    { "e4", "C9", 100000 },
                    { "e4", "D1", 100000 },
                    { "e4", "D10", 100000 },
                    { "e4", "D11", 100000 },
                    { "e4", "D12", 100000 },
                    { "e4", "D13", 100000 },
                    { "e4", "D14", 100000 },
                    { "e4", "D15", 100000 },
                    { "e4", "D16", 100000 },
                    { "e4", "D17", 100000 },
                    { "e4", "D18", 100000 },
                    { "e4", "D2", 100000 },
                    { "e4", "D3", 100000 },
                    { "e4", "D4", 100000 },
                    { "e4", "D5", 100000 },
                    { "e4", "D6", 100000 },
                    { "e4", "D7", 100000 },
                    { "e4", "D8", 100000 },
                    { "e4", "D9", 100000 },
                    { "e4", "E1", 100000 },
                    { "e4", "E10", 100000 },
                    { "e4", "E11", 100000 },
                    { "e4", "E12", 100000 },
                    { "e4", "E13", 100000 },
                    { "e4", "E14", 100000 },
                    { "e4", "E15", 100000 },
                    { "e4", "E16", 100000 },
                    { "e4", "E17", 100000 },
                    { "e4", "E18", 100000 },
                    { "e4", "E2", 100000 },
                    { "e4", "E3", 100000 },
                    { "e4", "E4", 100000 },
                    { "e4", "E5", 100000 },
                    { "e4", "E6", 100000 },
                    { "e4", "E7", 100000 },
                    { "e4", "E8", 100000 },
                    { "e4", "E9", 100000 },
                    { "e4", "F1", 100000 },
                    { "e4", "F10", 100000 },
                    { "e4", "F11", 100000 },
                    { "e4", "F12", 100000 },
                    { "e4", "F13", 100000 },
                    { "e4", "F14", 100000 },
                    { "e4", "F15", 100000 },
                    { "e4", "F16", 100000 },
                    { "e4", "F17", 100000 },
                    { "e4", "F18", 100000 },
                    { "e4", "F2", 100000 },
                    { "e4", "F3", 100000 },
                    { "e4", "F4", 100000 },
                    { "e4", "F5", 100000 },
                    { "e4", "F6", 100000 },
                    { "e4", "F7", 100000 },
                    { "e4", "F8", 100000 },
                    { "e4", "F9", 100000 },
                    { "e5", "A1", 100000 },
                    { "e5", "A10", 100000 },
                    { "e5", "A11", 100000 },
                    { "e5", "A12", 100000 },
                    { "e5", "A13", 100000 },
                    { "e5", "A14", 100000 },
                    { "e5", "A15", 100000 },
                    { "e5", "A16", 100000 },
                    { "e5", "A17", 100000 },
                    { "e5", "A18", 100000 },
                    { "e5", "A2", 100000 },
                    { "e5", "A3", 100000 },
                    { "e5", "A4", 100000 },
                    { "e5", "A5", 100000 },
                    { "e5", "A6", 100000 },
                    { "e5", "A7", 100000 },
                    { "e5", "A8", 100000 },
                    { "e5", "A9", 100000 },
                    { "e5", "B1", 100000 },
                    { "e5", "B10", 100000 },
                    { "e5", "B11", 100000 },
                    { "e5", "B12", 100000 },
                    { "e5", "B13", 100000 },
                    { "e5", "B14", 100000 },
                    { "e5", "B15", 100000 },
                    { "e5", "B16", 100000 },
                    { "e5", "B17", 100000 },
                    { "e5", "B18", 100000 },
                    { "e5", "B2", 100000 },
                    { "e5", "B3", 100000 },
                    { "e5", "B4", 100000 },
                    { "e5", "B5", 100000 },
                    { "e5", "B6", 100000 },
                    { "e5", "B7", 100000 },
                    { "e5", "B8", 100000 },
                    { "e5", "B9", 100000 },
                    { "e5", "C1", 100000 },
                    { "e5", "C10", 100000 },
                    { "e5", "C11", 100000 },
                    { "e5", "C12", 100000 },
                    { "e5", "C13", 100000 },
                    { "e5", "C14", 100000 },
                    { "e5", "C15", 100000 },
                    { "e5", "C16", 100000 },
                    { "e5", "C17", 100000 },
                    { "e5", "C18", 100000 },
                    { "e5", "C2", 100000 },
                    { "e5", "C3", 100000 },
                    { "e5", "C4", 100000 },
                    { "e5", "C5", 100000 },
                    { "e5", "C6", 100000 },
                    { "e5", "C7", 100000 },
                    { "e5", "C8", 100000 },
                    { "e5", "C9", 100000 },
                    { "e5", "D1", 100000 },
                    { "e5", "D10", 100000 },
                    { "e5", "D11", 100000 },
                    { "e5", "D12", 100000 },
                    { "e5", "D13", 100000 },
                    { "e5", "D14", 100000 },
                    { "e5", "D15", 100000 },
                    { "e5", "D16", 100000 },
                    { "e5", "D17", 100000 },
                    { "e5", "D18", 100000 },
                    { "e5", "D2", 100000 },
                    { "e5", "D3", 100000 },
                    { "e5", "D4", 100000 },
                    { "e5", "D5", 100000 },
                    { "e5", "D6", 100000 },
                    { "e5", "D7", 100000 },
                    { "e5", "D8", 100000 },
                    { "e5", "D9", 100000 },
                    { "e5", "E1", 100000 },
                    { "e5", "E10", 100000 },
                    { "e5", "E11", 100000 },
                    { "e5", "E12", 100000 },
                    { "e5", "E13", 100000 },
                    { "e5", "E14", 100000 },
                    { "e5", "E15", 100000 },
                    { "e5", "E16", 100000 },
                    { "e5", "E17", 100000 },
                    { "e5", "E18", 100000 },
                    { "e5", "E2", 100000 },
                    { "e5", "E3", 100000 },
                    { "e5", "E4", 100000 },
                    { "e5", "E5", 100000 },
                    { "e5", "E6", 100000 },
                    { "e5", "E7", 100000 },
                    { "e5", "E8", 100000 },
                    { "e5", "E9", 100000 },
                    { "e5", "F1", 100000 },
                    { "e5", "F10", 100000 },
                    { "e5", "F11", 100000 },
                    { "e5", "F12", 100000 },
                    { "e5", "F13", 100000 },
                    { "e5", "F14", 100000 },
                    { "e5", "F15", 100000 },
                    { "e5", "F16", 100000 },
                    { "e5", "F17", 100000 },
                    { "e5", "F18", 100000 },
                    { "e5", "F2", 100000 },
                    { "e5", "F3", 100000 },
                    { "e5", "F4", 100000 },
                    { "e5", "F5", 100000 },
                    { "e5", "F6", 100000 },
                    { "e5", "F7", 100000 },
                    { "e5", "F8", 100000 },
                    { "e5", "F9", 100000 },
                    { "e6", "A1", 100000 },
                    { "e6", "A10", 100000 },
                    { "e6", "A11", 100000 },
                    { "e6", "A12", 100000 },
                    { "e6", "A13", 100000 },
                    { "e6", "A14", 100000 },
                    { "e6", "A15", 100000 },
                    { "e6", "A16", 100000 },
                    { "e6", "A17", 100000 },
                    { "e6", "A18", 100000 },
                    { "e6", "A2", 100000 },
                    { "e6", "A3", 100000 },
                    { "e6", "A4", 100000 },
                    { "e6", "A5", 100000 },
                    { "e6", "A6", 100000 },
                    { "e6", "A7", 100000 },
                    { "e6", "A8", 100000 },
                    { "e6", "A9", 100000 },
                    { "e6", "B1", 100000 },
                    { "e6", "B10", 100000 },
                    { "e6", "B11", 100000 },
                    { "e6", "B12", 100000 },
                    { "e6", "B13", 100000 },
                    { "e6", "B14", 100000 },
                    { "e6", "B15", 100000 },
                    { "e6", "B16", 100000 },
                    { "e6", "B17", 100000 },
                    { "e6", "B18", 100000 },
                    { "e6", "B2", 100000 },
                    { "e6", "B3", 100000 },
                    { "e6", "B4", 100000 },
                    { "e6", "B5", 100000 },
                    { "e6", "B6", 100000 },
                    { "e6", "B7", 100000 },
                    { "e6", "B8", 100000 },
                    { "e6", "B9", 100000 },
                    { "e6", "C1", 100000 },
                    { "e6", "C10", 100000 },
                    { "e6", "C11", 100000 },
                    { "e6", "C12", 100000 },
                    { "e6", "C13", 100000 },
                    { "e6", "C14", 100000 },
                    { "e6", "C15", 100000 },
                    { "e6", "C16", 100000 },
                    { "e6", "C17", 100000 },
                    { "e6", "C18", 100000 },
                    { "e6", "C2", 100000 },
                    { "e6", "C3", 100000 },
                    { "e6", "C4", 100000 },
                    { "e6", "C5", 100000 },
                    { "e6", "C6", 100000 },
                    { "e6", "C7", 100000 },
                    { "e6", "C8", 100000 },
                    { "e6", "C9", 100000 },
                    { "e6", "D1", 100000 },
                    { "e6", "D10", 100000 },
                    { "e6", "D11", 100000 },
                    { "e6", "D12", 100000 },
                    { "e6", "D13", 100000 },
                    { "e6", "D14", 100000 },
                    { "e6", "D15", 100000 },
                    { "e6", "D16", 100000 },
                    { "e6", "D17", 100000 },
                    { "e6", "D18", 100000 },
                    { "e6", "D2", 100000 },
                    { "e6", "D3", 100000 },
                    { "e6", "D4", 100000 },
                    { "e6", "D5", 100000 },
                    { "e6", "D6", 100000 },
                    { "e6", "D7", 100000 },
                    { "e6", "D8", 100000 },
                    { "e6", "D9", 100000 },
                    { "e6", "E1", 100000 },
                    { "e6", "E10", 100000 },
                    { "e6", "E11", 100000 },
                    { "e6", "E12", 100000 },
                    { "e6", "E13", 100000 },
                    { "e6", "E14", 100000 },
                    { "e6", "E15", 100000 },
                    { "e6", "E16", 100000 },
                    { "e6", "E17", 100000 },
                    { "e6", "E18", 100000 },
                    { "e6", "E2", 100000 },
                    { "e6", "E3", 100000 },
                    { "e6", "E4", 100000 },
                    { "e6", "E5", 100000 },
                    { "e6", "E6", 100000 },
                    { "e6", "E7", 100000 },
                    { "e6", "E8", 100000 },
                    { "e6", "E9", 100000 },
                    { "e6", "F1", 100000 },
                    { "e6", "F10", 100000 },
                    { "e6", "F11", 100000 },
                    { "e6", "F12", 100000 },
                    { "e6", "F13", 100000 },
                    { "e6", "F14", 100000 },
                    { "e6", "F15", 100000 },
                    { "e6", "F16", 100000 },
                    { "e6", "F17", 100000 },
                    { "e6", "F18", 100000 },
                    { "e6", "F2", 100000 },
                    { "e6", "F3", 100000 },
                    { "e6", "F4", 100000 },
                    { "e6", "F5", 100000 },
                    { "e6", "F6", 100000 },
                    { "e6", "F7", 100000 },
                    { "e6", "F8", 100000 },
                    { "e6", "F9", 100000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E9" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F1" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F10" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F11" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F12" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F13" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F14" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F15" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F16" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F17" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F18" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F2" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F3" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F4" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F5" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F6" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F7" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F8" });

            migrationBuilder.DeleteData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F9" });

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A1");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A10");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A11");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A12");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A13");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A14");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A15");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A16");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A17");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A18");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A2");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A3");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A4");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A5");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A6");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A7");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A8");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A9");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B1");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B10");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B11");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B12");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B13");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B14");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B15");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B16");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B17");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B18");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B2");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B3");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B4");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B5");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B6");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B7");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B8");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B9");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C1");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C10");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C11");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C12");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C13");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C14");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C15");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C16");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C17");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C18");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C2");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C3");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C4");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C5");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C6");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C7");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C8");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C9");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D1");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D10");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D11");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D12");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D13");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D14");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D15");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D16");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D17");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D18");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D2");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D3");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D4");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D5");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D6");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D7");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D8");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D9");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E1");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E10");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E11");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E12");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E13");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E14");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E15");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E16");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E17");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E18");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E2");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E3");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E4");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E5");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E6");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E7");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E8");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E9");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F1");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F10");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F11");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F12");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F13");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F14");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F15");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F16");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F17");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F18");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F2");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F3");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F4");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F5");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F6");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F7");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F8");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F9");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(2120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0f2cfd03-b1f5-46a1-886d-a1c8148da00d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "8a38fd6a-2d4e-40ec-95df-a7e3df4d78d2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 334, DateTimeKind.Local).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 610, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "93e68f37-b196-4d63-9e63-b323aaa3e0e5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f79276b1-a3f5-4274-95d5-74f2bed4637b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ed8ccd25-a581-4a6a-97ca-47c35b01277c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "12762196-b87a-4307-bec2-ce93f8e9878e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 16, 24, 24, 335, DateTimeKind.Local).AddTicks(6200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "12bd1d61-842e-437e-9a2c-8426edfa9cde",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "558296bc-c888-4c85-be03-9eb6aadc55fb");

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
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900), 80000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900), 70000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900), 65000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "CreatedAt", "MinPrice" },
                values: new object[] { new DateTime(2023, 7, 23, 16, 24, 24, 332, DateTimeKind.Local).AddTicks(8900), 1000000 });
        }
    }
}
