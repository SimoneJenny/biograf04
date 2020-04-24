using Microsoft.EntityFrameworkCore.Migrations;

namespace biograf01.Migrations
{
    public partial class trytheatertowork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "row",
                table: "Theater",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "seat",
                table: "Theater",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "theaternumbIds",
                table: "Theater",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "row",
                table: "Theater");

            migrationBuilder.DropColumn(
                name: "seat",
                table: "Theater");

            migrationBuilder.DropColumn(
                name: "theaternumbIds",
                table: "Theater");
        }
    }
}
