using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace biograf01.Migrations
{
    public partial class genrechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genres = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ReleaseDateTime = table.Column<DateTime>(nullable: false),
                    Runtime = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    MainActors = table.Column<string>(nullable: true),
                    Theater = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    seatsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avalible = table.Column<bool>(nullable: false),
                    seat = table.Column<int>(nullable: false),
                    row = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.seatsId);
                });

            migrationBuilder.CreateTable(
                name: "Theater",
                columns: table => new
                {
                    TheaterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seat = table.Column<int>(nullable: false),
                    row = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theater", x => x.TheaterId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    usersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    mailAddress = table.Column<string>(nullable: true),
                    ZipCodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.usersId);
                });

            migrationBuilder.CreateTable(
                name: "zipCode",
                columns: table => new
                {
                    zipcodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zipcode = table.Column<int>(nullable: false),
                    city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zipCode", x => x.zipcodeId);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenre",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenre", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MovieGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenre_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Show",
                columns: table => new
                {
                    showId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(nullable: true),
                    runtime = table.Column<DateTime>(nullable: false),
                    TheaterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show", x => x.showId);
                    table.ForeignKey(
                        name: "FK_Show_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Show_Theater_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theater",
                        principalColumn: "TheaterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "theaterSeats",
                columns: table => new
                {
                    SeatId = table.Column<int>(nullable: false),
                    TheaterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theaterSeats", x => new { x.TheaterId, x.SeatId });
                    table.ForeignKey(
                        name: "FK_theaterSeats_seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "seats",
                        principalColumn: "seatsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_theaterSeats_Theater_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theater",
                        principalColumn: "TheaterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userZipCode",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    zipcodeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userZipCode", x => new { x.UserId, x.ZipCode });
                    table.ForeignKey(
                        name: "FK_userZipCode_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "usersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userZipCode_zipCode_zipcodeId",
                        column: x => x.zipcodeId,
                        principalTable: "zipCode",
                        principalColumn: "zipcodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_GenreId",
                table: "MovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_MovieId",
                table: "Show",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Show_TheaterId",
                table: "Show",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_theaterSeats_SeatId",
                table: "theaterSeats",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_userZipCode_zipcodeId",
                table: "userZipCode",
                column: "zipcodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenre");

            migrationBuilder.DropTable(
                name: "Show");

            migrationBuilder.DropTable(
                name: "theaterSeats");

            migrationBuilder.DropTable(
                name: "userZipCode");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "seats");

            migrationBuilder.DropTable(
                name: "Theater");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "zipCode");
        }
    }
}
