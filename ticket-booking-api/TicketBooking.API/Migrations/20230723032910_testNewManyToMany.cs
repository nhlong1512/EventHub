using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class testNewManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(5280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "17135a56-4c46-4381-b905-715316152b75",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "78c6790c-983a-4206-8a65-75643b2f129a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(3960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "b12a49aa-bd3e-48ab-88fb-efca03a412e4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a8a41a10-b573-4fca-9e76-fbc588fc55d9");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "55571418-4f6e-4b0c-90fc-31464cc73d51",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6cf475ff-a220-4e52-9e63-136780a522f8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "9502cbac-0426-468b-964d-8c9279f59670",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "a480bf3a-6fc7-4c4a-aea5-6342e1cc8119");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Seat",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(6110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "78c6790c-983a-4206-8a65-75643b2f129a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "17135a56-4c46-4381-b905-715316152b75");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(4800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a8a41a10-b573-4fca-9e76-fbc588fc55d9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "b12a49aa-bd3e-48ab-88fb-efca03a412e4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 628, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6cf475ff-a220-4e52-9e63-136780a522f8",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "55571418-4f6e-4b0c-90fc-31464cc73d51");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 10, 29, 10, 629, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "a480bf3a-6fc7-4c4a-aea5-6342e1cc8119",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "9502cbac-0426-468b-964d-8c9279f59670");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: "c4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e1",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                column: "CreatedAt",
                value: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));
        }
    }
}
