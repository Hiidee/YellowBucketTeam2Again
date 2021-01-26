using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YellowBucket.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Movie_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(128)", nullable: true),
                    Rating_ID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(4096)", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Genre_ID = table.Column<int>(type: "int", nullable: false),
                    Is_Dvd = table.Column<bool>(type: "bit", nullable: false),
                    Is_BluRay = table.Column<bool>(type: "bit", nullable: false),
                    Cover_Photo = table.Column<string>(type: "varchar(128)", nullable: true),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Movie_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
