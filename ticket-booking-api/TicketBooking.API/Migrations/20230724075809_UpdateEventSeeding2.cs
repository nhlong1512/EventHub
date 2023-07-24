using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEventSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "cdd519ad-01cb-44b9-8206-17e30a45affd",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "548b610d-8067-46dd-91fa-ee1c91077699");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 902, DateTimeKind.Local).AddTicks(6317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 214, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "c787e20b-bf82-4f96-a7e8-7d1c7e156bfe",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6ac223c4-69ec-4051-adb3-c0355d0af2fb");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e20a63a1-06e2-4421-bcb8-35bff0cfea7d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "580b0885-814b-42cd-807f-afe230c2e939");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ce0d2b81-42e8-4c3e-a645-9806c61662bd",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ff69adf6-9d7e-41a2-9e2d-a11a7a6c2b72");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949), "[MÂY LANG THANG HÀ NỘI] LIVESHOW TUẤN NGỌC" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "548b610d-8067-46dd-91fa-ee1c91077699",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "cdd519ad-01cb-44b9-8206-17e30a45affd");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 214, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 902, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6ac223c4-69ec-4051-adb3-c0355d0af2fb",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "c787e20b-bf82-4f96-a7e8-7d1c7e156bfe");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "580b0885-814b-42cd-807f-afe230c2e939",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e20a63a1-06e2-4421-bcb8-35bff0cfea7d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ff69adf6-9d7e-41a2-9e2d-a11a7a6c2b72",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ce0d2b81-42e8-4c3e-a645-9806c61662bd");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "CreatedAt", "Title" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "Django unchained" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));
        }
    }
}
