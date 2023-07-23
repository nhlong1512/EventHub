using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValue: "a480bf3a-6fc7-4c4a-aea5-6342e1cc8119"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050)),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValue: "6cf475ff-a220-4e52-9e63-136780a522f8"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPrice = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 11, 21, 15, 0, 0, DateTimeKind.Unspecified)),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790)),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValue: "78c6790c-983a-4206-8a65-75643b2f129a"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(6110)),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventCategory",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCategory", x => new { x.EventId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_EventCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventCategory_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValue: "a8a41a10-b573-4fca-9e76-fbc588fc55d9"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(4800)),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatEvent",
                columns: table => new
                {
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeatStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatEvent", x => new { x.EventId, x.SeatId });
                    table.ForeignKey(
                        name: "FK_SeatEvent_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatEvent_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatInvoice",
                columns: table => new
                {
                    SeatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatInvoice", x => new { x.InvoiceId, x.SeatId });
                    table.ForeignKey(
                        name: "FK_SeatInvoice_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatInvoice_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "c1", null, "Theater", null },
                    { "c2", null, "Music", null },
                    { "c3", null, "Comedy", null },
                    { "c4", null, "Play", null }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "City", "DeletedAt", "Image", "Location", "MinPrice", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { "e1", "", null, "https://gonewiththetwins.com/new/wp-content/uploads/2016/06/click.jpg", "CGV Phu Tho", 60000, "The click", null },
                    { "e2", "", null, "https://kenhcine.cgv.vn/media/catalog/product/1/5/1545333390524.jpg", "CGV Phu Tho", 70000, "Man in Black V", null },
                    { "e3", "", null, "https://toplist.vn/images/800px/django-unchained-151603.jpg", "CGV Hung Vuong", 80000, "Django unchained", null },
                    { "e4", "Hà Nội", null, "https://kenh14cdn.com/thumb_w/600/203336854389633024/2022/12/13/photo1670894930473-1670894930937151252993.png", "New Arena Theater", 70000, "Gala Cười 2023", null },
                    { "e5", "Hà Nội", null, "https://static2.yan.vn/YanNews/2167221/202110/sky-tour-movie-tuoi-tre-nhiet-huyet-va-dam-me-cua-son-tung-mtp-08241d81.jpg", "New Arena Theater", 65000, "Sky Tour", null },
                    { "e6", "Hà Nội", null, "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/4/2/895272/Anh_2_Mytam_PR03.JPG", "The Savarin Theater", 1000000, "Mỹ Tâm - Liveshow tri âm", null }
                });

            migrationBuilder.InsertData(
                table: "EventCategory",
                columns: new[] { "CategoryId", "EventId" },
                values: new object[,]
                {
                    { "c1", "e1" },
                    { "c1", "e2" },
                    { "c1", "e3" },
                    { "c3", "e4" },
                    { "c2", "e5" },
                    { "c4", "e5" },
                    { "c2", "e6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventCategory_CategoryId",
                table: "EventCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_EventId",
                table: "Invoice",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatEvent_SeatId",
                table: "SeatEvent",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatInvoice_SeatId",
                table: "SeatInvoice",
                column: "SeatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventCategory");

            migrationBuilder.DropTable(
                name: "SeatEvent");

            migrationBuilder.DropTable(
                name: "SeatInvoice");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
