using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YellowBucket.Migrations
{
    public partial class addedKiosk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(128)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(128)", nullable: true),
                    Email = table.Column<string>(type: "varchar(128)", nullable: true),
                    Password = table.Column<string>(type: "varchar(128)", nullable: true),
                    Address = table.Column<string>(type: "varchar(128)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(128)", nullable: true),
                    City = table.Column<string>(type: "varchar(128)", nullable: true),
                    State = table.Column<string>(type: "varchar(2)", nullable: true),
                    Zip = table.Column<string>(type: "varchar(128)", nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Kiosk",
                columns: table => new
                {
                    KioskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "varchar(128)", nullable: true),
                    Address = table.Column<string>(type: "varchar(128)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(128)", nullable: true),
                    City = table.Column<string>(type: "varchar(128)", nullable: true),
                    State = table.Column<string>(type: "varchar(2)", nullable: true),
                    Zip = table.Column<string>(type: "varchar(128)", nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kiosk", x => x.KioskId);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Review",
                columns: table => new
                {
                    Customer_ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "varchar(4096)", nullable: true),
                    Kernals = table.Column<int>(type: "int", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Review", x => x.Customer_ReviewId);
                    table.ForeignKey(
                        name: "FK_Customer_Review_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Review_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    WishlistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.WishlistId);
                    table.ForeignKey(
                        name: "FK_Wishlist_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlist_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KioskId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Dvd = table.Column<int>(type: "int", nullable: false),
                    BluRay = table.Column<int>(type: "int", nullable: false),
                    IsRented = table.Column<int>(type: "int", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_Inventory_Kiosk_KioskId",
                        column: x => x.KioskId,
                        principalTable: "Kiosk",
                        principalColumn: "KioskId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventory_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Rental_KioskId = table.Column<int>(type: "int", nullable: false),
                    Rental_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Return_KioskId = table.Column<int>(type: "int", nullable: false),
                    Return_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalsId);
                    table.ForeignKey(
                        name: "FK_Rentals_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Review_CustomerId",
                table: "Customer_Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Review_MovieId",
                table: "Customer_Review",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_KioskId",
                table: "Inventory",
                column: "KioskId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_MovieId",
                table: "Inventory",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_InventoryId",
                table: "Rentals",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_CustomerId",
                table: "Wishlist",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_MovieId",
                table: "Wishlist",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Review");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Kiosk");
        }
    }
}
