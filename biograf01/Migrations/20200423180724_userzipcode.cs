using Microsoft.EntityFrameworkCore.Migrations;

namespace biograf01.Migrations
{
    public partial class userzipcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_userZipCode_zipcodeId",
                table: "userZipCode",
                column: "zipcodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userZipCode");
        }
    }
}
