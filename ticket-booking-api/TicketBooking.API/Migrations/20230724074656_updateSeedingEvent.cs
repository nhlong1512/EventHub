using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedingEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "548b610d-8067-46dd-91fa-ee1c91077699",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "8a38fd6a-2d4e-40ec-95df-a7e3df4d78d2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 214, DateTimeKind.Local).AddTicks(4490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 610, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6ac223c4-69ec-4051-adb3-c0355d0af2fb",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f79276b1-a3f5-4274-95d5-74f2bed4637b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "580b0885-814b-42cd-807f-afe230c2e939",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "12762196-b87a-4307-bec2-ce93f8e9878e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ff69adf6-9d7e-41a2-9e2d-a11a7a6c2b72",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "558296bc-c888-4c85-be03-9eb6aadc55fb");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133), "Theater & Play" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133), "Live music" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133), "Art & Culture" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133), "Nightlife" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "c10", null, "Sports", null },
                    { "c11", null, "Comunity", null },
                    { "c12", null, "Attractions", null },
                    { "c5", null, "Outdoor", null },
                    { "c6", null, "Conference", null },
                    { "c7", null, "Seminar", null },
                    { "c8", null, "Exhibitions", null },
                    { "c9", null, "Meetups", null }
                });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                columns: new[] { "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "https://images.tkbcdn.com/1/1560/600/Upload/eventcover/2023/07/18/AA2A4B.jpg", "The Nest, Thôn Măng Lin, Phường 7, Đà Lạt", 350000, "[MÂY LANG THANG] LIVESHOW PHAN MẠNH QUỲNH KM TRẦN MINH DŨNG" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                columns: new[] { "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "https://images.tkbcdn.com/1/1560/600/Upload/eventcover/2023/07/18/238BEE.jpg", "The Nest, Thôn Măng Lin, Phường 7, Đà Lạt", 450000, "[MÂY LANG THANG] PHƯƠNG UYÊN" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice" },
                values: new object[] { "Hà Nội", new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "https://images.tkbcdn.com/1/1560/600/Upload/eventcover/2023/07/13/23D46F.jpg", "Rạp Đại Nam, 89 Phố Huế, Ngô Thì Nhậm, Hai Bà Trưng, Hà Nội", 5000000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { "Cần Thơ", new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "https://images.tkbcdn.com/1/1560/600/Upload/eventcover/2023/07/23/B8A309.jpg", "209 Đường 30 Tháng 4, Xuân Khánh, Ninh Kiều, TP. Cần Thơ", 350000, "[MÂY LANG THANG CẦN THƠ] LIVESHOW ƯNG HOÀNG PHÚC & PHẠM QUỲNH ANH" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { "", new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "https://images.tkbcdn.com/1/1560/600/Upload/eventcover/2023/07/23/46B510.jpg", "Bờ Đông cầu Rồng, đường Trần Hưng Đạo, quận Sơn Trà, Đà Nẵng", 500000, "[MÂY LANG THANG ĐÀ NẴNG] LIVESHOW TRUNG QUÂN IDOL" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { "", new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399), "https://images.tkbcdn.com/1/1560/600/Upload/eventcover/2023/07/10/AA7A83.jpg", "NHÀ HÁT GIAO HƯỞNG NHẠC VŨ KỊCH TP. HỒ CHÍ MINH", 450000, "[HBSO] ROCK SYMPHONY VOL.3" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c10");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c11");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c12");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c5");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c6");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c7");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c8");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 216, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "8a38fd6a-2d4e-40ec-95df-a7e3df4d78d2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "548b610d-8067-46dd-91fa-ee1c91077699");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 610, DateTimeKind.Local).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 214, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f79276b1-a3f5-4274-95d5-74f2bed4637b",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6ac223c4-69ec-4051-adb3-c0355d0af2fb");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 212, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "12762196-b87a-4307-bec2-ce93f8e9878e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "580b0885-814b-42cd-807f-afe230c2e939");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 24, 14, 46, 55, 217, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "558296bc-c888-4c85-be03-9eb6aadc55fb",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "ff69adf6-9d7e-41a2-9e2d-a11a7a6c2b72");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530), "Theater" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530), "Music" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530), "Comedy" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(8530), "Play" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                columns: new[] { "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), "https://gonewiththetwins.com/new/wp-content/uploads/2016/06/click.jpg", "CGV Phu Tho", 60000, "The click" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                columns: new[] { "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), "https://kenhcine.cgv.vn/media/catalog/product/1/5/1545333390524.jpg", "CGV Phu Tho", 70000, "Man in Black V" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice" },
                values: new object[] { "", new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), "https://toplist.vn/images/800px/django-unchained-151603.jpg", "CGV Hung Vuong", 100000 });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { "Hà Nội", new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), "https://kenh14cdn.com/thumb_w/600/203336854389633024/2022/12/13/photo1670894930473-1670894930937151252993.png", "New Arena Theater", 100000, "Gala Cười 2023" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { "Hà Nội", new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), "https://static2.yan.vn/YanNews/2167221/202110/sky-tour-movie-tuoi-tre-nhiet-huyet-va-dam-me-cua-son-tung-mtp-08241d81.jpg", "New Arena Theater", 100000, "Sky Tour" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "City", "CreatedAt", "Image", "Location", "MinPrice", "Title" },
                values: new object[] { "Hà Nội", new DateTime(2023, 7, 23, 18, 3, 47, 609, DateTimeKind.Local).AddTicks(8720), "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/4/2/895272/Anh_2_Mytam_PR03.JPG", "The Savarin Theater", 100000, "Mỹ Tâm - Liveshow tri âm" });

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "A9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "B9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "C9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "D9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "E9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F10",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F11",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F12",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F13",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F14",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F15",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F16",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F17",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F18",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F7",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F8",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: "F9",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 18, 3, 47, 611, DateTimeKind.Local).AddTicks(5770));
        }
    }
}
