using Microsoft.EntityFrameworkCore.Migrations;

namespace biograf01.Migrations
{
    public partial class genrenumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Genrenumber",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genrenumber",
                table: "Movies");
        }
    }
}
