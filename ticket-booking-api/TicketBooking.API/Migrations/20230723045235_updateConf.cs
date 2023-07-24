using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class updateConf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2fd11e58-1c19-431d-934a-07693a4b7042",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "17135a56-4c46-4381-b905-715316152b75");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 211, DateTimeKind.Local).AddTicks(6290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "71ed14ba-bc9c-4bef-b08a-a9f496d5c123",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "b12a49aa-bd3e-48ab-88fb-efca03a412e4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bf48edee-5ec8-4774-beaf-dde0f95a82d5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "55571418-4f6e-4b0c-90fc-31464cc73d51");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bf48aee6-1ba6-4806-b76d-8c2dc4ec8648",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "9502cbac-0426-468b-964d-8c9279f59670");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510), "7:30pm - 9:30pm" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510), "10:00pm - 11:30pm" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510), "7:30pm - 9:30pm" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510), "7:30pm - 9:30pm" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510), "6:30pm - 7:00pm" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510), "7:30pm - 9:30pm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Event");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(5280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "17135a56-4c46-4381-b905-715316152b75",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2fd11e58-1c19-431d-934a-07693a4b7042");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 211, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "b12a49aa-bd3e-48ab-88fb-efca03a412e4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "71ed14ba-bc9c-4bef-b08a-a9f496d5c123");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "55571418-4f6e-4b0c-90fc-31464cc73d51",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bf48edee-5ec8-4774-beaf-dde0f95a82d5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "9502cbac-0426-468b-964d-8c9279f59670",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bf48aee6-1ba6-4806-b76d-8c2dc4ec8648");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));
        }
    }
}
