using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchingApp.Migrations
{
    public partial class ApplicationStudentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Applications_ApplicationId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Students",
                newName: "applicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ApplicationId",
                table: "Students",
                newName: "IX_Students_applicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Applications_applicationId",
                table: "Students",
                column: "applicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Applications_applicationId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "applicationId",
                table: "Students",
                newName: "ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_applicationId",
                table: "Students",
                newName: "IX_Students_ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Applications_ApplicationId",
                table: "Students",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
