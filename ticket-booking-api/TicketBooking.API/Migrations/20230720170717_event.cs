using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class @event : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "CreatedAt", "Date", "DeletedAt", "Image", "Location", "Price", "Title", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("08ec5cda-2167-4763-8062-a35ef7dca916"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://i.ytimg.com/vi/Qmlio2iEaJo/maxresdefault.jpg", "CGV Hung Vuong Plaza, Ho Chi Minh City", 100000, "Thor: Love and Thunder", 0, null },
                    { new Guid("697e2858-9716-4457-98b0-90c15e1cae52"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://cdn-i.vtcnews.vn/resize/Da9xKKWytSr4nFIRCPjyxBQ21LK9PQ2a0/upload/2023/06/30/blackpink-07424148.jpg", "My Dinh stadium, Ha Noi", 1000000, "BlackPink world tour Ha Noi", 1, null },
                    { new Guid("87eb9e31-e58d-4681-af0b-44ff79a0639b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://i.ytimg.com/vi/J7xEJnqlIuU/maxresdefault.jpg", "Nu Cuoi Moi theater, Ho Chi Minh City", 200000, "Liveshow Nu Cuoi Moi", 6, null },
                    { new Guid("cf4f93bb-c097-470f-b5f8-665a2c46e4d7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://cdn.bongdaplus.vn/Assets/Media/2021/01/13/62/lich-thi-dau-v-league-2021-giai-doan-1.jpg", "Sam Son Stadium, Binh Duong", 120000, "Becamex Binh Duong vs. Hoang Anh Gia Lai", 2, null },
                    { new Guid("e2244242-d47b-4002-a1a0-eda359443f17"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://cdn.bongdaplus.vn/Assets/Media/2021/01/13/62/lich-thi-dau-v-league-2021-giai-doan-1.jpg", "Phu Tho Stadium, Ho Chi Minh City", 120000, "Viettel vs. Song Lam Nghe An", 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
