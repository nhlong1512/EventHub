using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class updateconf2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f06b00da-ca7b-4741-8e2f-91f6040cede3",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2fd11e58-1c19-431d-934a-07693a4b7042");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(4030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 211, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "430ed8ed-2cb5-46f0-9331-5abbcc3adf8b",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "71ed14ba-bc9c-4bef-b08a-a9f496d5c123");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "34bb58bb-6557-417e-bfa7-f01aa99148f0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bf48edee-5ec8-4774-beaf-dde0f95a82d5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "34ace022-a72d-47db-b2d4-693357dd901d",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "bf48aee6-1ba6-4806-b76d-8c2dc4ec8648");

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
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360), "7:30 PM - 9:30 PM" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e2",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360), "10:00 PM - 11:30 PM" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e3",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360), "7:30 PM - 9:30 PM" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e4",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360), "7:30 PM - 9:30 PM" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e5",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360), "6:30 PM - 7:00 PM" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: "e6",
                columns: new[] { "CreatedAt", "Duration" },
                values: new object[] { new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360), "7:30 PM - 9:30 PM" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2fd11e58-1c19-431d-934a-07693a4b7042",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f06b00da-ca7b-4741-8e2f-91f6040cede3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Invoice",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 211, DateTimeKind.Local).AddTicks(6290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 975, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "71ed14ba-bc9c-4bef-b08a-a9f496d5c123",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "430ed8ed-2cb5-46f0-9331-5abbcc3adf8b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Event",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 210, DateTimeKind.Local).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 974, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Event",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bf48edee-5ec8-4774-beaf-dde0f95a82d5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "34bb58bb-6557-417e-bfa7-f01aa99148f0");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Category",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 7, 23, 11, 52, 35, 212, DateTimeKind.Local).AddTicks(3470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 7, 23, 11, 57, 45, 976, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Category",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "bf48aee6-1ba6-4806-b76d-8c2dc4ec8648",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "34ace022-a72d-47db-b2d4-693357dd901d");

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
    }
}
