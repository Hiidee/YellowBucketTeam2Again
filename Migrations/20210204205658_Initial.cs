using Microsoft.EntityFrameworkCore.Migrations;

namespace YellowBucket.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Movie_RatingId",
                table: "Movie",
                column: "RatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Rating_RatingId",
                table: "Movie",
                column: "RatingId",
                principalTable: "Rating",
                principalColumn: "RatingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Rating_RatingId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_RatingId",
                table: "Movie");
        }
    }
}
