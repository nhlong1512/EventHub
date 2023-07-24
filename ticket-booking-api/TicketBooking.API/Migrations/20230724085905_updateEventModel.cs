using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class updateEventModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "205e7a67-3054-471c-b93f-ca3a5784814b",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "cdd519ad-01cb-44b9-8206-17e30a45affd");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 594, DateTimeKind.Local).AddTicks(5815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 902, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ac9ed032-b211-4bac-864e-7b1551bedc3e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "c787e20b-bf82-4f96-a7e8-7d1c7e156bfe");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5d0a0813-479f-4a92-b4fa-861222ace024",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "e20a63a1-06e2-4421-bcb8-35bff0cfea7d");

            migrationBuilder.AddColumn<string>(
                name: "StageName",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d014d303-ef13-4201-b8d0-ec76463324ea",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ce0d2b81-42e8-4c3e-a645-9806c61662bd");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                columns: new[] { "CreatedAt", "StageName" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964), "Mây In The Nest" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                columns: new[] { "CreatedAt", "StageName" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964), "Mây In The Nest" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "CreatedAt", "Location", "StageName" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964), "89 Phố Huế, Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội", "Rạp Đại Nam" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "CreatedAt", "StageName" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964), "Nhà Hát Lớn" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "CreatedAt", "StageName" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964), "SHERATON Đà Nẵng" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "CreatedAt", "Location", "StageName" },
                values: new object[] { new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964), "89 Phố Huế, Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội", "NHÀ HÁT GIAO HƯỞNG NHẠC VŨ KỊCH" });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A1" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A10" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A11" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A12" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A13" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A14" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A15" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A16" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A17" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A18" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A2" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A3" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A4" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A5" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A6" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A7" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A8" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A9" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B1" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B10" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B11" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B12" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B13" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B14" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B15" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B16" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B17" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B18" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B2" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B3" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B4" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B5" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B6" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B7" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B8" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B9" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C1" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C10" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C11" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C12" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C13" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C14" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C15" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C16" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C17" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C18" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C2" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C3" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C4" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C5" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C6" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C7" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C8" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C9" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D1" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D10" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D11" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D12" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D13" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D14" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D15" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D16" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D17" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D18" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D2" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D3" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D4" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D5" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D6" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D7" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D8" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D9" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E1" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E10" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E11" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E12" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E13" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E14" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E15" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E16" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E17" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E18" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E2" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E3" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E4" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E5" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E6" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E7" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E8" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E9" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F1" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F10" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F11" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F12" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F13" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F14" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F15" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F16" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F17" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F18" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F2" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F3" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F4" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F5" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F6" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F7" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F8" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F9" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A1" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A10" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A11" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A12" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A13" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A14" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A15" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A16" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A17" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A18" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A2" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A3" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A4" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A5" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A6" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A7" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A8" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A9" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B1" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B10" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B11" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B12" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B13" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B14" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B15" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B16" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B17" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B18" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B2" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B3" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B4" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B5" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B6" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B7" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B8" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B9" },
                column: "Price",
                value: 350000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C1" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C10" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C11" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C12" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C13" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C14" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C15" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C16" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C17" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C18" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C2" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C3" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C4" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C5" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C6" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C7" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C8" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C9" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D1" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D10" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D11" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D12" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D13" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D14" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D15" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D16" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D17" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D18" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D2" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D3" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D4" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D5" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D6" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D7" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D8" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D9" },
                column: "Price",
                value: 400000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E1" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E10" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E11" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E12" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E13" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E14" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E15" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E16" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E17" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E18" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E2" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E3" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E4" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E5" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E6" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E7" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E8" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E9" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F1" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F10" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F11" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F12" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F13" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F14" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F15" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F16" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F17" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F18" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F2" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F3" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F4" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F5" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F6" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F7" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F8" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F9" },
                column: "Price",
                value: 600000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B1" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B10" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B11" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B12" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B13" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B14" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B15" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B16" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B17" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B18" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B2" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B3" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B4" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B5" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B6" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B7" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B8" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B9" },
                column: "Price",
                value: 450000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D1" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D10" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D11" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D12" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D13" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D14" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D15" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D16" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D17" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D18" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D2" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D3" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D4" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D5" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D6" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D7" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D8" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D9" },
                column: "Price",
                value: 500000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E9" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F1" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F10" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F11" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F12" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F13" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F14" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F15" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F16" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F17" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F18" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F2" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F3" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F4" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F5" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F6" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F7" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F8" },
                column: "Price",
                value: 550000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F9" },
                column: "Price",
                value: 550000);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StageName",
                table: "Event");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 904, DateTimeKind.Local).AddTicks(4800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 596, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "cdd519ad-01cb-44b9-8206-17e30a45affd",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "205e7a67-3054-471c-b93f-ca3a5784814b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 902, DateTimeKind.Local).AddTicks(6317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 594, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "c787e20b-bf82-4f96-a7e8-7d1c7e156bfe",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ac9ed032-b211-4bac-864e-7b1551bedc3e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 592, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "e20a63a1-06e2-4421-bcb8-35bff0cfea7d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5d0a0813-479f-4a92-b4fa-861222ace024");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 58, 8, 905, DateTimeKind.Local).AddTicks(751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 15, 59, 4, 597, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ce0d2b81-42e8-4c3e-a645-9806c61662bd",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d014d303-ef13-4201-b8d0-ec76463324ea");

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
                columns: new[] { "CreatedAt", "Location" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949), "Rạp Đại Nam, 89 Phố Huế, Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội" });

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
                columns: new[] { "CreatedAt", "Location" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 58, 8, 900, DateTimeKind.Local).AddTicks(3949), "NHÀ HÁT GIAO HƯỞNG NHẠC VŨ KỊCH TP. HỒ CHÍ MINH" });

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

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A1" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A10" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A11" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A12" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A13" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A14" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A15" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A16" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A17" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A18" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A2" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A3" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A4" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A5" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A6" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A7" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A8" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "A9" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B1" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B10" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B11" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B12" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B13" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B14" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B15" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B16" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B17" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B18" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B2" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B3" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B4" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B5" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B6" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B7" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B8" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "B9" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C1" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C10" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C11" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C12" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C13" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C14" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C15" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C16" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C17" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C18" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C2" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C3" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C4" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C5" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C6" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C7" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C8" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "C9" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D1" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D10" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D11" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D12" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D13" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D14" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D15" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D16" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D17" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D18" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D2" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D3" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D4" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D5" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D6" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D7" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D8" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "D9" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E1" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E10" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E11" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E12" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E13" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E14" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E15" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E16" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E17" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E18" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E2" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E3" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E4" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E5" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E6" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E7" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E8" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "E9" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F1" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F10" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F11" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F12" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F13" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F14" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F15" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F16" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F17" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F18" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F2" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F3" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F4" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F5" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F6" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F7" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F8" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e1", "F9" },
                column: "Price",
                value: 60000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A1" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A10" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A11" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A12" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A13" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A14" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A15" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A16" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A17" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A18" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A2" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A3" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A4" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A5" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A6" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A7" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A8" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "A9" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B1" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B10" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B11" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B12" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B13" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B14" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B15" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B16" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B17" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B18" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B2" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B3" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B4" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B5" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B6" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B7" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B8" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "B9" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C1" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C10" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C11" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C12" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C13" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C14" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C15" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C16" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C17" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C18" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C2" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C3" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C4" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C5" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C6" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C7" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C8" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "C9" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D1" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D10" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D11" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D12" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D13" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D14" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D15" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D16" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D17" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D18" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D2" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D3" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D4" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D5" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D6" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D7" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D8" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "D9" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E1" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E10" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E11" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E12" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E13" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E14" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E15" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E16" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E17" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E18" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E2" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E3" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E4" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E5" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E6" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E7" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E8" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "E9" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F1" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F10" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F11" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F12" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F13" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F14" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F15" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F16" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F17" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F18" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F2" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F3" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F4" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F5" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F6" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F7" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F8" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e2", "F9" },
                column: "Price",
                value: 70000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "A9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "B9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "C9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "D9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "E9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e3", "F9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "A9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "B9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "C9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "D9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "E9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e4", "F9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "A9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "B9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "C9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "D9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "E9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e5", "F9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "A9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "B9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "C9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "D9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "E9" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F1" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F10" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F11" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F12" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F13" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F14" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F15" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F16" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F17" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F18" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F2" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F3" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F4" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F5" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F6" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F7" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F8" },
                column: "Price",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "SeatEvent",
                keyColumns: new[] { "EventId", "SeatId" },
                keyValues: new object[] { "e6", "F9" },
                column: "Price",
                value: 100000);
        }
    }
}
