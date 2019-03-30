using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchingApp.Migrations
{
    public partial class UniqeZajelID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AlternaeveKey_ZajelId",
                table: "Students",
                column: "ZajelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternaeveKey_ZajelId",
                table: "Students");
        }
    }
}
