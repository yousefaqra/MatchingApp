using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchingApp.Migrations
{
    public partial class UniqeApplicationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AlternaeveKey_ApplicationName",
                table: "Applications",
                column: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternaeveKey_ApplicationName",
                table: "Applications");
        }
    }
}
