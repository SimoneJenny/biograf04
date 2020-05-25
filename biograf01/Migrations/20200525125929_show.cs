using Microsoft.EntityFrameworkCore.Migrations;

namespace biograf01.Migrations
{
    public partial class show : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_Movies_movieId",
                table: "Show");

            migrationBuilder.DropForeignKey(
                name: "FK_Show_Theater_theaterId",
                table: "Show");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Show",
                table: "Show");

            migrationBuilder.RenameColumn(
                name: "theaterId",
                table: "Show",
                newName: "TheaterId");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Show",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Show_theaterId",
                table: "Show",
                newName: "IX_Show_TheaterId");

            migrationBuilder.AlterColumn<int>(
                name: "TheaterId",
                table: "Show",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Show",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "showId",
                table: "Show",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Show",
                table: "Show",
                column: "showId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_MovieId",
                table: "Show",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Show_Movies_MovieId",
                table: "Show",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Show_Theater_TheaterId",
                table: "Show",
                column: "TheaterId",
                principalTable: "Theater",
                principalColumn: "TheaterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_Movies_MovieId",
                table: "Show");

            migrationBuilder.DropForeignKey(
                name: "FK_Show_Theater_TheaterId",
                table: "Show");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Show",
                table: "Show");

            migrationBuilder.DropIndex(
                name: "IX_Show_MovieId",
                table: "Show");

            migrationBuilder.DropColumn(
                name: "showId",
                table: "Show");

            migrationBuilder.RenameColumn(
                name: "TheaterId",
                table: "Show",
                newName: "theaterId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Show",
                newName: "movieId");

            migrationBuilder.RenameIndex(
                name: "IX_Show_TheaterId",
                table: "Show",
                newName: "IX_Show_theaterId");

            migrationBuilder.AlterColumn<int>(
                name: "theaterId",
                table: "Show",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "movieId",
                table: "Show",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Show",
                table: "Show",
                columns: new[] { "movieId", "theaterId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Show_Movies_movieId",
                table: "Show",
                column: "movieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Show_Theater_theaterId",
                table: "Show",
                column: "theaterId",
                principalTable: "Theater",
                principalColumn: "TheaterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
