using Microsoft.EntityFrameworkCore.Migrations;

namespace YellowBucket.Migrations
{
    public partial class RenamedIdFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating_ID",
                table: "Rating",
                newName: "RatingId");

            migrationBuilder.RenameColumn(
                name: "Rating_ID",
                table: "Movie",
                newName: "RatingId");

            migrationBuilder.RenameColumn(
                name: "Genre_ID",
                table: "Movie",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "Movie_ID",
                table: "Movie",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "Genre_ID",
                table: "Genre",
                newName: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_GenreId",
                table: "Movie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_GenreId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_GenreId",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "RatingId",
                table: "Rating",
                newName: "Rating_ID");

            migrationBuilder.RenameColumn(
                name: "RatingId",
                table: "Movie",
                newName: "Rating_ID");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Movie",
                newName: "Genre_ID");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movie",
                newName: "Movie_ID");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genre",
                newName: "Genre_ID");
        }
    }
}
